namespace Baicuoiki
{
    partial class formtiendodean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formtiendodean));
            this.dataGridViewtiendodean = new System.Windows.Forms.DataGridView();
            this.MADEAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTRUONGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lưu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxlochitiet2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxchedocloc2 = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtiendodean)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtiendodean
            // 
            this.dataGridViewtiendodean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtiendodean.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADEAN,
            this.TENDA,
            this.Column3,
            this.TENTRUONGPHONG,
            this.Column2,
            this.Column4,
            this.Column8,
            this.Lưu});
            this.dataGridViewtiendodean.Location = new System.Drawing.Point(3, 195);
            this.dataGridViewtiendodean.Name = "dataGridViewtiendodean";
            this.dataGridViewtiendodean.RowTemplate.Height = 24;
            this.dataGridViewtiendodean.Size = new System.Drawing.Size(1343, 403);
            this.dataGridViewtiendodean.TabIndex = 0;
            this.dataGridViewtiendodean.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtiendodean_CellContentClick);
            // 
            // MADEAN
            // 
            this.MADEAN.DataPropertyName = "MADUAN";
            this.MADEAN.Frozen = true;
            this.MADEAN.HeaderText = "Mã đề án";
            this.MADEAN.Name = "MADEAN";
            // 
            // TENDA
            // 
            this.TENDA.DataPropertyName = "TENDA";
            this.TENDA.Frozen = true;
            this.TENDA.HeaderText = "Tên đề án";
            this.TENDA.Name = "TENDA";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENPHONG";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Phòng thực hiện";
            this.Column3.Name = "Column3";
            // 
            // TENTRUONGPHONG
            // 
            this.TENTRUONGPHONG.DataPropertyName = "TENTRUONGPHONG";
            this.TENTRUONGPHONG.Frozen = true;
            this.TENTRUONGPHONG.HeaderText = "Trưởng phòng";
            this.TENTRUONGPHONG.Name = "TENTRUONGPHONG";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GIAIDOAN1";
            this.Column2.FalseValue = "0";
            this.Column2.HeaderText = "Giai đoạn bắt đầu ";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ToolTipText = "Đây là giai đoạn dự án cần hoàn thành các bước chuẩn bị để bước sang giai đoan th" +
    "ực hiện";
            this.Column2.TrueValue = "1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIAIDOAN2";
            this.Column4.FalseValue = "0";
            this.Column4.HeaderText = "Giai đoạn thực hiện";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.ToolTipText = "Giai đoạn thực hiện các yêu cầu của khách hàng đề hoàn thành sản phẩm ở mức sơ kh" +
    "ai";
            this.Column4.TrueValue = "1";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GIAIDOAN3";
            this.Column8.FalseValue = "0";
            this.Column8.HeaderText = "Giai đoạn kết thúc";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.ToolTipText = "Giai đoạn kiểm tra lại sản phẩm ở mức sơ khai còn thiếu sót những gì và bổ sung n" +
    "ó để tạo ra sản phẩm hoàn chỉnh";
            this.Column8.TrueValue = "1";
            // 
            // Lưu
            // 
            this.Lưu.HeaderText = "Lưu";
            this.Lưu.Name = "Lưu";
            this.Lưu.Text = "Lưu";
            this.Lưu.UseColumnTextForButtonValue = true;
            this.Lưu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(540, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIẾN ĐỘ DỰ ÁN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1126, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 50);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxlochitiet2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxchedocloc2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 49);
            this.groupBox1.TabIndex = 11;
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
            this.cbxchedocloc2.SelectedIndexChanged += new System.EventHandler(this.cbxchedocloc2_SelectedIndexChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(943, 128);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 50);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Sửa thông tin";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // formtiendodean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 597);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewtiendodean);
            this.Name = "formtiendodean";
            this.Text = "tiendodean";
            this.Load += new System.EventHandler(this.tiendodean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtiendodean)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtiendodean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxlochitiet2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxchedocloc2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTRUONGPHONG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Lưu;
    }
}