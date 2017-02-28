namespace Anakena_2017
{
    partial class FormReport_Preseleccion
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
            this.Prueba_2017Preseleccion = new Anakena_2017.Prueba_2017Preseleccion();
            this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter = new Anakena_2017.Prueba_2017PreseleccionTableAdapters.spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017Preseleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.Reporte_Analisis_Calidad_Preseleccion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // Prueba_2017Preseleccion
            // 
            this.Prueba_2017Preseleccion.DataSetName = "Prueba_2017Preseleccion";
            this.Prueba_2017Preseleccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTraerReporte_Analisis_Calidad_PreseleccionBindingSource
            // 
            this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource.DataMember = "spTraerReporte_Analisis_Calidad_Preseleccion";
            this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource.DataSource = this.Prueba_2017Preseleccion;
            // 
            // spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter
            // 
            this.spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport_Preseleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport_Preseleccion";
            this.Text = "FormReport_Preseleccion";
            this.Load += new System.EventHandler(this.FormReport_Preseleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2017Preseleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraerReporte_Analisis_Calidad_PreseleccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spTraerReporte_Analisis_Calidad_PreseleccionBindingSource;
        private Prueba_2017Preseleccion Prueba_2017Preseleccion;
        private Prueba_2017PreseleccionTableAdapters.spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter;
    }
}