namespace Anakena_2017
{
    partial class FormReport_PPM
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Prueba_2017_PMM = new Anakena_2017.Prueba_2017_PMM();
            this.spTraerReporte_Analisis_Calidad_PMMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraerReporte_Analisis_Calidad_PMMTableAdapter = new Anakena_2017.Prueba_2017_PMMTableAdapters.spTraerReporte_Analisis_Calidad_PMMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017_PMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporte_Analisis_Calidad_PMMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spTraerReporte_Analisis_Calidad_PMMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.Reporte_Analisis_Calidad_PMM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // Prueba_2017_PMM
            // 
            this.Prueba_2017_PMM.DataSetName = "Prueba_2017_PMM";
            this.Prueba_2017_PMM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTraerReporte_Analisis_Calidad_PMMBindingSource
            // 
            this.spTraerReporte_Analisis_Calidad_PMMBindingSource.DataMember = "spTraerReporte_Analisis_Calidad_PMM";
            this.spTraerReporte_Analisis_Calidad_PMMBindingSource.DataSource = this.Prueba_2017_PMM;
            // 
            // spTraerReporte_Analisis_Calidad_PMMTableAdapter
            // 
            this.spTraerReporte_Analisis_Calidad_PMMTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport_PPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport_PPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport_PPM";
            this.Load += new System.EventHandler(this.FormReport_PPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017_PMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporte_Analisis_Calidad_PMMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spTraerReporte_Analisis_Calidad_PMMBindingSource;
        private Prueba_2017_PMM Prueba_2017_PMM;
        private Prueba_2017_PMMTableAdapters.spTraerReporte_Analisis_Calidad_PMMTableAdapter spTraerReporte_Analisis_Calidad_PMMTableAdapter;
    }
}