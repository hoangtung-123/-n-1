using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyCaPhe.BUS;



namespace QuanLyCaPhe.GUI.BaoCao
{
    public partial class frmBaoCao : Form
    {
        private readonly BaoCaoBUS bcBUS = new BaoCaoBUS();
        private string currentFilter = "Thang";   // Mặc định theo tháng

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            SetupDateTimePicker();

            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;

            SetupCharts();

            // Mặc định hiển thị theo tháng
            currentFilter = "Thang";
            HighlightFilterButton(btnFilterThang);

            LoadTongQuan();
            LoadChartDoanhThu();
            LoadChartTopMon();
            LoadBaoCaoHoaDon();
        }

        private void SetupDateTimePicker()
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";
        }

        private void SetupCharts()
        {
            // Chart Doanh thu
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.ChartAreas.Add(new ChartArea());

            Series seriesDT = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.SteelBlue
            };
            chartDoanhThu.Series.Add(seriesDT);
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Doanh thu theo tháng");

            // Chart Top 5 món bán chạy
            chartTopMon.Series.Clear();
            chartTopMon.ChartAreas.Clear();
            chartTopMon.ChartAreas.Add(new ChartArea());
            Series seriesTM = new Series("TopMon")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            chartTopMon.Series.Add(seriesTM);
            chartTopMon.Titles.Clear();
            chartTopMon.Titles.Add("Top 5 Món Bán Chạy");
        }

        private void LoadTongQuan()
        {
            decimal tongDT = bcBUS.TongDoanhThu(dtFrom.Value, dtTo.Value);
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDT.ToString("#,##0") + " VNĐ";

            int tongHD = bcBUS.TongHoaDon(dtFrom.Value, dtTo.Value);
            lblTongHoaDon.Text = "Tổng hóa đơn: " + tongHD.ToString();

            int tongPN = bcBUS.TongPhieuNhap(dtFrom.Value, dtTo.Value);
            lblTongPhieuNhap.Text = "Tổng phiếu nhập: " + tongPN.ToString();

            int tongTon = bcBUS.TongTonKho();
            lblTongTonKho.Text = "Tổng tồn kho: " + tongTon.ToString() + " (sp/kg)";
        }

        private void LoadChartDoanhThu()
        {
            chartDoanhThu.Series["DoanhThu"].Points.Clear();

            DataTable dt;
            string title = "";

            if (currentFilter == "Ngay")
            {
                dt = bcBUS.DoanhThuTheoNgay(dtFrom.Value, dtTo.Value);
                title = "Doanh thu theo ngày";
            }
            else if (currentFilter == "Nam")
            {
                dt = bcBUS.DoanhThuTheoNam(dtFrom.Value, dtTo.Value);
                title = "Doanh thu theo năm";
            }
            else // Tháng
            {
                dt = bcBUS.DoanhThuTheoThang(dtFrom.Value, dtTo.Value);
                title = "Doanh thu theo tháng";
            }

            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(title);

            foreach (DataRow row in dt.Rows)
            {
                string label = row[0].ToString();
                decimal value = Convert.ToDecimal(row[1]);
                chartDoanhThu.Series["DoanhThu"].Points.AddXY(label, value);
            }
        }

        private void LoadChartTopMon()
        {
            chartTopMon.Series["TopMon"].Points.Clear();

            DataTable dt = bcBUS.TopMonBan();

            // LẤY TOP 5 MÓN BÁN CHẠY
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (count >= 5) break;   // Chỉ lấy 5 món

                chartTopMon.Series["TopMon"].Points.AddXY(
                    row["TenMon"].ToString(),
                    Convert.ToInt32(row["SoLuongBan"]));

                count++;
            }
        }

        private void LoadBaoCaoHoaDon()
        {
            dgvBaoCao.DataSource = bcBUS.BaoCaoHoaDon(dtFrom.Value, dtTo.Value);

            if (dgvBaoCao.Columns["colTongTien"] != null)
                dgvBaoCao.Columns["colTongTien"].DefaultCellStyle.Format = "#,##0";
        }

        private bool ValidateInput()
        {
            if (dtFrom.Value > dtTo.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFrom.Focus();
                return false;
            }

            if ((dtTo.Value - dtFrom.Value).TotalDays > 365)
            {
                MessageBox.Show("Khoảng thời gian thống kê tối đa là 1 năm!",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            LoadTongQuan();
            LoadChartDoanhThu();
            LoadChartTopMon();
            LoadBaoCaoHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;

            LoadTongQuan();
            LoadChartDoanhThu();
            LoadChartTopMon();
            LoadBaoCaoHoaDon();
        }

        #region Filter Buttons
        private void btnFilterNgay_Click(object sender, EventArgs e)
        {
            currentFilter = "Ngay";
            HighlightFilterButton(btnFilterNgay);
            LoadChartDoanhThu();
        }

        private void btnFilterThang_Click(object sender, EventArgs e)
        {
            currentFilter = "Thang";
            HighlightFilterButton(btnFilterThang);
            LoadChartDoanhThu();
        }

        private void btnFilterNam_Click(object sender, EventArgs e)
        {
            currentFilter = "Nam";
            HighlightFilterButton(btnFilterNam);
            LoadChartDoanhThu();
        }

        private void HighlightFilterButton(Button activeButton)
        {
            btnFilterNgay.BackColor = Color.LightGray;
            btnFilterThang.BackColor = Color.LightGray;
            btnFilterNam.BackColor = Color.LightGray;

            activeButton.BackColor = Color.SteelBlue;
            activeButton.ForeColor = Color.White;
        }
        #endregion


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu hóa đơn để xuất!", "Thông báo");
                return;
            }

            ExportToExcel(dgvBaoCao.DataSource as DataTable, "HoaDonBanHang");
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = bcBUS.BaoCaoPhieuNhap(dtFrom.Value, dtTo.Value);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phiếu nhập trong khoảng thời gian này!", "Thông báo");
                return;
            }

            ExportToExcel(dt, "PhieuNhapKho");
        }

        private void ExportToExcel(DataTable dt, string fileNamePrefix)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                FileName = $"{fileNamePrefix}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Header
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
                    }

                    // Data
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j]?.ToString() ?? "";
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất file Excel thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
