namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMon));
            label1 = new Label();
            txtSearch = new TextBox();
            btnTim = new Button();
            panel1 = new Panel();
            dgvMon = new DataGridView();
            colMaMon = new DataGridViewTextBoxColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            cboTrangThai = new ComboBox();
            txtDonGia = new TextBox();
            txtTenMon = new TextBox();
            txtMaMon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ MÓN";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Tên món";
            txtSearch.Size = new Size(179, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(199, 36);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 2;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvMon);
            panel1.Location = new Point(4, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 252);
            panel1.TabIndex = 3;
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { colMaMon, colTenMon, colDonGia, colTrangThai });
            dgvMon.Location = new Point(-1, -1);
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersVisible = false;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(924, 252);
            dgvMon.TabIndex = 0;
            dgvMon.CellClick += dgvMon_CellClick;
            // 
            // colMaMon
            // 
            colMaMon.DataPropertyName = "MaMon";
            colMaMon.HeaderText = "Mã món";
            colMaMon.MinimumWidth = 6;
            colMaMon.Name = "colMaMon";
            colMaMon.ReadOnly = true;
            // 
            // colTenMon
            // 
            colTenMon.DataPropertyName = "TenMon";
            colTenMon.HeaderText = "Tên món";
            colTenMon.MinimumWidth = 6;
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboTrangThai);
            panel2.Controls.Add(txtDonGia);
            panel2.Controls.Add(txtTenMon);
            panel2.Controls.Add(txtMaMon);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-2, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 99);
            panel2.TabIndex = 4;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Còn bán", "Hết món", "", "" });
            cboTrangThai.Location = new Point(487, 52);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 7;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(487, 7);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 6;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(126, 53);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(125, 27);
            txtTenMon.TabIndex = 5;
            // 
            // txtMaMon
            // 
            txtMaMon.Location = new Point(126, 7);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(125, 27);
            txtMaMon.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 60);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 3;
            label6.Text = "Trạng thái :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 14);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "Đơn giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 60);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên món :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 14);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã món :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 350);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 5;
            label2.Text = "THÔNG TIN MÓN";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(199, 505);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(330, 505);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(460, 505);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(592, 505);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnTim);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "frmMon";
            Text = "frmMon";
            Load += frmMon_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnTim;
        private Panel panel1;
        private DataGridView dgvMon;
        private Panel panel2;
        private ComboBox cboTrangThai;
        private TextBox txtDonGia;
        private TextBox txtTenMon;
        private TextBox txtMaMon;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridViewTextBoxColumn colMaMon;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}