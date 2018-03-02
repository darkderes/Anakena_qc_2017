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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteGuia));
            this.spTraer_GuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Prueba_2018DataSet = new Anakena_2017.Prueba_2018DataSet();
            this.Traer_DetalleGuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Traer_TransporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spTraer_GuiaTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.spTraer_GuiaTableAdapter();
            this.Traer_DetalleGuiaTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.Traer_DetalleGuiaTableAdapter();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Traer_TransporteTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.Traer_TransporteTableAdapter();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_DetalleGuiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_TransporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spTraer_GuiaBindingSource
            // 
            this.spTraer_GuiaBindingSource.DataMember = "spTraer_Guia";
            this.spTraer_GuiaBindingSource.DataSource = this.Prueba_2018DataSet;
            // 
            // Prueba_2018DataSet
            // 
            this.Prueba_2018DataSet.DataSetName = "Prueba_2018DataSet";
            this.Prueba_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Traer_DetalleGuiaBindingSource
            // 
            this.Traer_DetalleGuiaBindingSource.DataMember = "Traer_DetalleGuia";
            this.Traer_DetalleGuiaBindingSource.DataSource = this.Prueba_2018DataSet;
            // 
            // Traer_TransporteBindingSource
            // 
            this.Traer_TransporteBindingSource.DataMember = "Traer_Transporte";
            this.Traer_TransporteBindingSource.DataSource = this.Prueba_2018DataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spTraer_GuiaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Traer_DetalleGuiaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.Traer_TransporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.ReportEmisionGuia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(814, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // spTraer_GuiaTableAdapter
            // 
            this.spTraer_GuiaTableAdapter.ClearBeforeFill = true;
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
            this.checkBox2.Location = new System.Drawing.Point(374, 41);
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
            this.checkBox1.Location = new System.Drawing.Point(267, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Con Fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Traer_TransporteTableAdapter
            // 
            this.Traer_TransporteTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(488, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Precio sin I.V.A";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // FormReporteGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(839, 566);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteGuia";
            this.Load += new System.EventHandler(this.FormReporteGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_DetalleGuiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Traer_TransporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource Traer_TransporteBindingSource;
        private Prueba_2018DataSetTableAdapters.Traer_TransporteTableAdapter Traer_TransporteTableAdapter;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}