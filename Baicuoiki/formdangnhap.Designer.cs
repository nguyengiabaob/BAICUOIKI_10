namespace Baicuoiki
{
    partial class formdangnhap
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
            this.hyperlinkquenmatkhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkdangky = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btdangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.tbxmatkhau = new System.Windows.Forms.TextBox();
            this.tbxtendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hyperlinkquenmatkhau
            // 
            this.hyperlinkquenmatkhau.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkquenmatkhau.Appearance.Options.UseFont = true;
            this.hyperlinkquenmatkhau.Location = new System.Drawing.Point(1004, 388);
            this.hyperlinkquenmatkhau.Name = "hyperlinkquenmatkhau";
            this.hyperlinkquenmatkhau.Size = new System.Drawing.Size(109, 18);
            this.hyperlinkquenmatkhau.TabIndex = 13;
            this.hyperlinkquenmatkhau.Text = "Quên mật khẩu?";
            this.hyperlinkquenmatkhau.Click += new System.EventHandler(this.hyperlinkquenmatkhau_Click);
            // 
            // hyperlinkdangky
            // 
            this.hyperlinkdangky.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkdangky.Appearance.Options.UseFont = true;
            this.hyperlinkdangky.Location = new System.Drawing.Point(1022, 341);
            this.hyperlinkdangky.Name = "hyperlinkdangky";
            this.hyperlinkdangky.Size = new System.Drawing.Size(54, 18);
            this.hyperlinkdangky.TabIndex = 12;
            this.hyperlinkdangky.Text = "Đăng ký";
            this.hyperlinkdangky.Click += new System.EventHandler(this.hyperlinkdangky_Click_1);
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btdangnhap.Location = new System.Drawing.Point(996, 272);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(117, 29);
            this.btdangnhap.TabIndex = 11;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click_1);
            // 
            // tbxmatkhau
            // 
            this.tbxmatkhau.Location = new System.Drawing.Point(996, 190);
            this.tbxmatkhau.Name = "tbxmatkhau";
            this.tbxmatkhau.Size = new System.Drawing.Size(248, 22);
            this.tbxmatkhau.TabIndex = 10;
            this.tbxmatkhau.UseSystemPasswordChar = true;
            // 
            // tbxtendangnhap
            // 
            this.tbxtendangnhap.Location = new System.Drawing.Point(996, 110);
            this.tbxtendangnhap.Name = "tbxtendangnhap";
            this.tbxtendangnhap.Size = new System.Drawing.Size(248, 22);
            this.tbxtendangnhap.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(871, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(908, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thông tin đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Baicuoiki.Properties.Resources.Untitled10;
            this.pictureBox1.Location = new System.Drawing.Point(-20, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1306, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hyperlinkquenmatkhau);
            this.Controls.Add(this.hyperlinkdangky);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.tbxmatkhau);
            this.Controls.Add(this.tbxtendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "formdangnhap";
            this.Text = "formdangnhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formdangnhap_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formdangnhap_FormClosed);
            this.Load += new System.EventHandler(this.formdangnhap_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formdangnhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkquenmatkhau;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkdangky;
        private DevExpress.XtraEditors.SimpleButton btdangnhap;
        private System.Windows.Forms.TextBox tbxmatkhau;
        private System.Windows.Forms.TextBox tbxtendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}