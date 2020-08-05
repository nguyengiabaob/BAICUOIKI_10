namespace Baicuoiki
{
    partial class formdanhsachphancongdeancs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdanhsachphancongdeancs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxlochitiet1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxchedocloc1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewdanhsachduan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENLOINHUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lưu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachduan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxlochitiet1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxchedocloc1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // tbxlochitiet1
            // 
            this.tbxlochitiet1.Location = new System.Drawing.Point(513, 18);
            this.tbxlochitiet1.Name = "tbxlochitiet1";
            this.tbxlochitiet1.Size = new System.Drawing.Size(289, 22);
            this.tbxlochitiet1.TabIndex = 4;
            this.tbxlochitiet1.TextChanged += new System.EventHandler(this.tbxlochitiet1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lọc chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chế độ lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // cbxchedocloc1
            // 
            this.cbxchedocloc1.FormattingEnabled = true;
            this.cbxchedocloc1.Location = new System.Drawing.Point(164, 18);
            this.cbxchedocloc1.Name = "cbxchedocloc1";
            this.cbxchedocloc1.Size = new System.Drawing.Size(199, 24);
            this.cbxchedocloc1.TabIndex = 0;
            this.cbxchedocloc1.SelectedIndexChanged += new System.EventHandler(this.cbxchedocloc1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH SÁCH PHÂN CÔNG DỰ ÁN";
            // 
            // dataGridViewdanhsachduan
            // 
            this.dataGridViewdanhsachduan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdanhsachduan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MADA,
            this.TENDA,
            this.Column1,
            this.PHONG,
            this.TIENLOINHUAN,
            this.Column2,
            this.lưu,
            this.Xóa});
            this.dataGridViewdanhsachduan.Location = new System.Drawing.Point(20, 119);
            this.dataGridViewdanhsachduan.Name = "dataGridViewdanhsachduan";
            this.dataGridViewdanhsachduan.RowTemplate.Height = 24;
            this.dataGridViewdanhsachduan.Size = new System.Drawing.Size(1348, 423);
            this.dataGridViewdanhsachduan.TabIndex = 10;
            this.dataGridViewdanhsachduan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdanhsachduan_CellContentClick);
            this.dataGridViewdanhsachduan.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewdanhsachduan_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MADA
            // 
            this.MADA.DataPropertyName = "MADEAN";
            this.MADA.HeaderText = "Mã dự án";
            this.MADA.Name = "MADA";
            // 
            // TENDA
            // 
            this.TENDA.DataPropertyName = "TENDA";
            this.TENDA.HeaderText = "Tên Dự án";
            this.TENDA.Name = "TENDA";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DIADIEM";
            this.Column1.HeaderText = "Địa Điểm";
            this.Column1.Name = "Column1";
            // 
            // PHONG
            // 
            this.PHONG.DataPropertyName = "TENPHONG";
            this.PHONG.HeaderText = "Phòng Ban";
            this.PHONG.Name = "PHONG";
            // 
            // TIENLOINHUAN
            // 
            this.TIENLOINHUAN.DataPropertyName = "THOIGIANBATDAU";
            this.TIENLOINHUAN.HeaderText = "Thời gian bắt đầu";
            this.TIENLOINHUAN.Name = "TIENLOINHUAN";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "THOIGIANKETTHUC";
            this.Column2.HeaderText = "Thời gian kết thúc";
            this.Column2.Name = "Column2";
            // 
            // lưu
            // 
            this.lưu.HeaderText = "Lưu";
            this.lưu.Name = "lưu";
            this.lưu.Text = "Lưu";
            this.lưu.UseColumnTextForButtonValue = true;
            this.lưu.Visible = false;
            // 
            // Xóa
            // 
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1066, 56);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 54);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Sửa thông tin";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // formdanhsachphancongdeancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1390, 549);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewdanhsachduan);
            this.Name = "formdanhsachphancongdeancs";
            this.Text = "formdanhsachphancongdeancs";
            this.Load += new System.EventHandler(this.formdanhsachphancongdeancs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachduan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxlochitiet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxchedocloc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewdanhsachduan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENLOINHUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn lưu;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}