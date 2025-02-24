
namespace WfaVendas
{
    partial class FrmRptBrinquedo
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
            this.LP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_brinquedosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_brinquedosTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_brinquedosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_brinquedosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pc_brinquedosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendas.RptBrinquedos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // LP2DataSet
            // 
            this.LP2DataSet.DataSetName = "LP2DataSet";
            this.LP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_brinquedosBindingSource
            // 
            this.pc_brinquedosBindingSource.DataMember = "pc_brinquedos";
            this.pc_brinquedosBindingSource.DataSource = this.LP2DataSet;
            // 
            // pc_brinquedosTableAdapter
            // 
            this.pc_brinquedosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptBrinquedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptBrinquedo";
            this.Text = "FrmRptBrinquedo";
            this.Load += new System.EventHandler(this.FrmRptBrinquedo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_brinquedosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pc_brinquedosBindingSource;
        private LP2DataSet LP2DataSet;
        private LP2DataSetTableAdapters.pc_brinquedosTableAdapter pc_brinquedosTableAdapter;
    }
}