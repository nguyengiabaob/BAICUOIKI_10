namespace Baicuoiki
{
    partial class Formluongtheothanhtich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formluongtheothanhtich));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.nrudowmluongtheothanhtich = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.tbxchucvu = new System.Windows.Forms.TextBox();
            this.tbxmanhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listnhanvien = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxthanhtich = new System.Windows.Forms.TextBox();
            this.dgvtinhluongtheothanhtich = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lưu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dtngaytamung = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudowmluongtheothanhtich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhluongtheothanhtich)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(398, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số tiền theo thành tích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(398, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thành tích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.nrudowmluongtheothanhtich);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.tbxchucvu);
            this.groupBox1.Controls.Add(this.tbxmanhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listnhanvien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxthanhtich);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1328, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương theo thành tích";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(455, 218);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(137, 50);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Sửa thông tin";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // nrudowmluongtheothanhtich
            // 
            this.nrudowmluongtheothanhtich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrudowmluongtheothanhtich.Location = new System.Drawing.Point(598, 144);
            this.nrudowmluongtheothanhtich.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nrudowmluongtheothanhtich.Name = "nrudowmluongtheothanhtich";
            this.nrudowmluongtheothanhtich.Size = new System.Drawing.Size(200, 24);
            this.nrudowmluongtheothanhtich.TabIndex = 28;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(652, 218);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 50);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btthem
            // 
            this.btthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.Image")));
            this.btthem.Location = new System.Drawing.Point(258, 218);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(138, 50);
            this.btthem.TabIndex = 26;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // tbxchucvu
            // 
            this.tbxchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxchucvu.Location = new System.Drawing.Point(172, 144);
            this.tbxchucvu.Name = "tbxchucvu";
            this.tbxchucvu.ReadOnly = true;
            this.tbxchucvu.Size = new System.Drawing.Size(200, 24);
            this.tbxchucvu.TabIndex = 25;
            // 
            // tbxmanhanvien
            // 
            this.tbxmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxmanhanvien.Location = new System.Drawing.Point(172, 34);
            this.tbxmanhanvien.Name = "tbxmanhanvien";
            this.tbxmanhanvien.ReadOnly = true;
            this.tbxmanhanvien.Size = new System.Drawing.Size(200, 24);
            this.tbxmanhanvien.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chức vụ";
            // 
            // listnhanvien
            // 
            this.listnhanvien.FormattingEnabled = true;
            this.listnhanvien.ItemHeight = 20;
            this.listnhanvien.Location = new System.Drawing.Point(858, 41);
            this.listnhanvien.Name = "listnhanvien";
            this.listnhanvien.Size = new System.Drawing.Size(449, 204);
            this.listnhanvien.TabIndex = 20;
            this.listnhanvien.SelectedIndexChanged += new System.EventHandler(this.listnhanvien_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(855, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Danh sách nhân viên";
            // 
            // tbxthanhtich
            // 
            this.tbxthanhtich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxthanhtich.Location = new System.Drawing.Point(598, 34);
            this.tbxthanhtich.Name = "tbxthanhtich";
            this.tbxthanhtich.Size = new System.Drawing.Size(200, 24);
            this.tbxthanhtich.TabIndex = 8;
            // 
            // dgvtinhluongtheothanhtich
            // 
            this.dgvtinhluongtheothanhtich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtinhluongtheothanhtich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MANV,
            this.TenNV,
            this.THANHTICH,
            this.SoGio,
            this.lưu,
            this.xóa});
            this.dgvtinhluongtheothanhtich.Location = new System.Drawing.Point(39, 345);
            this.dgvtinhluongtheothanhtich.Name = "dgvtinhluongtheothanhtich";
            this.dgvtinhluongtheothanhtich.RowTemplate.Height = 24;
            this.dgvtinhluongtheothanhtich.Size = new System.Drawing.Size(1328, 212);
            this.dgvtinhluongtheothanhtich.TabIndex = 9;
            this.dgvtinhluongtheothanhtich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtinhluongtheothanhtich_CellContentClick);
            this.dgvtinhluongtheothanhtich.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvtinhluongtheothanhtich_DataBindingComplete);
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
            // THANHTICH
            // 
            this.THANHTICH.DataPropertyName = "THANHTICH";
            this.THANHTICH.HeaderText = "Thành tích";
            this.THANHTICH.Name = "THANHTICH";
            // 
            // SoGio
            // 
            this.SoGio.DataPropertyName = "LUONGTHEOTHANHTICH";
            this.SoGio.HeaderText = "Số tiền theo thành tích";
            this.SoGio.Name = "SoGio";
            // 
            // lưu
            // 
            this.lưu.HeaderText = "Lưu";
            this.lưu.Name = "lưu";
            this.lưu.Text = "Lưu";
            this.lưu.UseColumnTextForButtonValue = true;
            this.lưu.Visible = false;
            // 
            // xóa
            // 
            this.xóa.HeaderText = "Xóa";
            this.xóa.Name = "xóa";
            this.xóa.Text = "Xóa";
            this.xóa.UseColumnTextForButtonValue = true;
            this.xóa.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(36, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chi tiết tiền theo thành tích";
            // 
            // dtngaytamung
            // 
            this.dtngaytamung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaytamung.Location = new System.Drawing.Point(33, -2);
            this.dtngaytamung.Name = "dtngaytamung";
            this.dtngaytamung.Size = new System.Drawing.Size(200, 22);
            this.dtngaytamung.TabIndex = 12;
            // 
            // Formluongtheothanhtich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 604);
            this.Controls.Add(this.dtngaytamung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvtinhluongtheothanhtich);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formluongtheothanhtich";
            this.Text = "Thành tích";
            this.Load += new System.EventHandler(this.Formluongtheothanhtich_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudowmluongtheothanhtich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhluongtheothanhtich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxthanhtich;
        private System.Windows.Forms.ListBox listnhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxchucvu;
        private System.Windows.Forms.TextBox tbxmanhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvtinhluongtheothanhtich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtngaytamung;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private System.Windows.Forms.NumericUpDown nrudowmluongtheothanhtich;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGio;
        private System.Windows.Forms.DataGridViewButtonColumn lưu;
        private System.Windows.Forms.DataGridViewButtonColumn xóa;
    }
}