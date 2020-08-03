namespace Baicuoiki
{
    partial class danhsachphongban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachphongban));
            this.btin1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxlochitiet2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxchedocloc2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewdanhsachphongban = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTRUONGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachphongban)).BeginInit();
            this.SuspendLayout();
            // 
            // btin1
            // 
            this.btin1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btin1.ImageOptions.Image")));
            this.btin1.Location = new System.Drawing.Point(952, 98);
            this.btin1.Name = "btin1";
            this.btin1.Size = new System.Drawing.Size(111, 39);
            this.btin1.TabIndex = 11;
            this.btin1.Text = "In";
            this.btin1.Click += new System.EventHandler(this.btin1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxlochitiet2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxchedocloc2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // tbxlochitiet2
            // 
            this.tbxlochitiet2.Location = new System.Drawing.Point(513, 18);
            this.tbxlochitiet2.Name = "tbxlochitiet2";
            this.tbxlochitiet2.Size = new System.Drawing.Size(289, 22);
            this.tbxlochitiet2.TabIndex = 4;
            this.tbxlochitiet2.TextChanged += new System.EventHandler(this.tbxlochitiet2_TextChanged);
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
            // cbxchedocloc2
            // 
            this.cbxchedocloc2.FormattingEnabled = true;
            this.cbxchedocloc2.Location = new System.Drawing.Point(164, 18);
            this.cbxchedocloc2.Name = "cbxchedocloc2";
            this.cbxchedocloc2.Size = new System.Drawing.Size(199, 24);
            this.cbxchedocloc2.TabIndex = 0;
            this.cbxchedocloc2.SelectionChangeCommitted += new System.EventHandler(this.cbxchedocloc2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH PHÒNG BAN";
            // 
            // dataGridViewdanhsachphongban
            // 
            this.dataGridViewdanhsachphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdanhsachphongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MADA,
            this.TENDA,
            this.MATRP,
            this.TENTRUONGPHONG,
            this.PHONG,
            this.Column1,
            this.Column2});
            this.dataGridViewdanhsachphongban.Location = new System.Drawing.Point(-1, 175);
            this.dataGridViewdanhsachphongban.Name = "dataGridViewdanhsachphongban";
            this.dataGridViewdanhsachphongban.RowTemplate.Height = 24;
            this.dataGridViewdanhsachphongban.Size = new System.Drawing.Size(1348, 423);
            this.dataGridViewdanhsachphongban.TabIndex = 8;
            this.dataGridViewdanhsachphongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdanhsachphongban_CellContentClick);
            this.dataGridViewdanhsachphongban.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewdanhsachphongban_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MADA
            // 
            this.MADA.DataPropertyName = "MAPHG";
            this.MADA.HeaderText = "Mã phòng";
            this.MADA.Name = "MADA";
            // 
            // TENDA
            // 
            this.TENDA.DataPropertyName = "TENPHG";
            this.TENDA.HeaderText = "Tên phòng";
            this.TENDA.Name = "TENDA";
            // 
            // MATRP
            // 
            this.MATRP.DataPropertyName = "TRPHG";
            this.MATRP.HeaderText = "Mã trưởng phòng";
            this.MATRP.Name = "MATRP";
            // 
            // TENTRUONGPHONG
            // 
            this.TENTRUONGPHONG.DataPropertyName = "TENTRUONGPHONG";
            this.TENTRUONGPHONG.HeaderText = "Trưởng phòng";
            this.TENTRUONGPHONG.Name = "TENTRUONGPHONG";
            // 
            // PHONG
            // 
            this.PHONG.DataPropertyName = "NG_NHANCHUCTRP";
            this.PHONG.HeaderText = "Ngày nhận chức";
            this.PHONG.Name = "PHONG";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lưu";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Lưu";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xóa";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Xóa";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1142, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 39);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Thoát ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // danhsachphongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1346, 600);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btin1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewdanhsachphongban);
            this.Name = "danhsachphongban";
            this.Text = "danhsachphongban";
            this.Load += new System.EventHandler(this.danhsachphongban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdanhsachphongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btin1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxlochitiet2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxchedocloc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewdanhsachphongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTRUONGPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONG;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}