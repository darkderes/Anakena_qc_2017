namespace Anakena_2017
{
    partial class FormDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevoluciones));
            this.CmbEnvases = new System.Windows.Forms.ComboBox();
            this.envaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNAKENADataSet = new Anakena_2017.ANAKENADataSet();
            this.envaseTableAdapter = new Anakena_2017.ANAKENADataSetTableAdapters.EnvaseTableAdapter();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_NumGuia = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.prueba_2017DataSet = new Anakena_2017.Prueba_2017DataSet();
            this.spTraer_guia_productorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_guia_productorTableAdapter = new Anakena_2017.Prueba_2017DataSetTableAdapters.spTraer_guia_productorTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager();
            this.spTraer_guia_productorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Productor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Rut = new System.Windows.Forms.TextBox();
            this.prueba_2018DataSet = new Anakena_2017.Prueba_2018DataSet();
            this.devolucion_EnvasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucion_EnvasesTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.Devolucion_EnvasesTableAdapter();
            this.tableAdapterManager1 = new Anakena_2017.Prueba_2018DataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.envaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNAKENADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_guia_productorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_guia_productorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucion_EnvasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbEnvases
            // 
            this.CmbEnvases.DataSource = this.envaseBindingSource;
            this.CmbEnvases.DisplayMember = "Des_Envase";
            this.CmbEnvases.FormattingEnabled = true;
            this.CmbEnvases.Location = new System.Drawing.Point(105, 140);
            this.CmbEnvases.Name = "CmbEnvases";
            this.CmbEnvases.Size = new System.Drawing.Size(246, 21);
            this.CmbEnvases.TabIndex = 0;
            this.CmbEnvases.ValueMember = "Cod_Envase";
            // 
            // envaseBindingSource
            // 
            this.envaseBindingSource.DataMember = "Envase";
            this.envaseBindingSource.DataSource = this.aNAKENADataSet;
            // 
            // aNAKENADataSet
            // 
            this.aNAKENADataSet.DataSetName = "ANAKENADataSet";
            this.aNAKENADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // envaseTableAdapter
            // 
            this.envaseTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(105, 62);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(53, 20);
            this.Txt_Codigo.TabIndex = 1;
            this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Codigo_KeyPress);
            // 
            // Txt_NumGuia
            // 
            this.Txt_NumGuia.Location = new System.Drawing.Point(105, 114);
            this.Txt_NumGuia.Name = "Txt_NumGuia";
            this.Txt_NumGuia.Size = new System.Drawing.Size(100, 20);
            this.Txt_NumGuia.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Envase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Guia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(160, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 24;
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
            // spTraer_guia_productorBindingSource
            // 
            this.spTraer_guia_productorBindingSource.DataMember = "spTraer_guia_productor";
            this.spTraer_guia_productorBindingSource.DataSource = this.prueba_2017DataSet;
            // 
            // spTraer_guia_productorTableAdapter
            // 
            this.spTraer_guia_productorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DestinatarioTableAdapter = null;
            this.tableAdapterManager.Detalle_GuiaTableAdapter = null;
            this.tableAdapterManager.DireccionTableAdapter = null;
            this.tableAdapterManager.GuiaTableAdapter = null;
            this.tableAdapterManager.Transporte1TableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.TransportistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spTraer_guia_productorDataGridView
            // 
            this.spTraer_guia_productorDataGridView.AllowUserToAddRows = false;
            this.spTraer_guia_productorDataGridView.AutoGenerateColumns = false;
            this.spTraer_guia_productorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spTraer_guia_productorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.spTraer_guia_productorDataGridView.DataSource = this.spTraer_guia_productorBindingSource;
            this.spTraer_guia_productorDataGridView.Location = new System.Drawing.Point(32, 205);
            this.spTraer_guia_productorDataGridView.Name = "spTraer_guia_productorDataGridView";
            this.spTraer_guia_productorDataGridView.Size = new System.Drawing.Size(54, 24);
            this.spTraer_guia_productorDataGridView.TabIndex = 25;
            this.spTraer_guia_productorDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Productor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Productor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RUT";
            this.dataGridViewTextBoxColumn2.HeaderText = "RUT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Giro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Productor";
            // 
            // Lbl_Productor
            // 
            this.Lbl_Productor.AutoSize = true;
            this.Lbl_Productor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Productor.Location = new System.Drawing.Point(102, 90);
            this.Lbl_Productor.Name = "Lbl_Productor";
            this.Lbl_Productor.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Productor.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "RUT";
            // 
            // Txt_Rut
            // 
            this.Txt_Rut.Location = new System.Drawing.Point(211, 62);
            this.Txt_Rut.Name = "Txt_Rut";
            this.Txt_Rut.Size = new System.Drawing.Size(161, 20);
            this.Txt_Rut.TabIndex = 28;
            // 
            // prueba_2018DataSet
            // 
            this.prueba_2018DataSet.DataSetName = "Prueba_2018DataSet";
            this.prueba_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucion_EnvasesBindingSource
            // 
            this.devolucion_EnvasesBindingSource.DataMember = "Devolucion_Envases";
            this.devolucion_EnvasesBindingSource.DataSource = this.prueba_2018DataSet;
            // 
            // devolucion_EnvasesTableAdapter
            // 
            this.devolucion_EnvasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Devolucion_EnvasesTableAdapter = this.devolucion_EnvasesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Anakena_2017.Prueba_2018DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(378, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 22);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(105, 171);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(78, 20);
            this.TxtCantidad.TabIndex = 32;
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Rut);
            this.Controls.Add(this.Lbl_Productor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spTraer_guia_productorDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Txt_NumGuia);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.CmbEnvases);
            this.Name = "FormDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDevoluciones";
            this.Load += new System.EventHandler(this.FormDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.envaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNAKENADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_guia_productorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_guia_productorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucion_EnvasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbEnvases;
        private ANAKENADataSet aNAKENADataSet;
        private System.Windows.Forms.BindingSource envaseBindingSource;
        private ANAKENADataSetTableAdapters.EnvaseTableAdapter envaseTableAdapter;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_NumGuia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Prueba_2017DataSet prueba_2017DataSet;
        private System.Windows.Forms.BindingSource spTraer_guia_productorBindingSource;
        private Prueba_2017DataSetTableAdapters.spTraer_guia_productorTableAdapter spTraer_guia_productorTableAdapter;
        private Prueba_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spTraer_guia_productorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Productor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Rut;
        private Prueba_2018DataSet prueba_2018DataSet;
        private System.Windows.Forms.BindingSource devolucion_EnvasesBindingSource;
        private Prueba_2018DataSetTableAdapters.Devolucion_EnvasesTableAdapter devolucion_EnvasesTableAdapter;
        private Prueba_2018DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantidad;
    }
}