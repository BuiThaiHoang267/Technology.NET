using System.Windows.Forms;

namespace BaiTap3___Net
{
    partial class ProductManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnXoaSP = new Button();
            btnLuuSP = new Button();
            InputTextNgayHetHan = new DateTimePicker();
            InputTextTenSP = new TextBox();
            InputTextXuatXu = new TextBox();
            InputTextDonGia = new TextBox();
            InputTextSoLuong = new TextBox();
            InputTextMaSP = new TextBox();
            InputNgayHetHan = new Label();
            InputTenSP = new Label();
            InputSoLuong = new Label();
            InputDonGia = new Label();
            InputXuatXu = new Label();
            InputMaSP = new Label();
            panel2 = new Panel();
            dataGVTimKiem = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGIa = new DataGridViewTextBoxColumn();
            XuatXu = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            InputTextMaxPrice = new TextBox();
            InputTextMinPrice = new TextBox();
            btnXCSPCDGAB = new Button();
            btnSPTNB = new Button();
            btnXTBSPQH = new Button();
            btnSPCDGCN = new Button();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGVGetAll = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel4 = new Panel();
            InputTextXXuatXu = new TextBox();
            btnXXTBSPQH = new Button();
            btnXTBSPTK = new Button();
            btnKTKCSPQHHK = new Button();
            btnXSPTXXBK = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVTimKiem).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVGetAll).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnXoaSP);
            panel1.Controls.Add(btnLuuSP);
            panel1.Controls.Add(InputTextNgayHetHan);
            panel1.Controls.Add(InputTextTenSP);
            panel1.Controls.Add(InputTextXuatXu);
            panel1.Controls.Add(InputTextDonGia);
            panel1.Controls.Add(InputTextSoLuong);
            panel1.Controls.Add(InputTextMaSP);
            panel1.Controls.Add(InputNgayHetHan);
            panel1.Controls.Add(InputTenSP);
            panel1.Controls.Add(InputSoLuong);
            panel1.Controls.Add(InputDonGia);
            panel1.Controls.Add(InputXuatXu);
            panel1.Controls.Add(InputMaSP);
            panel1.Location = new Point(10, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 288);
            panel1.TabIndex = 0;
            // 
            // btnXoaSP
            // 
            btnXoaSP.BackColor = Color.Yellow;
            btnXoaSP.Location = new Point(239, 237);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(90, 30);
            btnXoaSP.TabIndex = 13;
            btnXoaSP.Text = "Xóa SP";
            btnXoaSP.UseVisualStyleBackColor = false;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnLuuSP
            // 
            btnLuuSP.BackColor = Color.Yellow;
            btnLuuSP.Location = new Point(139, 237);
            btnLuuSP.Name = "btnLuuSP";
            btnLuuSP.Size = new Size(90, 30);
            btnLuuSP.TabIndex = 12;
            btnLuuSP.Text = "Lưu SP";
            btnLuuSP.UseVisualStyleBackColor = false;
            btnLuuSP.Click += btnLuuSP_Click;
            // 
            // InputTextNgayHetHan
            // 
            InputTextNgayHetHan.CustomFormat = "dd/MM/yyyy";
            InputTextNgayHetHan.Format = DateTimePickerFormat.Custom;
            InputTextNgayHetHan.Location = new Point(139, 193);
            InputTextNgayHetHan.Name = "InputTextNgayHetHan";
            InputTextNgayHetHan.Size = new Size(190, 27);
            InputTextNgayHetHan.TabIndex = 11;
            // 
            // InputTextTenSP
            // 
            InputTextTenSP.BorderStyle = BorderStyle.FixedSingle;
            InputTextTenSP.Location = new Point(139, 58);
            InputTextTenSP.Name = "InputTextTenSP";
            InputTextTenSP.Size = new Size(190, 27);
            InputTextTenSP.TabIndex = 10;
            // 
            // InputTextXuatXu
            // 
            InputTextXuatXu.BorderStyle = BorderStyle.FixedSingle;
            InputTextXuatXu.Location = new Point(139, 158);
            InputTextXuatXu.Name = "InputTextXuatXu";
            InputTextXuatXu.Size = new Size(190, 27);
            InputTextXuatXu.TabIndex = 9;
            // 
            // InputTextDonGia
            // 
            InputTextDonGia.BorderStyle = BorderStyle.FixedSingle;
            InputTextDonGia.Location = new Point(139, 125);
            InputTextDonGia.Name = "InputTextDonGia";
            InputTextDonGia.Size = new Size(190, 27);
            InputTextDonGia.TabIndex = 8;
            // 
            // InputTextSoLuong
            // 
            InputTextSoLuong.BorderStyle = BorderStyle.FixedSingle;
            InputTextSoLuong.Location = new Point(139, 92);
            InputTextSoLuong.Name = "InputTextSoLuong";
            InputTextSoLuong.Size = new Size(190, 27);
            InputTextSoLuong.TabIndex = 7;
            // 
            // InputTextMaSP
            // 
            InputTextMaSP.BorderStyle = BorderStyle.FixedSingle;
            InputTextMaSP.Location = new Point(139, 25);
            InputTextMaSP.Name = "InputTextMaSP";
            InputTextMaSP.Size = new Size(190, 27);
            InputTextMaSP.TabIndex = 6;
            // 
            // InputNgayHetHan
            // 
            InputNgayHetHan.AutoSize = true;
            InputNgayHetHan.BackColor = SystemColors.ActiveCaption;
            InputNgayHetHan.ForeColor = Color.Navy;
            InputNgayHetHan.Location = new Point(29, 193);
            InputNgayHetHan.Name = "InputNgayHetHan";
            InputNgayHetHan.Size = new Size(97, 20);
            InputNgayHetHan.TabIndex = 5;
            InputNgayHetHan.Text = "Ngày hết hạn";
            // 
            // InputTenSP
            // 
            InputTenSP.AutoSize = true;
            InputTenSP.BackColor = SystemColors.ActiveCaption;
            InputTenSP.ForeColor = Color.Navy;
            InputTenSP.Location = new Point(29, 58);
            InputTenSP.Name = "InputTenSP";
            InputTenSP.Size = new Size(55, 20);
            InputTenSP.TabIndex = 4;
            InputTenSP.Text = "Tên SP:";
            // 
            // InputSoLuong
            // 
            InputSoLuong.AutoSize = true;
            InputSoLuong.BackColor = SystemColors.ActiveCaption;
            InputSoLuong.ForeColor = Color.Navy;
            InputSoLuong.Location = new Point(29, 92);
            InputSoLuong.Name = "InputSoLuong";
            InputSoLuong.Size = new Size(72, 20);
            InputSoLuong.TabIndex = 3;
            InputSoLuong.Text = "Số lượng:";
            // 
            // InputDonGia
            // 
            InputDonGia.AutoSize = true;
            InputDonGia.BackColor = SystemColors.ActiveCaption;
            InputDonGia.ForeColor = Color.Navy;
            InputDonGia.Location = new Point(29, 125);
            InputDonGia.Name = "InputDonGia";
            InputDonGia.Size = new Size(63, 20);
            InputDonGia.TabIndex = 2;
            InputDonGia.Text = "Đơn Giá";
            // 
            // InputXuatXu
            // 
            InputXuatXu.AutoSize = true;
            InputXuatXu.BackColor = SystemColors.ActiveCaption;
            InputXuatXu.ForeColor = Color.Navy;
            InputXuatXu.Location = new Point(29, 158);
            InputXuatXu.Name = "InputXuatXu";
            InputXuatXu.Size = new Size(62, 20);
            InputXuatXu.TabIndex = 1;
            InputXuatXu.Text = "Xuất xứ:";
            // 
            // InputMaSP
            // 
            InputMaSP.AutoSize = true;
            InputMaSP.BackColor = SystemColors.ActiveCaption;
            InputMaSP.ForeColor = Color.Navy;
            InputMaSP.Location = new Point(29, 25);
            InputMaSP.Name = "InputMaSP";
            InputMaSP.Size = new Size(53, 20);
            InputMaSP.TabIndex = 0;
            InputMaSP.Text = "Mã SP:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGVTimKiem);
            panel2.Controls.Add(InputTextMaxPrice);
            panel2.Controls.Add(InputTextMinPrice);
            panel2.Controls.Add(btnXCSPCDGAB);
            panel2.Controls.Add(btnSPTNB);
            panel2.Controls.Add(btnXTBSPQH);
            panel2.Controls.Add(btnSPCDGCN);
            panel2.Location = new Point(390, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 288);
            panel2.TabIndex = 2;
            // 
            // dataGVTimKiem
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVTimKiem.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, SoLuong, DonGIa, XuatXu, NgayHetHan });
            dataGVTimKiem.Location = new Point(14, 92);
            dataGVTimKiem.Name = "dataGVTimKiem";
            dataGVTimKiem.RowHeadersWidth = 51;
            dataGVTimKiem.Size = new Size(760, 178);
            dataGVTimKiem.TabIndex = 20;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.ReadOnly = true;
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên SP";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.ReadOnly = true;
            TenSP.Width = 140;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 125;
            // 
            // DonGIa
            // 
            DonGIa.DataPropertyName = "DonGia";
            DonGIa.HeaderText = "Đơn giá";
            DonGIa.MinimumWidth = 6;
            DonGIa.Name = "DonGIa";
            DonGIa.ReadOnly = true;
            DonGIa.Width = 125;
            // 
            // XuatXu
            // 
            XuatXu.DataPropertyName = "XuatXu";
            XuatXu.HeaderText = "Xuất xứ";
            XuatXu.MinimumWidth = 6;
            XuatXu.Name = "XuatXu";
            XuatXu.ReadOnly = true;
            XuatXu.Width = 120;
            // 
            // NgayHetHan
            // 
            NgayHetHan.DataPropertyName = "NgayHetHan";
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.MinimumWidth = 6;
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.ReadOnly = true;
            NgayHetHan.Width = 150;
            // 
            // InputTextMaxPrice
            // 
            InputTextMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            InputTextMaxPrice.Location = new Point(650, 28);
            InputTextMaxPrice.Name = "InputTextMaxPrice";
            InputTextMaxPrice.Size = new Size(70, 27);
            InputTextMaxPrice.TabIndex = 18;
            InputTextMaxPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // InputTextMinPrice
            // 
            InputTextMinPrice.BorderStyle = BorderStyle.FixedSingle;
            InputTextMinPrice.Location = new Point(574, 28);
            InputTextMinPrice.Name = "InputTextMinPrice";
            InputTextMinPrice.Size = new Size(70, 27);
            InputTextMinPrice.TabIndex = 17;
            InputTextMinPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // btnXCSPCDGAB
            // 
            btnXCSPCDGAB.BackColor = Color.Yellow;
            btnXCSPCDGAB.Location = new Point(458, 15);
            btnXCSPCDGAB.Name = "btnXCSPCDGAB";
            btnXCSPCDGAB.Size = new Size(110, 50);
            btnXCSPCDGAB.TabIndex = 16;
            btnXCSPCDGAB.Text = "Xuất các SP có ĐG [a..b]";
            btnXCSPCDGAB.UseVisualStyleBackColor = false;
            btnXCSPCDGAB.Click += btnXCSPCDGAB_Click;
            // 
            // btnSPTNB
            // 
            btnSPTNB.BackColor = Color.Yellow;
            btnSPTNB.Location = new Point(119, 15);
            btnSPTNB.Name = "btnSPTNB";
            btnSPTNB.Size = new Size(100, 50);
            btnSPTNB.TabIndex = 15;
            btnSPTNB.Text = "SP từ nhật bản";
            btnSPTNB.UseVisualStyleBackColor = false;
            btnSPTNB.Click += btnSPTNB_Click;
            // 
            // btnXTBSPQH
            // 
            btnXTBSPQH.BackColor = Color.Yellow;
            btnXTBSPQH.Location = new Point(224, 15);
            btnXTBSPQH.Name = "btnXTBSPQH";
            btnXTBSPQH.Size = new Size(110, 50);
            btnXTBSPQH.TabIndex = 14;
            btnXTBSPQH.Text = "Xuất toàn bộ SP quá hạn";
            btnXTBSPQH.UseVisualStyleBackColor = false;
            btnXTBSPQH.Click += btnXTBSPQH_Click;
            // 
            // btnSPCDGCN
            // 
            btnSPCDGCN.BackColor = Color.Yellow;
            btnSPCDGCN.Location = new Point(14, 15);
            btnSPCDGCN.Name = "btnSPCDGCN";
            btnSPCDGCN.Size = new Size(100, 50);
            btnSPCDGCN.TabIndex = 13;
            btnSPCDGCN.Text = "1 SP có ĐG cao nhất";
            btnSPCDGCN.UseVisualStyleBackColor = false;
            btnSPCDGCN.Click += btnSPCDGCN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(680, 9);
            label8.Name = "label8";
            label8.Size = new Size(204, 22);
            label8.TabIndex = 3;
            label8.Text = "Tìm kiếm thông tin sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(95, 11);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 1;
            label1.Text = "Nhập thông tin sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(30, 328);
            label2.Name = "label2";
            label2.Size = new Size(233, 22);
            label2.TabIndex = 5;
            label2.Text = "Danh sách sản phảm sau khi nhập";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGVGetAll);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(10, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(1177, 345);
            panel3.TabIndex = 4;
            // 
            // dataGVGetAll
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVGetAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVGetAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVGetAll.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGVGetAll.Location = new Point(19, 11);
            dataGVGetAll.Name = "dataGVGetAll";
            dataGVGetAll.RowHeadersWidth = 51;
            dataGVGetAll.Size = new Size(829, 321);
            dataGVGetAll.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
            dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSP";
            dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "XuatXu";
            dataGridViewTextBoxColumn5.HeaderText = "Xuất xứ";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "NgayHetHan";
            dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(964, 11);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 6;
            label3.Text = "Chọn thao tác";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(InputTextXXuatXu);
            panel4.Controls.Add(btnXXTBSPQH);
            panel4.Controls.Add(btnXTBSPTK);
            panel4.Controls.Add(btnKTKCSPQHHK);
            panel4.Controls.Add(btnXSPTXXBK);
            panel4.Location = new Point(869, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 307);
            panel4.TabIndex = 3;
            // 
            // InputTextXXuatXu
            // 
            InputTextXXuatXu.BorderStyle = BorderStyle.FixedSingle;
            InputTextXXuatXu.Location = new Point(146, 48);
            InputTextXXuatXu.Name = "InputTextXXuatXu";
            InputTextXXuatXu.Size = new Size(120, 27);
            InputTextXXuatXu.TabIndex = 18;
            // 
            // btnXXTBSPQH
            // 
            btnXXTBSPQH.BackColor = Color.Yellow;
            btnXXTBSPQH.Location = new Point(146, 225);
            btnXXTBSPQH.Name = "btnXXTBSPQH";
            btnXXTBSPQH.Size = new Size(120, 50);
            btnXXTBSPQH.TabIndex = 17;
            btnXXTBSPQH.Text = "Xóa toàn bộ SP quá hạn";
            btnXXTBSPQH.UseVisualStyleBackColor = false;
            btnXXTBSPQH.Click += btnXXTBSPQH_Click;
            // 
            // btnXTBSPTK
            // 
            btnXTBSPTK.BackColor = Color.Yellow;
            btnXTBSPTK.Location = new Point(20, 225);
            btnXTBSPTK.Name = "btnXTBSPTK";
            btnXTBSPTK.Size = new Size(120, 50);
            btnXTBSPTK.TabIndex = 16;
            btnXTBSPTK.Text = "Xóa toàn bộ SP trong kho";
            btnXTBSPTK.UseVisualStyleBackColor = false;
            btnXTBSPTK.Click += btnXTBSPTK_Click;
            // 
            // btnKTKCSPQHHK
            // 
            btnKTKCSPQHHK.BackColor = Color.Yellow;
            btnKTKCSPQHHK.Location = new Point(20, 132);
            btnKTKCSPQHHK.Name = "btnKTKCSPQHHK";
            btnKTKCSPQHHK.Size = new Size(246, 50);
            btnKTKCSPQHHK.TabIndex = 15;
            btnKTKCSPQHHK.Text = "Kiểm tra kho có SP quá hạn hay không";
            btnKTKCSPQHHK.UseVisualStyleBackColor = false;
            // 
            // btnXSPTXXBK
            // 
            btnXSPTXXBK.BackColor = Color.Yellow;
            btnXSPTXXBK.Location = new Point(20, 35);
            btnXSPTXXBK.Name = "btnXSPTXXBK";
            btnXSPTXXBK.Size = new Size(120, 50);
            btnXSPTXXBK.TabIndex = 14;
            btnXSPTXXBK.Text = "Xóa SP theo xuất xứ bất kỳ";
            btnXSPTXXBK.UseVisualStyleBackColor = false;
            btnXSPTXXBK.Click += btnXSPTXXBK_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 698);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ProductManagement";
            Text = "LINQ to OBJECT - Quản lý sản phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVTimKiem).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVGetAll).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label InputTenSP;
        private Label InputSoLuong;
        private Label InputDonGia;
        private Label InputXuatXu;
        private Label InputMaSP;
        private TextBox InputTextTenSP;
        private TextBox InputTextXuatXu;
        private TextBox InputTextDonGia;
        private TextBox InputTextSoLuong;
        private TextBox InputTextMaSP;
        private Label InputNgayHetHan;
        private DateTimePicker InputTextNgayHetHan;
        private Button btnLuuSP;
        private Button btnXoaSP;
        private Panel panel2;
        private Label label8;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Button btnSPCDGCN;
        private Label label3;
        private Panel panel4;
        private Button btnXCSPCDGAB;
        private Button btnSPTNB;
        private Button btnXTBSPQH;
        private TextBox InputTextMaxPrice;
        private TextBox InputTextMinPrice;
        private DataGridView dataGVTimKiem;
        private DataGridView dataGVGetAll;
        private Button btnXTBSPTK;
        private Button btnKTKCSPQHHK;
        private Button btnXSPTXXBK;
        private TextBox InputTextXXuatXu;
        private Button btnXXTBSPQH;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGIa;
        private DataGridViewTextBoxColumn XuatXu;
        private DataGridViewTextBoxColumn NgayHetHan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}