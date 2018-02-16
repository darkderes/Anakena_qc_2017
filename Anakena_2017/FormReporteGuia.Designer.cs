namespace Anakena_2017
{
    partial class FormReporteGuia
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Prueba_2018DataSet = new Anakena_2017.Prueba_2018DataSet();
            this.spTraer_GuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_GuiaTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.spTraer_GuiaTableAdapter();
            this.Traer_DetalleGuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Traer_DetalleGuiaTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.Traer_DetalleGuiaTableAdapter();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_DetalleGuiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.spTraer_GuiaBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.Traer_DetalleGuiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.ReportEmisionGuia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(814, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // Prueba_2018DataSet
            // 
            this.Prueba_2018DataSet.DataSetName = "Prueba_2018DataSet";
            this.Prueba_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTraer_GuiaBindingSource
            // 
            this.spTraer_GuiaBindingSource.DataMember = "spTraer_Guia";
            this.spTraer_GuiaBindingSource.DataSource = this.Prueba_2018DataSet;
            // 
            // spTraer_GuiaTableAdapter
            // 
            this.spTraer_GuiaTableAdapter.ClearBeforeFill = true;
            // 
            // Traer_DetalleGuiaBindingSource
            // 
            this.Traer_DetalleGuiaBindingSource.DataMember = "Traer_DetalleGuia";
            this.Traer_DetalleGuiaBindingSource.DataSource = this.Prueba_2018DataSet;
            // 
            // Traer_DetalleGuiaTableAdapter
            // 
            this.Traer_DetalleGuiaTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(417, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Solo Translado";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(297, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Con Fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormReporteGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(839, 526);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteGuia";
            this.Text = "FormReporteGuia";
            this.Load += new System.EventHandler(this.FormReporteGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_DetalleGuiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spTraer_GuiaBindingSource;
        private Prueba_2018DataSet Prueba_2018DataSet;
        private System.Windows.Forms.BindingSource Traer_DetalleGuiaBindingSource;
        private Prueba_2018DataSetTableAdapters.spTraer_GuiaTableAdapter spTraer_GuiaTableAdapter;
        private Prueba_2018DataSetTableAdapters.Traer_DetalleGuiaTableAdapter Traer_DetalleGuiaTableAdapter;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}