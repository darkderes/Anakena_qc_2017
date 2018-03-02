namespace Anakena_2017
{
    partial class FormAdministracionGuia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracionGuia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spTraer_Administracion_GuiaDataGridView = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spTraer_Administracion_GuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.spTraer_Administracion_Guia_PorGuiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spTraer_Administracion_Guia_PorGuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_Administracion_Guia_PorRutDataGridView = new System.Windows.Forms.DataGridView();
            this.spTraer_Administracion_Guia_PorRutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.spTraer_Administracion_Guia_PorEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_Administracion_Guia_PorEstadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_Administracion_Guia_PorEstadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_Administracion_Guia_PorEstadoDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_GuiaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_GuiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorGuiaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorGuiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorRutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorRutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // spTraer_Administracion_GuiaDataGridView
            // 
            this.spTraer_Administracion_GuiaDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spTraer_Administracion_GuiaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.spTraer_Administracion_GuiaDataGridView.AutoGenerateColumns = false;
            this.spTraer_Administracion_GuiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spTraer_Administracion_GuiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            this.spTraer_Administracion_GuiaDataGridView.DataSource = this.spTraer_Administracion_GuiaBindingSource;
            this.spTraer_Administracion_GuiaDataGridView.Location = new System.Drawing.Point(12, 79);
            this.spTraer_Administracion_GuiaDataGridView.Name = "spTraer_Administracion_GuiaDataGridView";
            this.spTraer_Administracion_GuiaDataGridView.RowHeadersVisible = false;
            this.spTraer_Administracion_GuiaDataGridView.Size = new System.Drawing.Size(1205, 479);
            this.spTraer_Administracion_GuiaDataGridView.TabIndex = 1;
            this.spTraer_Administracion_GuiaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spTraer_Administracion_GuiaDataGridView_CellClick);
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // spTraer_Administracion_GuiaBindingSource
            // 
            this.spTraer_Administracion_GuiaBindingSource.DataMember = "spTraer_Administracion_Guia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.Btn_Delete);
            this.groupBox10.Location = new System.Drawing.Point(1223, 80);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(84, 93);
            this.groupBox10.TabIndex = 123;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Opciones";
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(6, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 26);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.BackgroundImage")));
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.Location = new System.Drawing.Point(6, 51);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(74, 26);
            this.Btn_Delete.TabIndex = 26;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1233, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 27);
            this.button3.TabIndex = 124;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "-- Seleccione Opcion --",
            "Todos",
            "Destinatario",
            "Guia",
            "Estado"});
            this.CmbFiltro.Location = new System.Drawing.Point(453, 30);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(180, 21);
            this.CmbFiltro.TabIndex = 125;
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(649, 30);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(159, 20);
            this.TxtFiltro.TabIndex = 126;
            this.TxtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltro_KeyPress);
            // 
            // spTraer_Administracion_Guia_PorGuiaDataGridView
            // 
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.AutoGenerateColumns = false;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn28});
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.DataSource = this.spTraer_Administracion_Guia_PorGuiaBindingSource;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.Location = new System.Drawing.Point(12, 153);
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.Name = "spTraer_Administracion_Guia_PorGuiaDataGridView";
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.RowHeadersVisible = false;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.Size = new System.Drawing.Size(1205, 405);
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.TabIndex = 127;
            this.spTraer_Administracion_Guia_PorGuiaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spTraer_Administracion_Guia_PorGuiaDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn28.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // spTraer_Administracion_Guia_PorGuiaBindingSource
            // 
            this.spTraer_Administracion_Guia_PorGuiaBindingSource.DataMember = "spTraer_Administracion_Guia_PorGuia";
            // 
            // spTraer_Administracion_Guia_PorRutDataGridView
            // 
            this.spTraer_Administracion_Guia_PorRutDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spTraer_Administracion_Guia_PorRutDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.spTraer_Administracion_Guia_PorRutDataGridView.AutoGenerateColumns = false;
            this.spTraer_Administracion_Guia_PorRutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spTraer_Administracion_Guia_PorRutDataGridView.DataSource = this.spTraer_Administracion_Guia_PorRutBindingSource;
            this.spTraer_Administracion_Guia_PorRutDataGridView.Location = new System.Drawing.Point(12, 80);
            this.spTraer_Administracion_Guia_PorRutDataGridView.Name = "spTraer_Administracion_Guia_PorRutDataGridView";
            this.spTraer_Administracion_Guia_PorRutDataGridView.RowHeadersVisible = false;
            this.spTraer_Administracion_Guia_PorRutDataGridView.Size = new System.Drawing.Size(1205, 478);
            this.spTraer_Administracion_Guia_PorRutDataGridView.TabIndex = 128;
            this.spTraer_Administracion_Guia_PorRutDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spTraer_Administracion_Guia_PorRutDataGridView_CellClick);
            // 
            // spTraer_Administracion_Guia_PorRutBindingSource
            // 
            this.spTraer_Administracion_Guia_PorRutBindingSource.DataMember = "spTraer_Administracion_Guia_PorRut";
            // 
            // guiaBindingSource
            // 
            this.guiaBindingSource.DataMember = "Guia";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "-- Seleccione Opcion --",
            "Emitida",
            "Anulada"});
            this.CmbEstado.Location = new System.Drawing.Point(649, 30);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(159, 21);
            this.CmbEstado.TabIndex = 129;
            this.CmbEstado.Visible = false;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // spTraer_Administracion_Guia_PorEstadoBindingSource2
            // 
            this.spTraer_Administracion_Guia_PorEstadoBindingSource2.DataMember = "spTraer_Administracion_Guia_PorEstado";
            // 
            // spTraer_Administracion_Guia_PorEstadoDataGridView
            // 
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.AutoGenerateColumns = false;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.DataSource = this.spTraer_Administracion_Guia_PorEstadoBindingSource2;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.Location = new System.Drawing.Point(12, 80);
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.Name = "spTraer_Administracion_Guia_PorEstadoDataGridView";
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.RowHeadersVisible = false;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.Size = new System.Drawing.Size(1205, 493);
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.TabIndex = 130;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = false;
            this.spTraer_Administracion_Guia_PorEstadoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spTraer_Administracion_Guia_PorEstadoDataGridView_CellClick);
            // 
            // FormAdministracionGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1268, 593);
            this.Controls.Add(this.spTraer_Administracion_Guia_PorEstadoDataGridView);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.spTraer_Administracion_Guia_PorRutDataGridView);
            this.Controls.Add(this.spTraer_Administracion_Guia_PorGuiaDataGridView);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spTraer_Administracion_GuiaDataGridView);
            this.Name = "FormAdministracionGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministracionGuia";
            this.Load += new System.EventHandler(this.FormAdministracionGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_GuiaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_GuiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorGuiaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorGuiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorRutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorRutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Administracion_Guia_PorEstadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prueba_2018DataSet prueba_2018DataSet;
        private System.Windows.Forms.BindingSource spTraer_Administracion_GuiaBindingSource;
        private Prueba_2018DataSetTableAdapters.spTraer_Administracion_GuiaTableAdapter spTraer_Administracion_GuiaTableAdapter;
        private Prueba_2018DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spTraer_Administracion_GuiaDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.BindingSource spTraer_Administracion_Guia_PorGuiaBindingSource;
        private Prueba_2018DataSetTableAdapters.spTraer_Administracion_Guia_PorGuiaTableAdapter spTraer_Administracion_Guia_PorGuiaTableAdapter;
        private System.Windows.Forms.DataGridView spTraer_Administracion_Guia_PorGuiaDataGridView;
        private System.Windows.Forms.BindingSource spTraer_Administracion_Guia_PorRutBindingSource;
        private Prueba_2018DataSetTableAdapters.spTraer_Administracion_Guia_PorRutTableAdapter spTraer_Administracion_Guia_PorRutTableAdapter;
        private System.Windows.Forms.DataGridView spTraer_Administracion_Guia_PorRutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private Prueba_2017DataSet prueba_2017DataSet;
        private System.Windows.Forms.BindingSource guiaBindingSource;
        private Prueba_2017DataSetTableAdapters.GuiaTableAdapter guiaTableAdapter;
        private Prueba_2017DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.BindingSource spTraer_Administracion_Guia_PorEstadoBindingSource;
        private Prueba_2018DataSetTableAdapters.spTraer_Administracion_Guia_PorEstadoTableAdapter spTraer_Administracion_Guia_PorEstadoTableAdapter;
        private System.Windows.Forms.BindingSource spTraer_Administracion_Guia_PorEstadoBindingSource1;
        private System.Windows.Forms.BindingSource spTraer_Administracion_Guia_PorEstadoBindingSource2;
        private System.Windows.Forms.DataGridView spTraer_Administracion_Guia_PorEstadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
    }
}