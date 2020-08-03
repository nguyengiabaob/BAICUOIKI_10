namespace Baicuoiki
{
    partial class danhsachdean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachdean));
            this.dataGridViewdanhsachdean = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENLOINHUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxlochitiet1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxchedocloc1 = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btin1 = new DevExpress.XtraEditors.SimpleButton();
            this.btin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachdean)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewdanhsachdean
            // 
            this.dataGridViewdanhsachdean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdanhsachdean.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MADA,
            this.TENDA,
            this.Column1,
            this.PHONG,
            this.TIENLOINHUAN,
            this.Column2,
            this.Column3});
            this.dataGridViewdanhsachdean.Location = new System.Drawing.Point(0, 119);
            this.dataGridViewdanhsachdean.Name = "dataGridViewdanhsachdean";
            this.dataGridViewdanhsachdean.RowTemplate.Height = 24;
            this.dataGridViewdanhsachdean.Size = new System.Drawing.Size(1348, 423);
            this.dataGridViewdanhsachdean.TabIndex = 1;
            this.dataGridViewdanhsachdean.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdanhsachdean_CellContentClick);
            this.dataGridViewdanhsachdean.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewdanhsachdean_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MADA
            // 
            this.MADA.DataPropertyName = "MADA";
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
            this.Column1.DataPropertyName = "DDIEM_DA";
            this.Column1.HeaderText = "Địa Điểm";
            this.Column1.Name = "Column1";
            // 
            // PHONG
            // 
            this.PHONG.DataPropertyName = "PHONG";
            this.PHONG.HeaderText = "Phòng Ban";
            this.PHONG.Name = "PHONG";
            // 
            // TIENLOINHUAN
            // 
            this.TIENLOINHUAN.DataPropertyName = "TIENLOINHUAN";
            this.TIENLOINHUAN.HeaderText = "Tiền lợi nhuận";
            this.TIENLOINHUAN.Name = "TIENLOINHUAN";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lưu";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Lưu";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Xóa";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Xóa";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH DỰ ÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxlochitiet1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxchedocloc1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 49);
            this.groupBox1.TabIndex = 3;
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
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(864, 70);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 39);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Thêm mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btin1
            // 
            this.btin1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btin1.ImageOptions.Image")));
            this.btin1.Location = new System.Drawing.Point(1011, 70);
            this.btin1.Name = "btin1";
            this.btin1.Size = new System.Drawing.Size(111, 39);
            this.btin1.TabIndex = 7;
            this.btin1.Text = "In";
            // 
            // btin
            // 
            this.btin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btin.ImageOptions.Image")));
            this.btin.Location = new System.Drawing.Point(1156, 71);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(111, 39);
            this.btin.TabIndex = 9;
            this.btin.Text = "Thoát";
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // danhsachdean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1348, 489);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btin1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewdanhsachdean);
            this.Name = "danhsachdean";
            this.Text = "danhsachdean";
            this.Load += new System.EventHandler(this.danhsachdean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachdean)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdanhsachdean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxlochitiet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxchedocloc1;
        private DevExpress.XtraEditors.SimpleButton btin1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENLOINHUAN;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private DevExpress.XtraEditors.SimpleButton btin;
    }
}