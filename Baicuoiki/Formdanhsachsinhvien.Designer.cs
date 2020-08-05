namespace Baicuoiki
{
    partial class Formdanhsachsinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdanhsachsinhvien));
            this.dataGridViewdanhsachnhanvien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIHANHOPDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxlochitiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxchedocloc = new System.Windows.Forms.ComboBox();
            this.btin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewdanhsachnhanvien
            // 
            this.dataGridViewdanhsachnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdanhsachnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MANV,
            this.HOTENNV,
            this.DCHI,
            this.NGSINH,
            this.PHAI,
            this.TENPHONG,
            this.LUONG,
            this.CHUCVU,
            this.THOIHANHOPDONG});
            this.dataGridViewdanhsachnhanvien.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewdanhsachnhanvien.Name = "dataGridViewdanhsachnhanvien";
            this.dataGridViewdanhsachnhanvien.RowTemplate.Height = 24;
            this.dataGridViewdanhsachnhanvien.Size = new System.Drawing.Size(1348, 423);
            this.dataGridViewdanhsachnhanvien.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // HOTENNV
            // 
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Họ Tên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // DCHI
            // 
            this.DCHI.DataPropertyName = "DCHI";
            this.DCHI.HeaderText = "Địa chỉ";
            this.DCHI.Name = "DCHI";
            // 
            // NGSINH
            // 
            this.NGSINH.DataPropertyName = "NGSINH";
            this.NGSINH.HeaderText = "Ngày Sinh";
            this.NGSINH.Name = "NGSINH";
            // 
            // PHAI
            // 
            this.PHAI.DataPropertyName = "PHAI";
            this.PHAI.HeaderText = "Giới Tính";
            this.PHAI.Name = "PHAI";
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            this.TENPHONG.HeaderText = "Tên Phòng";
            this.TENPHONG.Name = "TENPHONG";
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.Name = "LUONG";
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // THOIHANHOPDONG
            // 
            this.THOIHANHOPDONG.DataPropertyName = "THOIHANHOPDONG";
            this.THOIHANHOPDONG.HeaderText = "Thời hạn hợp đồng";
            this.THOIHANHOPDONG.Name = "THOIHANHOPDONG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(530, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxlochitiet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxchedocloc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // tbxlochitiet
            // 
            this.tbxlochitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxlochitiet.Location = new System.Drawing.Point(498, 18);
            this.tbxlochitiet.Name = "tbxlochitiet";
            this.tbxlochitiet.Size = new System.Drawing.Size(289, 24);
            this.tbxlochitiet.TabIndex = 4;
            this.tbxlochitiet.TextChanged += new System.EventHandler(this.tbxlochitiet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lọc chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chế độ lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxchedocloc
            // 
            this.cbxchedocloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxchedocloc.FormattingEnabled = true;
            this.cbxchedocloc.Location = new System.Drawing.Point(164, 18);
            this.cbxchedocloc.Name = "cbxchedocloc";
            this.cbxchedocloc.Size = new System.Drawing.Size(199, 26);
            this.cbxchedocloc.TabIndex = 0;
            this.cbxchedocloc.SelectedIndexChanged += new System.EventHandler(this.cbxchedocloc_SelectedIndexChanged);
            // 
            // btin
            // 
            this.btin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btin.ImageOptions.Image")));
            this.btin.Location = new System.Drawing.Point(1007, 81);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(111, 39);
            this.btin.TabIndex = 6;
            this.btin.Text = "In";
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1207, 81);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 39);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // Formdanhsachsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1364, 563);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewdanhsachnhanvien);
            this.Name = "Formdanhsachsinhvien";
            this.Text = "Formdanhsachsinhvien";
            this.Load += new System.EventHandler(this.Formdanhsachsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdanhsachnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxchedocloc;
        private System.Windows.Forms.TextBox tbxlochitiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIHANHOPDONG;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}