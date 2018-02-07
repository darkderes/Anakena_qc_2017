namespace Anakena_2017
{
    partial class FormAdminDireccion
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
            System.Windows.Forms.Label rut_DestinatarioLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label comunaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDireccion));
            this.prueba_2017DataSet = new Anakena_2017.Prueba_2017DataSet();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTableAdapter = new Anakena_2017.Prueba_2017DataSetTableAdapters.DireccionTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager();
            this.rut_DestinatarioTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.comunaTextBox = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            rut_DestinatarioLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            comunaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rut_DestinatarioLabel
            // 
            rut_DestinatarioLabel.AutoSize = true;
            rut_DestinatarioLabel.Location = new System.Drawing.Point(12, 19);
            rut_DestinatarioLabel.Name = "rut_DestinatarioLabel";
            rut_DestinatarioLabel.Size = new System.Drawing.Size(30, 13);
            rut_DestinatarioLabel.TabIndex = 3;
            rut_DestinatarioLabel.Text = "Rut :";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 45);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // comunaLabel
            // 
            comunaLabel.AutoSize = true;
            comunaLabel.Location = new System.Drawing.Point(12, 71);
            comunaLabel.Name = "comunaLabel";
            comunaLabel.Size = new System.Drawing.Size(49, 13);
            comunaLabel.TabIndex = 7;
            comunaLabel.Text = "Comuna:";
            // 
            // prueba_2017DataSet
            // 
            this.prueba_2017DataSet.DataSetName = "Prueba_2017DataSet";
            this.prueba_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataMember = "Direccion";
            this.direccionBindingSource.DataSource = this.prueba_2017DataSet;
            // 
            // direccionTableAdapter
            // 
            this.direccionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DireccionTableAdapter = this.direccionTableAdapter;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.TransportistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rut_DestinatarioTextBox
            // 
            this.rut_DestinatarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Rut_Destinatario", true));
            this.rut_DestinatarioTextBox.Location = new System.Drawing.Point(67, 12);
            this.rut_DestinatarioTextBox.Name = "rut_DestinatarioTextBox";
            this.rut_DestinatarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.rut_DestinatarioTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(67, 38);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(237, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // comunaTextBox
            // 
            this.comunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Comuna", true));
            this.comunaTextBox.Location = new System.Drawing.Point(67, 64);
            this.comunaTextBox.Name = "comunaTextBox";
            this.comunaTextBox.Size = new System.Drawing.Size(237, 20);
            this.comunaTextBox.TabIndex = 8;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.BackgroundImage")));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Location = new System.Drawing.Point(133, 90);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(93, 26);
            this.Btn_Guardar.TabIndex = 24;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // FormAdminDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(336, 132);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(rut_DestinatarioLabel);
            this.Controls.Add(this.rut_DestinatarioTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(comunaLabel);
            this.Controls.Add(this.comunaTextBox);
            this.Name = "FormAdminDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminDireccion";
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prueba_2017DataSet prueba_2017DataSet;
        private System.Windows.Forms.BindingSource direccionBindingSource;
        private Prueba_2017DataSetTableAdapters.DireccionTableAdapter direccionTableAdapter;
        private Prueba_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Button Btn_Guardar;
        public System.Windows.Forms.TextBox rut_DestinatarioTextBox;
        public System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.TextBox comunaTextBox;
    }
}