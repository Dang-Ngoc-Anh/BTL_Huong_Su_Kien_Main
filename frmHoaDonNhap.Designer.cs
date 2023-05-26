
namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    partial class frmHoaDonNhap
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
            this.mtNgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.lbTenNCCErr = new System.Windows.Forms.Label();
            this.lbNgayLapErr = new System.Windows.Forms.Label();
            this.lbMaNhanVienErr = new System.Windows.Forms.Label();
            this.lbMaErr = new System.Windows.Forms.Label();
            this.dataGridViewHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.tbTenNhaCC = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLienHeErr = new System.Windows.Forms.Label();
            this.tbLienHe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSoLuongErr = new System.Windows.Forms.Label();
            this.lbGiaBanErr = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMahangErr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMahang = new System.Windows.Forms.TextBox();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // mtNgayNhap
            // 
            this.mtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNgayNhap.Location = new System.Drawing.Point(339, 159);
            this.mtNgayNhap.Mask = "00/00/0000";
            this.mtNgayNhap.Name = "mtNgayNhap";
            this.mtNgayNhap.Size = new System.Drawing.Size(228, 28);
            this.mtNgayNhap.TabIndex = 108;
            this.mtNgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // lbTenNCCErr
            // 
            this.lbTenNCCErr.AutoSize = true;
            this.lbTenNCCErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNCCErr.ForeColor = System.Drawing.Color.Red;
            this.lbTenNCCErr.Location = new System.Drawing.Point(367, 102);
            this.lbTenNCCErr.Name = "lbTenNCCErr";
            this.lbTenNCCErr.Size = new System.Drawing.Size(127, 17);
            this.lbTenNCCErr.TabIndex = 107;
            this.lbTenNCCErr.Text = "Mã không để trống";
            // 
            // lbNgayLapErr
            // 
            this.lbNgayLapErr.AutoSize = true;
            this.lbNgayLapErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLapErr.ForeColor = System.Drawing.Color.Red;
            this.lbNgayLapErr.Location = new System.Drawing.Point(364, 190);
            this.lbNgayLapErr.Name = "lbNgayLapErr";
            this.lbNgayLapErr.Size = new System.Drawing.Size(127, 17);
            this.lbNgayLapErr.TabIndex = 106;
            this.lbNgayLapErr.Text = "Mã không để trống";
            // 
            // lbMaNhanVienErr
            // 
            this.lbMaNhanVienErr.AutoSize = true;
            this.lbMaNhanVienErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVienErr.ForeColor = System.Drawing.Color.Red;
            this.lbMaNhanVienErr.Location = new System.Drawing.Point(71, 265);
            this.lbMaNhanVienErr.Name = "lbMaNhanVienErr";
            this.lbMaNhanVienErr.Size = new System.Drawing.Size(127, 17);
            this.lbMaNhanVienErr.TabIndex = 105;
            this.lbMaNhanVienErr.Text = "Mã không để trống";
            // 
            // lbMaErr
            // 
            this.lbMaErr.AutoSize = true;
            this.lbMaErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaErr.ForeColor = System.Drawing.Color.Red;
            this.lbMaErr.Location = new System.Drawing.Point(69, 102);
            this.lbMaErr.Name = "lbMaErr";
            this.lbMaErr.Size = new System.Drawing.Size(127, 17);
            this.lbMaErr.TabIndex = 104;
            this.lbMaErr.Text = "Mã không để trống";
            // 
            // dataGridViewHoaDonNhap
            // 
            this.dataGridViewHoaDonNhap.AllowUserToAddRows = false;
            this.dataGridViewHoaDonNhap.AllowUserToDeleteRows = false;
            this.dataGridViewHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
            this.dataGridViewHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewHoaDonNhap.Location = new System.Drawing.Point(0, 358);
            this.dataGridViewHoaDonNhap.Name = "dataGridViewHoaDonNhap";
            this.dataGridViewHoaDonNhap.ReadOnly = true;
            this.dataGridViewHoaDonNhap.RowHeadersWidth = 51;
            this.dataGridViewHoaDonNhap.RowTemplate.Height = 24;
            this.dataGridViewHoaDonNhap.Size = new System.Drawing.Size(985, 266);
            this.dataGridViewHoaDonNhap.TabIndex = 24;
            this.dataGridViewHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDonNhap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaHDnhap";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dNgaynhap";
            this.Column4.HeaderText = "Ngày lập hóa đơn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sMaNV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sMaNCC";
            this.Column3.HeaderText = "Tên nhà cung cấp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sLienHe";
            this.Column5.HeaderText = "Liên hệ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sMahang";
            this.Column6.HeaderText = "Mã Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "fGiaNhap";
            this.Column8.HeaderText = "Giá nhập";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "iSoluong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReport.Location = new System.Drawing.Point(586, 298);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(103, 45);
            this.btnReport.TabIndex = 102;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(730, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 45);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(439, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 45);
            this.btnDelete.TabIndex = 100;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(301, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 45);
            this.btnEdit.TabIndex = 99;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(160, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 45);
            this.btnAdd.TabIndex = 98;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetAll.Location = new System.Drawing.Point(21, 298);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(103, 45);
            this.btnGetAll.TabIndex = 97;
            this.btnGetAll.Text = "Get all";
            this.btnGetAll.UseVisualStyleBackColor = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // tbTenNhaCC
            // 
            this.tbTenNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhaCC.Location = new System.Drawing.Point(339, 71);
            this.tbTenNhaCC.Name = "tbTenNhaCC";
            this.tbTenNhaCC.Size = new System.Drawing.Size(228, 28);
            this.tbTenNhaCC.TabIndex = 96;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(63, 234);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(225, 28);
            this.tbMaNV.TabIndex = 95;
            // 
            // tbMaHD
            // 
            this.tbMaHD.BackColor = System.Drawing.Color.White;
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(61, 71);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(227, 28);
            this.tbMaHD.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(335, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(335, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(42, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 91;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Mã hóa đơn";
            // 
            // lbLienHeErr
            // 
            this.lbLienHeErr.AutoSize = true;
            this.lbLienHeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLienHeErr.ForeColor = System.Drawing.Color.Red;
            this.lbLienHeErr.Location = new System.Drawing.Point(364, 265);
            this.lbLienHeErr.Name = "lbLienHeErr";
            this.lbLienHeErr.Size = new System.Drawing.Size(127, 17);
            this.lbLienHeErr.TabIndex = 111;
            this.lbLienHeErr.Text = "Mã không để trống";
            // 
            // tbLienHe
            // 
            this.tbLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLienHe.Location = new System.Drawing.Point(339, 234);
            this.tbLienHe.Name = "tbLienHe";
            this.tbLienHe.Size = new System.Drawing.Size(228, 28);
            this.tbLienHe.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(335, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 109;
            this.label6.Text = "Liên hệ";
            // 
            // lbSoLuongErr
            // 
            this.lbSoLuongErr.AutoSize = true;
            this.lbSoLuongErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongErr.ForeColor = System.Drawing.Color.Red;
            this.lbSoLuongErr.Location = new System.Drawing.Point(617, 113);
            this.lbSoLuongErr.Name = "lbSoLuongErr";
            this.lbSoLuongErr.Size = new System.Drawing.Size(127, 17);
            this.lbSoLuongErr.TabIndex = 116;
            this.lbSoLuongErr.Text = "Mã không để trống";
            // 
            // lbGiaBanErr
            // 
            this.lbGiaBanErr.AutoSize = true;
            this.lbGiaBanErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaBanErr.ForeColor = System.Drawing.Color.Red;
            this.lbGiaBanErr.Location = new System.Drawing.Point(617, 191);
            this.lbGiaBanErr.Name = "lbGiaBanErr";
            this.lbGiaBanErr.Size = new System.Drawing.Size(127, 17);
            this.lbGiaBanErr.TabIndex = 115;
            this.lbGiaBanErr.Text = "Mã không để trống";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(599, 82);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(103, 28);
            this.tbSoLuong.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(595, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 113;
            this.label8.Text = "Sô lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(595, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 112;
            this.label9.Text = "Giá bán";
            // 
            // lbMahangErr
            // 
            this.lbMahangErr.AutoSize = true;
            this.lbMahangErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMahangErr.ForeColor = System.Drawing.Color.Red;
            this.lbMahangErr.Location = new System.Drawing.Point(72, 190);
            this.lbMahangErr.Name = "lbMahangErr";
            this.lbMahangErr.Size = new System.Drawing.Size(127, 17);
            this.lbMahangErr.TabIndex = 118;
            this.lbMahangErr.Text = "Mã không để trống";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(40, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 120;
            this.label11.Text = "Mã hàng";
            // 
            // tbMahang
            // 
            this.tbMahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMahang.Location = new System.Drawing.Point(61, 159);
            this.tbMahang.Name = "tbMahang";
            this.tbMahang.Size = new System.Drawing.Size(227, 28);
            this.tbMahang.TabIndex = 121;
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaBan.Location = new System.Drawing.Point(599, 160);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(103, 28);
            this.tbGiaBan.TabIndex = 122;
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 624);
            this.Controls.Add(this.dataGridViewHoaDonNhap);
            this.Controls.Add(this.tbGiaBan);
            this.Controls.Add(this.tbMahang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbMahangErr);
            this.Controls.Add(this.lbSoLuongErr);
            this.Controls.Add(this.lbGiaBanErr);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbLienHeErr);
            this.Controls.Add(this.tbLienHe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtNgayNhap);
            this.Controls.Add(this.lbTenNCCErr);
            this.Controls.Add(this.lbNgayLapErr);
            this.Controls.Add(this.lbMaNhanVienErr);
            this.Controls.Add(this.lbMaErr);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.tbTenNhaCC);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDonNhap";
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtNgayNhap;
        private System.Windows.Forms.Label lbTenNCCErr;
        private System.Windows.Forms.Label lbNgayLapErr;
        private System.Windows.Forms.Label lbMaNhanVienErr;
        private System.Windows.Forms.Label lbMaErr;
        private System.Windows.Forms.DataGridView dataGridViewHoaDonNhap;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.TextBox tbTenNhaCC;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLienHeErr;
        private System.Windows.Forms.TextBox tbLienHe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSoLuongErr;
        private System.Windows.Forms.Label lbGiaBanErr;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMahangErr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMahang;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}