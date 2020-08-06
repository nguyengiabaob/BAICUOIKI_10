namespace Baicuoiki
{
    partial class Formtamungtien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtamungtien));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvtinhluongtamung = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lưu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listnhanvien = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmanhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.nrudowmluongtamung = new System.Windows.Forms.NumericUpDown();
            this.dtngaytamung = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhluongtamung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudowmluongtamung)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(19, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi tiết tạm ứng tiền";
            // 
            // dgvtinhluongtamung
            // 
            this.dgvtinhluongtamung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtinhluongtamung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MANV,
            this.TenNV,
            this.Ngay,
            this.SoGio,
            this.Lưu,
            this.Xóa});
            this.dgvtinhluongtamung.Location = new System.Drawing.Point(22, 374);
            this.dgvtinhluongtamung.Name = "dgvtinhluongtamung";
            this.dgvtinhluongtamung.RowTemplate.Height = 24;
            this.dgvtinhluongtamung.Size = new System.Drawing.Size(1331, 212);
            this.dgvtinhluongtamung.TabIndex = 4;
            this.dgvtinhluongtamung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtinhluongtamung_CellContentClick);
            this.dgvtinhluongtamung.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvtinhluongtamung_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HOTENNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NGAYUNG";
            this.Ngay.HeaderText = "Ngày tạm ứng";
            this.Ngay.Name = "Ngay";
            // 
            // SoGio
            // 
            this.SoGio.DataPropertyName = "LUONGTUNG";
            this.SoGio.HeaderText = "Số tiền";
            this.SoGio.Name = "SoGio";
            // 
            // Lưu
            // 
            this.Lưu.HeaderText = "Lưu";
            this.Lưu.Name = "Lưu";
            this.Lưu.Text = "Lưu";
            this.Lưu.UseColumnTextForButtonValue = true;
            this.Lưu.Visible = false;
            // 
            // Xóa
            // 
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.listnhanvien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxmanhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.nrudowmluongtamung);
            this.groupBox1.Controls.Add(this.dtngaytamung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1331, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tạm ứng tiền";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(234, 244);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(153, 50);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Sửa thông tin";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(406, 244);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 50);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // listnhanvien
            // 
            this.listnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listnhanvien.FormattingEnabled = true;
            this.listnhanvien.ItemHeight = 18;
            this.listnhanvien.Location = new System.Drawing.Point(552, 63);
            this.listnhanvien.Name = "listnhanvien";
            this.listnhanvien.Size = new System.Drawing.Size(580, 220);
            this.listnhanvien.TabIndex = 3;
            this.listnhanvien.SelectedIndexChanged += new System.EventHandler(this.listnhanvien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(67, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã nhân viên";
            // 
            // tbxmanhanvien
            // 
            this.tbxmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxmanhanvien.Location = new System.Drawing.Point(196, 102);
            this.tbxmanhanvien.Name = "tbxmanhanvien";
            this.tbxmanhanvien.ReadOnly = true;
            this.tbxmanhanvien.Size = new System.Drawing.Size(200, 24);
            this.tbxmanhanvien.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(549, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh sách nhân viên";
            // 
            // btthem
            // 
            this.btthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.Image")));
            this.btthem.Location = new System.Drawing.Point(70, 244);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(132, 50);
            this.btthem.TabIndex = 4;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // nrudowmluongtamung
            // 
            this.nrudowmluongtamung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrudowmluongtamung.Location = new System.Drawing.Point(196, 167);
            this.nrudowmluongtamung.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nrudowmluongtamung.Name = "nrudowmluongtamung";
            this.nrudowmluongtamung.Size = new System.Drawing.Size(200, 24);
            this.nrudowmluongtamung.TabIndex = 3;
            // 
            // dtngaytamung
            // 
            this.dtngaytamung.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaytamung.Enabled = false;
            this.dtngaytamung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaytamung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaytamung.Location = new System.Drawing.Point(196, 43);
            this.dtngaytamung.Name = "dtngaytamung";
            this.dtngaytamung.Size = new System.Drawing.Size(200, 24);
            this.dtngaytamung.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền tạm ứng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày tạm ứng";
            // 
            // Formtamungtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvtinhluongtamung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formtamungtien";
            this.Text = "Formtamungtien";
            this.Load += new System.EventHandler(this.Formtamungtien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhluongtamung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudowmluongtamung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvtinhluongtamung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listnhanvien;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private System.Windows.Forms.NumericUpDown nrudowmluongtamung;
        private System.Windows.Forms.DateTimePicker dtngaytamung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmanhanvien;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGio;
        private System.Windows.Forms.DataGridViewButtonColumn Lưu;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}