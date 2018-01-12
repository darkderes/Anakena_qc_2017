namespace Anakena_2017
{
    partial class FormTransportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransportistas));
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtTransportista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.prueba_2017DataSet = new Anakena_2017.Prueba_2017DataSet();
            this.transportistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportistaTableAdapter = new Anakena_2017.Prueba_2017DataSetTableAdapters.TransportistaTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(83, 11);
            this.TxtRut.MaxLength = 10;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(164, 20);
            this.TxtRut.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Rut";
            // 
            // TxtTransportista
            // 
            this.TxtTransportista.Location = new System.Drawing.Point(83, 47);
            this.TxtTransportista.MaxLength = 100;
            this.TxtTransportista.Name = "TxtTransportista";
            this.TxtTransportista.Size = new System.Drawing.Size(207, 20);
            this.TxtTransportista.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Transportista";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(115, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prueba_2017DataSet
            // 
            this.prueba_2017DataSet.DataSetName = "Prueba_2017DataSet";
            this.prueba_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportistaBindingSource
            // 
            this.transportistaBindingSource.DataMember = "Transportista";
            this.transportistaBindingSource.DataSource = this.prueba_2017DataSet;
            // 
            // transportistaTableAdapter
            // 
            this.transportistaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransportistaTableAdapter = this.transportistaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTransportista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.label18);
            this.Name = "FormTransportistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransportistas";
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Prueba_2017DataSet prueba_2017DataSet;
        private System.Windows.Forms.BindingSource transportistaBindingSource;
        private Prueba_2017DataSetTableAdapters.TransportistaTableAdapter transportistaTableAdapter;
        private Prueba_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox TxtRut;
        public System.Windows.Forms.TextBox TxtTransportista;
    }
}