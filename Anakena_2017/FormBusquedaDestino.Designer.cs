namespace Anakena_2017
{
    partial class FormBusquedaDestino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaDestino));
            this.prueba_2018DataSet = new Anakena_2017.Prueba_2018DataSet();
            this.spFiltroDestinatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spFiltroDestinatarioTableAdapter = new Anakena_2017.Prueba_2018DataSetTableAdapters.spFiltroDestinatarioTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2018DataSetTableAdapters.TableAdapterManager();
            this.spFiltroDestinatarioDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFiltroDestinatarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFiltroDestinatarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prueba_2018DataSet
            // 
            this.prueba_2018DataSet.DataSetName = "Prueba_2018DataSet";
            this.prueba_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spFiltroDestinatarioBindingSource
            // 
            this.spFiltroDestinatarioBindingSource.DataMember = "spFiltroDestinatario";
            this.spFiltroDestinatarioBindingSource.DataSource = this.prueba_2018DataSet;
            // 
            // spFiltroDestinatarioTableAdapter
            // 
            this.spFiltroDestinatarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Anakena_2017.Prueba_2018DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spFiltroDestinatarioDataGridView
            // 
            this.spFiltroDestinatarioDataGridView.AllowUserToAddRows = false;
            this.spFiltroDestinatarioDataGridView.AutoGenerateColumns = false;
            this.spFiltroDestinatarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spFiltroDestinatarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.spFiltroDestinatarioDataGridView.DataSource = this.spFiltroDestinatarioBindingSource;
            this.spFiltroDestinatarioDataGridView.Location = new System.Drawing.Point(12, 112);
            this.spFiltroDestinatarioDataGridView.Name = "spFiltroDestinatarioDataGridView";
            this.spFiltroDestinatarioDataGridView.RowHeadersVisible = false;
            this.spFiltroDestinatarioDataGridView.Size = new System.Drawing.Size(403, 327);
            this.spFiltroDestinatarioDataGridView.TabIndex = 2;
            this.spFiltroDestinatarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spFiltroDestinatarioDataGridView_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Presione enter para filtrar)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(127, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rut_Destinatario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rut";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // FormBusquedaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(432, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spFiltroDestinatarioDataGridView);
            this.Name = "FormBusquedaDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusquedaDestino";
            this.Load += new System.EventHandler(this.FormBusquedaDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFiltroDestinatarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFiltroDestinatarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prueba_2018DataSet prueba_2018DataSet;
        private System.Windows.Forms.BindingSource spFiltroDestinatarioBindingSource;
        private Prueba_2018DataSetTableAdapters.spFiltroDestinatarioTableAdapter spFiltroDestinatarioTableAdapter;
        private Prueba_2018DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spFiltroDestinatarioDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}