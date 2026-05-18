namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuVuc));
            dgvKhuVuc = new DataGridView();
            colMaKV = new DataGridViewTextBoxColumn();
            colTenKV = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colMaQuanLy = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnTim = new Button();
            txtSearch = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            label2 = new Label();
            l4 = new Label();
            l3 = new Label();
            l1 = new Label();
            txtMaKV = new TextBox();
            txtTenKV = new TextBox();
            txtDiaChi = new TextBox();
            panel1 = new Panel();
            cboQuanLy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhuVuc
            // 
            dgvKhuVuc.AllowUserToAddRows = false;
            dgvKhuVuc.AllowUserToDeleteRows = false;
            dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuVuc.BackgroundColor = Color.White;
            dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhuVuc.Columns.AddRange(new DataGridViewColumn[] { colMaKV, colTenKV, colDiaChi, colMaQuanLy });
            dgvKhuVuc.Location = new Point(-1, -1);
            dgvKhuVuc.Name = "dgvKhuVuc";
            dgvKhuVuc.ReadOnly = true;
            dgvKhuVuc.RowHeadersVisible = false;
            dgvKhuVuc.RowHeadersWidth = 51;
            dgvKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuVuc.Size = new Size(925, 285);
            dgvKhuVuc.TabIndex = 0;
            dgvKhuVuc.CellClick += dgvKhuVuc_CellClick;
            // 
            // colMaKV
            // 
            colMaKV.DataPropertyName = "MaKV";
            colMaKV.HeaderText = "Mã KV";
            colMaKV.MinimumWidth = 6;
            colMaKV.Name = "colMaKV";
            colMaKV.ReadOnly = true;
            // 
            // colTenKV
            // 
            colTenKV.DataPropertyName = "TenKV";
            colTenKV.HeaderText = "Tên KV";
            colTenKV.MinimumWidth = 6;
            colTenKV.Name = "colTenKV";
            colTenKV.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colMaQuanLy
            // 
            colMaQuanLy.DataPropertyName = "MaQuanLy";
            colMaQuanLy.HeaderText = "Mã quản lý";
            colMaQuanLy.MinimumWidth = 6;
            colMaQuanLy.Name = "colMaQuanLy";
            colMaQuanLy.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 5);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 26;
            label1.Text = "QUẢN LÝ KHU VỰC";
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(259, 253);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 24;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(27, 254);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã KV, Tên KV, Địa chỉ";
            txtSearch.Size = new Size(225, 27);
            txtSearch.TabIndex = 23;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(590, 178);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(458, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(328, 178);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(197, 178);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvKhuVuc);
            panel2.Location = new Point(2, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 285);
            panel2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 21);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã KV :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(153, 59);
            l4.Name = "l4";
            l4.Size = new Size(61, 20);
            l4.TabIndex = 1;
            l4.Text = "Tên KV :";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(496, 59);
            l3.Name = "l3";
            l3.Size = new Size(66, 20);
            l3.TabIndex = 2;
            l3.Text = "Quản lý :";
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(500, 21);
            l1.Name = "l1";
            l1.Size = new Size(62, 20);
            l1.TabIndex = 3;
            l1.Text = "Địa chỉ :";
            // 
            // txtMaKV
            // 
            txtMaKV.Location = new Point(218, 14);
            txtMaKV.Name = "txtMaKV";
            txtMaKV.Size = new Size(125, 27);
            txtMaKV.TabIndex = 8;
            // 
            // txtTenKV
            // 
            txtTenKV.Location = new Point(218, 52);
            txtTenKV.Name = "txtTenKV";
            txtTenKV.Size = new Size(125, 27);
            txtTenKV.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(569, 14);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboQuanLy);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTenKV);
            panel1.Controls.Add(txtMaKV);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(l3);
            panel1.Controls.Add(l4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 111);
            panel1.TabIndex = 18;
            // 
            // cboQuanLy
            // 
            cboQuanLy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuanLy.FormattingEnabled = true;
            cboQuanLy.Location = new Point(569, 51);
            cboQuanLy.Name = "cboQuanLy";
            cboQuanLy.Size = new Size(151, 28);
            cboQuanLy.TabIndex = 12;
            // 
            // frmKhuVuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(txtSearch);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmKhuVuc";
            Text = "frmKhuVuc";
            Load += frmKhuVuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhuVuc;
        private Label label1;
        private Button btnTim;
        private TextBox txtSearch;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private DataGridViewTextBoxColumn colMaKV;
        private DataGridViewTextBoxColumn colTenKV;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colMaQuanLy;
        private Label label2;
        private Label l4;
        private Label l3;
        private Label l1;
        private TextBox txtMaKV;
        private TextBox txtTenKV;
        private TextBox txtDiaChi;
        private Panel panel1;
        private ComboBox cboQuanLy;
    }
}