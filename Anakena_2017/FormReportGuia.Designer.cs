namespace Anakena_2017
{
    partial class FormReportGuia
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Prueba_2018DataSet = new Anakena_2017.Prueba_2018DataSet();
            this.spTraer_GuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(270, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Con Fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(390, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Solo Translado";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anakena_2017.ReportEmisionGuia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 504);
            this.reportViewer1.TabIndex = 3;
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
            // FormReportGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(864, 570);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormReportGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportGuia";
            this.Load += new System.EventHandler(this.FormReportGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prueba_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_GuiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private Prueba_2018DataSetTableAdapters.spTraer_GuiaTableAdapter spTraer_GuiaTableAdapter;
        private System.Windows.Forms.CheckBox checkBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Prueba_2018DataSet Prueba_2018DataSet;
        private System.Windows.Forms.BindingSource spTraer_GuiaBindingSource;
    }
}