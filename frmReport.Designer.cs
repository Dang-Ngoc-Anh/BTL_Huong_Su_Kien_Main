
namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    partial class frmReport
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
            this.crystalReportViewerKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerKhachHang
            // 
            this.crystalReportViewerKhachHang.ActiveViewIndex = -1;
            this.crystalReportViewerKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerKhachHang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerKhachHang.Name = "crystalReportViewerKhachHang";
            this.crystalReportViewerKhachHang.Size = new System.Drawing.Size(967, 577);
            this.crystalReportViewerKhachHang.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 577);
            this.Controls.Add(this.crystalReportViewerKhachHang);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerKhachHang;
    }
}