namespace FPY.Reports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fPYDataSet = new FPY.Reports.FPYDataSet();
            this.fPYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPYDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPC";
            reportDataSource1.Value = this.fPYDataSetBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "FPY.Reports.rptPC.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1023, 551);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // fPYDataSet
            // 
            this.fPYDataSet.DataSetName = "FPYDataSet";
            this.fPYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fPYDataSetBindingSource
            // 
            this.fPYDataSetBindingSource.DataSource = this.fPYDataSet;
            this.fPYDataSetBindingSource.Position = 0;
            // 
            // fPYDataSetBindingSource1
            // 
            this.fPYDataSetBindingSource1.DataSource = this.fPYDataSet;
            this.fPYDataSetBindingSource1.Position = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 551);
            this.Controls.Add(this.reportViewer2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPYDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource fPYDataSetBindingSource;
        private FPYDataSet fPYDataSet;
        private System.Windows.Forms.BindingSource fPYDataSetBindingSource1;
    }
}