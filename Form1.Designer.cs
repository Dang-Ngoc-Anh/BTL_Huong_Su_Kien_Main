
namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet = new BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.QuanLyBanHangCongTyKinhDoangMayTinhDataSet();
            this.reportViewerNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet;
            // 
            // QuanLyBanHangCongTyKinhDoangMayTinhDataSet
            // 
            this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet.DataSetName = "QuanLyBanHangCongTyKinhDoangMayTinhDataSet";
            this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerNhanVien
            // 
            this.reportViewerNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhanVien";
            reportDataSource1.Value = this.tblNhanVienBindingSource;
            this.reportViewerNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerNhanVien.LocalReport.ReportEmbeddedResource = "BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.rdlcNhanVien.rdlc";
            this.reportViewerNhanVien.Location = new System.Drawing.Point(0, 0);
            this.reportViewerNhanVien.Name = "reportViewerNhanVien";
            this.reportViewerNhanVien.ServerReport.BearerToken = null;
            this.reportViewerNhanVien.Size = new System.Drawing.Size(800, 450);
            this.reportViewerNhanVien.TabIndex = 0;
            this.reportViewerNhanVien.Load += new System.EventHandler(this.reportViewerNhanVien_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerNhanVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanHangCongTyKinhDoangMayTinhDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNhanVien;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyBanHangCongTyKinhDoangMayTinhDataSet QuanLyBanHangCongTyKinhDoangMayTinhDataSet;
    }
}