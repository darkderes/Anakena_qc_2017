namespace Anakena_2017
{
    partial class FormDireccion
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
            this.prueba_2017DataSet = new Anakena_2017.Prueba_2017DataSet();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTableAdapter = new Anakena_2017.Prueba_2017DataSetTableAdapters.DireccionTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2017DataSetTableAdapters.TableAdapterManager();
            this.direccionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // direccionDataGridView
            // 
            this.direccionDataGridView.AllowUserToAddRows = false;
            this.direccionDataGridView.AutoGenerateColumns = false;
            this.direccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.direccionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.direccionDataGridView.DataSource = this.direccionBindingSource;
            this.direccionDataGridView.Location = new System.Drawing.Point(67, 31);
            this.direccionDataGridView.Name = "direccionDataGridView";
            this.direccionDataGridView.Size = new System.Drawing.Size(445, 220);
            this.direccionDataGridView.TabIndex = 1;
            this.direccionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.direccionDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Direccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Direccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rut_Destinatario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rut_Destinatario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Comuna";
            this.dataGridViewTextBoxColumn4.HeaderText = "Comuna";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 290);
            this.Controls.Add(this.direccionDataGridView);
            this.Name = "FormDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDireccion";
            this.Load += new System.EventHandler(this.FormDireccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Prueba_2017DataSet prueba_2017DataSet;
        private System.Windows.Forms.BindingSource direccionBindingSource;
        private Prueba_2017DataSetTableAdapters.DireccionTableAdapter direccionTableAdapter;
        private Prueba_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView direccionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}