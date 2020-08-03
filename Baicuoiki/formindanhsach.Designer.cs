namespace Baicuoiki
{
    partial class formindanhsach
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
            this.crystalReportViewerdanhsach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerdanhsach
            // 
            this.crystalReportViewerdanhsach.ActiveViewIndex = -1;
            this.crystalReportViewerdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerdanhsach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerdanhsach.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerdanhsach.Name = "crystalReportViewerdanhsach";
            this.crystalReportViewerdanhsach.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerdanhsach.TabIndex = 0;
            // 
            // formindanhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerdanhsach);
            this.Name = "formindanhsach";
            this.Text = "formindanhsach";
            this.Load += new System.EventHandler(this.formindanhsach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerdanhsach;
    }
}