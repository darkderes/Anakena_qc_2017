namespace Anakena_2017
{
    partial class FormReporte_Analisis_Productor
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
            this.Prueba_2017DataSet = new Anakena_2017.Prueba_2017DataSet();
            this.spTraerReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraerReporteTableAdapter = new Anakena_2017.Prueba_2017DataSetTableAdapters.spTraerReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spTraerReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.Reporte_Analisis_Productor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(869, 601);
            this.reportViewer1.TabIndex = 0;
            // 
            // Prueba_2017DataSet
            // 
            this.Prueba_2017DataSet.DataSetName = "Prueba_2017DataSet";
            this.Prueba_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTraerReporteBindingSource
            // 
            this.spTraerReporteBindingSource.DataMember = "spTraerReporte";
            this.spTraerReporteBindingSource.DataSource = this.Prueba_2017DataSet;
            // 
            // spTraerReporteTableAdapter
            // 
            this.spTraerReporteTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporte_Analisis_Productor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 601);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte_Analisis_Productor";
            this.Text = "FormReporte_Analisis_Productor";
            this.Load += new System.EventHandler(this.FormReporte_Analisis_Productor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spTraerReporteBindingSource;
        private Prueba_2017DataSet Prueba_2017DataSet;
        private Prueba_2017DataSetTableAdapters.spTraerReporteTableAdapter spTraerReporteTableAdapter;
    }
}