namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguyenLieu));
            dgvNguyenLieu = new DataGridView();
            colMaNL = new DataGridViewTextBoxColumn();
            colTenNL = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnSua = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            txtGia = new TextBox();
            txtTenNL = new TextBox();
            txtMaNL = new TextBox();
            l1 = new Label();
            l4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTim = new Button();
            txtSearch = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNguyenLieu
            // 
            dgvNguyenLieu.AllowUserToAddRows = false;
            dgvNguyenLieu.AllowUserToDeleteRows = false;
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguyenLieu.BackgroundColor = Color.White;
            dgvNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguyenLieu.Columns.AddRange(new DataGridViewColumn[] { colMaNL, colTenNL, colGia });
            dgvNguyenLieu.Location = new Point(-1, -1);
            dgvNguyenLieu.Name = "dgvNguyenLieu";
            dgvNguyenLieu.ReadOnly = true;
            dgvNguyenLieu.RowHeadersVisible = false;
            dgvNguyenLieu.RowHeadersWidth = 51;
            dgvNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNguyenLieu.Size = new Size(925, 283);
            dgvNguyenLieu.TabIndex = 0;
            dgvNguyenLieu.CellClick += dgvNguyenLieu_CellClick;
            // 
            // colMaNL
            // 
            colMaNL.DataPropertyName = "MaNL";
            colMaNL.HeaderText = "Mã NL";
            colMaNL.MinimumWidth = 6;
            colMaNL.Name = "colMaNL";
            colMaNL.ReadOnly = true;
            // 
            // colTenNL
            // 
            colTenNL.DataPropertyName = "TenNL";
            colTenNL.HeaderText = "Tên NL";
            colTenNL.MinimumWidth = 6;
            colTenNL.Name = "colTenNL";
            colTenNL.ReadOnly = true;
            // 
            // colGia
            // 
            colGia.DataPropertyName = "Gia";
            colGia.HeaderText = "Đơn giá (VNĐ)";
            colGia.MinimumWidth = 6;
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvNguyenLieu);
            panel2.Location = new Point(2, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 283);
            panel2.TabIndex = 43;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(335, 199);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(204, 199);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 37;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(txtTenNL);
            panel1.Controls.Add(txtMaNL);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(l4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 145);
            panel1.TabIndex = 36;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(388, 104);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(125, 27);
            txtGia.TabIndex = 10;
            // 
            // txtTenNL
            // 
            txtTenNL.Location = new Point(388, 56);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.Size = new Size(125, 27);
            txtTenNL.TabIndex = 9;
            // 
            // txtMaNL
            // 
            txtMaNL.Location = new Point(388, 9);
            txtMaNL.Name = "txtMaNL";
            txtMaNL.Size = new Size(125, 27);
            txtMaNL.TabIndex = 8;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(261, 111);
            l1.Name = "l1";
            l1.Size = new Size(114, 20);
            l1.TabIndex = 3;
            l1.Text = "Đơn giá (VNĐ) :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(314, 63);
            l4.Name = "l4";
            l4.Size = new Size(61, 20);
            l4.TabIndex = 1;
            l4.Text = "Tên NL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 16);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã NL :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 8);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 44;
            label1.Text = "QUẢN LÝ NGUYÊN LIỆU\r\n\r\n";
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(192, 253);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 42;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(9, 254);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã NL, Tên NL";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 41;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(597, 199);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 40;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(465, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(panel2);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(txtSearch);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Name = "frmNguyenLieu";
            Text = "frmNguyenLieu";
            Load += frmNguyenLieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvNguyenLieu;
        private Panel panel2;
        private Button btnSua;
        private Button btnThem;
        private Panel panel1;
        private TextBox txtGia;
        private TextBox txtTenNL;
        private TextBox txtMaNL;
        private Label l1;
        private Label l4;
        private Label label2;
        private Label label1;
        private Button btnTim;
        private TextBox txtSearch;
        private Button btnLamMoi;
        private Button btnXoa;
        private DataGridViewTextBoxColumn colMaNL;
        private DataGridViewTextBoxColumn colTenNL;
        private DataGridViewTextBoxColumn colGia;
    }
}