namespace Anakena_2017
{
    partial class FormAnalisisCalidadPMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalisisCalidadPMM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.DT_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Filtro = new System.Windows.Forms.ComboBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.Cmb_Busqueda = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.prueba_2017Preseleccion = new Anakena_2017.Prueba_2017Preseleccion();
            this.spTraer_Analisis_Calidad_PPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTraer_Analisis_Calidad_PPMTableAdapter = new Anakena_2017.Prueba_2017PreseleccionTableAdapters.spTraer_Analisis_Calidad_PPMTableAdapter();
            this.tableAdapterManager = new Anakena_2017.Prueba_2017PreseleccionTableAdapters.TableAdapterManager();
            this.analisisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoAnalisisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoTarjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoTarjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoMuestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cascaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matExtrañaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halvesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largePiecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediumPiecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallPiecesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraLightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightAmbarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amarilloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionMatExtrañaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017Preseleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Analisis_Calidad_PPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(739, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 124;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DT_Fecha
            // 
            this.DT_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Fecha.Location = new System.Drawing.Point(467, 43);
            this.DT_Fecha.Name = "DT_Fecha";
            this.DT_Fecha.Size = new System.Drawing.Size(171, 20);
            this.DT_Fecha.TabIndex = 123;
            this.DT_Fecha.Visible = false;
            // 
            // Cmb_Filtro
            // 
            this.Cmb_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Filtro.FormattingEnabled = true;
            this.Cmb_Filtro.Location = new System.Drawing.Point(467, 42);
            this.Cmb_Filtro.Name = "Cmb_Filtro";
            this.Cmb_Filtro.Size = new System.Drawing.Size(171, 21);
            this.Cmb_Filtro.TabIndex = 122;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Location = new System.Drawing.Point(644, 39);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(89, 28);
            this.Btn_Buscar.TabIndex = 121;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(467, 44);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(161, 20);
            this.txt_filtro.TabIndex = 120;
            // 
            // Cmb_Busqueda
            // 
            this.Cmb_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Busqueda.FormattingEnabled = true;
            this.Cmb_Busqueda.Items.AddRange(new object[] {
            "Analisis",
            "Fecha",
            "Tarja",
            "Bins",
            "Turno",
            "Proceso",
            "Producto Analisis",
            "Producto Tarja",
            "Estado"});
            this.Cmb_Busqueda.Location = new System.Drawing.Point(271, 44);
            this.Cmb_Busqueda.Name = "Cmb_Busqueda";
            this.Cmb_Busqueda.Size = new System.Drawing.Size(171, 21);
            this.Cmb_Busqueda.TabIndex = 119;
            this.Cmb_Busqueda.SelectedIndexChanged += new System.EventHandler(this.Cmb_Busqueda_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.analisisDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tarjaDataGridViewTextBoxColumn,
            this.binsDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.procesoDataGridViewTextBoxColumn,
            this.productoAnalisisDataGridViewTextBoxColumn,
            this.productoTarjaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.codProductoUserDataGridViewTextBoxColumn,
            this.codProductoTarjaDataGridViewTextBoxColumn,
            this.pesoMuestraDataGridViewTextBoxColumn,
            this.cascaraDataGridViewTextBoxColumn,
            this.matExtrañaDataGridViewTextBoxColumn,
            this.halvesDataGridViewTextBoxColumn,
            this.largePiecesDataGridViewTextBoxColumn,
            this.mediumPiecesDataGridViewTextBoxColumn,
            this.smallPiecesDataGridViewTextBoxColumn,
            this.extraLightDataGridViewTextBoxColumn,
            this.lightDataGridViewTextBoxColumn,
            this.lightAmbarDataGridViewTextBoxColumn,
            this.ambarDataGridViewTextBoxColumn,
            this.amarilloDataGridViewTextBoxColumn,
            this.defectosDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.observacionMatExtrañaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spTraer_Analisis_Calidad_PPMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 349);
            this.dataGridView1.TabIndex = 117;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(710, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 126;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar.BackgroundImage")));
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Agregar.Location = new System.Drawing.Point(563, 490);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(118, 34);
            this.Btn_Agregar.TabIndex = 125;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // prueba_2017Preseleccion
            // 
            this.prueba_2017Preseleccion.DataSetName = "Prueba_2017Preseleccion";
            this.prueba_2017Preseleccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTraer_Analisis_Calidad_PPMBindingSource
            // 
            this.spTraer_Analisis_Calidad_PPMBindingSource.DataMember = "spTraer_Analisis_Calidad_PPM";
            this.spTraer_Analisis_Calidad_PPMBindingSource.DataSource = this.prueba_2017Preseleccion;
            // 
            // spTraer_Analisis_Calidad_PPMTableAdapter
            // 
            this.spTraer_Analisis_Calidad_PPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Anakena_2017.Prueba_2017PreseleccionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // analisisDataGridViewTextBoxColumn
            // 
            this.analisisDataGridViewTextBoxColumn.DataPropertyName = "Analisis";
            this.analisisDataGridViewTextBoxColumn.HeaderText = "Analisis";
            this.analisisDataGridViewTextBoxColumn.Name = "analisisDataGridViewTextBoxColumn";
            this.analisisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tarjaDataGridViewTextBoxColumn
            // 
            this.tarjaDataGridViewTextBoxColumn.DataPropertyName = "Tarja";
            this.tarjaDataGridViewTextBoxColumn.HeaderText = "Tarja";
            this.tarjaDataGridViewTextBoxColumn.Name = "tarjaDataGridViewTextBoxColumn";
            // 
            // binsDataGridViewTextBoxColumn
            // 
            this.binsDataGridViewTextBoxColumn.DataPropertyName = "Bins";
            this.binsDataGridViewTextBoxColumn.HeaderText = "Bins";
            this.binsDataGridViewTextBoxColumn.Name = "binsDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procesoDataGridViewTextBoxColumn
            // 
            this.procesoDataGridViewTextBoxColumn.DataPropertyName = "Proceso";
            this.procesoDataGridViewTextBoxColumn.HeaderText = "Proceso";
            this.procesoDataGridViewTextBoxColumn.Name = "procesoDataGridViewTextBoxColumn";
            // 
            // productoAnalisisDataGridViewTextBoxColumn
            // 
            this.productoAnalisisDataGridViewTextBoxColumn.DataPropertyName = "Producto_Analisis";
            this.productoAnalisisDataGridViewTextBoxColumn.HeaderText = "Producto_Analisis";
            this.productoAnalisisDataGridViewTextBoxColumn.Name = "productoAnalisisDataGridViewTextBoxColumn";
            this.productoAnalisisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoTarjaDataGridViewTextBoxColumn
            // 
            this.productoTarjaDataGridViewTextBoxColumn.DataPropertyName = "Producto_Tarja";
            this.productoTarjaDataGridViewTextBoxColumn.HeaderText = "Producto_Tarja";
            this.productoTarjaDataGridViewTextBoxColumn.Name = "productoTarjaDataGridViewTextBoxColumn";
            this.productoTarjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProductoUserDataGridViewTextBoxColumn
            // 
            this.codProductoUserDataGridViewTextBoxColumn.DataPropertyName = "Cod_Producto_User";
            this.codProductoUserDataGridViewTextBoxColumn.HeaderText = "Cod_Producto_User";
            this.codProductoUserDataGridViewTextBoxColumn.Name = "codProductoUserDataGridViewTextBoxColumn";
            this.codProductoUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // codProductoTarjaDataGridViewTextBoxColumn
            // 
            this.codProductoTarjaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Producto_Tarja";
            this.codProductoTarjaDataGridViewTextBoxColumn.HeaderText = "Cod_Producto_Tarja";
            this.codProductoTarjaDataGridViewTextBoxColumn.Name = "codProductoTarjaDataGridViewTextBoxColumn";
            this.codProductoTarjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pesoMuestraDataGridViewTextBoxColumn
            // 
            this.pesoMuestraDataGridViewTextBoxColumn.DataPropertyName = "Peso_Muestra";
            this.pesoMuestraDataGridViewTextBoxColumn.HeaderText = "Peso_Muestra";
            this.pesoMuestraDataGridViewTextBoxColumn.Name = "pesoMuestraDataGridViewTextBoxColumn";
            this.pesoMuestraDataGridViewTextBoxColumn.Visible = false;
            // 
            // cascaraDataGridViewTextBoxColumn
            // 
            this.cascaraDataGridViewTextBoxColumn.DataPropertyName = "Cascara";
            this.cascaraDataGridViewTextBoxColumn.HeaderText = "Cascara";
            this.cascaraDataGridViewTextBoxColumn.Name = "cascaraDataGridViewTextBoxColumn";
            this.cascaraDataGridViewTextBoxColumn.Visible = false;
            // 
            // matExtrañaDataGridViewTextBoxColumn
            // 
            this.matExtrañaDataGridViewTextBoxColumn.DataPropertyName = "Mat_Extraña";
            this.matExtrañaDataGridViewTextBoxColumn.HeaderText = "Mat_Extraña";
            this.matExtrañaDataGridViewTextBoxColumn.Name = "matExtrañaDataGridViewTextBoxColumn";
            this.matExtrañaDataGridViewTextBoxColumn.Visible = false;
            // 
            // halvesDataGridViewTextBoxColumn
            // 
            this.halvesDataGridViewTextBoxColumn.DataPropertyName = "Halves";
            this.halvesDataGridViewTextBoxColumn.HeaderText = "Halves";
            this.halvesDataGridViewTextBoxColumn.Name = "halvesDataGridViewTextBoxColumn";
            this.halvesDataGridViewTextBoxColumn.Visible = false;
            // 
            // largePiecesDataGridViewTextBoxColumn
            // 
            this.largePiecesDataGridViewTextBoxColumn.DataPropertyName = "Large_Pieces";
            this.largePiecesDataGridViewTextBoxColumn.HeaderText = "Large_Pieces";
            this.largePiecesDataGridViewTextBoxColumn.Name = "largePiecesDataGridViewTextBoxColumn";
            this.largePiecesDataGridViewTextBoxColumn.Visible = false;
            // 
            // mediumPiecesDataGridViewTextBoxColumn
            // 
            this.mediumPiecesDataGridViewTextBoxColumn.DataPropertyName = "Medium_Pieces";
            this.mediumPiecesDataGridViewTextBoxColumn.HeaderText = "Medium_Pieces";
            this.mediumPiecesDataGridViewTextBoxColumn.Name = "mediumPiecesDataGridViewTextBoxColumn";
            this.mediumPiecesDataGridViewTextBoxColumn.Visible = false;
            // 
            // smallPiecesDataGridViewTextBoxColumn
            // 
            this.smallPiecesDataGridViewTextBoxColumn.DataPropertyName = "Small_Pieces";
            this.smallPiecesDataGridViewTextBoxColumn.HeaderText = "Small_Pieces";
            this.smallPiecesDataGridViewTextBoxColumn.Name = "smallPiecesDataGridViewTextBoxColumn";
            this.smallPiecesDataGridViewTextBoxColumn.Visible = false;
            // 
            // extraLightDataGridViewTextBoxColumn
            // 
            this.extraLightDataGridViewTextBoxColumn.DataPropertyName = "Extra_Light";
            this.extraLightDataGridViewTextBoxColumn.HeaderText = "Extra_Light";
            this.extraLightDataGridViewTextBoxColumn.Name = "extraLightDataGridViewTextBoxColumn";
            this.extraLightDataGridViewTextBoxColumn.Visible = false;
            // 
            // lightDataGridViewTextBoxColumn
            // 
            this.lightDataGridViewTextBoxColumn.DataPropertyName = "Light";
            this.lightDataGridViewTextBoxColumn.HeaderText = "Light";
            this.lightDataGridViewTextBoxColumn.Name = "lightDataGridViewTextBoxColumn";
            this.lightDataGridViewTextBoxColumn.Visible = false;
            // 
            // lightAmbarDataGridViewTextBoxColumn
            // 
            this.lightAmbarDataGridViewTextBoxColumn.DataPropertyName = "Light_Ambar";
            this.lightAmbarDataGridViewTextBoxColumn.HeaderText = "Light_Ambar";
            this.lightAmbarDataGridViewTextBoxColumn.Name = "lightAmbarDataGridViewTextBoxColumn";
            this.lightAmbarDataGridViewTextBoxColumn.Visible = false;
            // 
            // ambarDataGridViewTextBoxColumn
            // 
            this.ambarDataGridViewTextBoxColumn.DataPropertyName = "Ambar";
            this.ambarDataGridViewTextBoxColumn.HeaderText = "Ambar";
            this.ambarDataGridViewTextBoxColumn.Name = "ambarDataGridViewTextBoxColumn";
            this.ambarDataGridViewTextBoxColumn.Visible = false;
            // 
            // amarilloDataGridViewTextBoxColumn
            // 
            this.amarilloDataGridViewTextBoxColumn.DataPropertyName = "Amarillo";
            this.amarilloDataGridViewTextBoxColumn.HeaderText = "Amarillo";
            this.amarilloDataGridViewTextBoxColumn.Name = "amarilloDataGridViewTextBoxColumn";
            this.amarilloDataGridViewTextBoxColumn.Visible = false;
            // 
            // defectosDataGridViewTextBoxColumn
            // 
            this.defectosDataGridViewTextBoxColumn.DataPropertyName = "Defectos";
            this.defectosDataGridViewTextBoxColumn.HeaderText = "Defectos";
            this.defectosDataGridViewTextBoxColumn.Name = "defectosDataGridViewTextBoxColumn";
            this.defectosDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacionMatExtrañaDataGridViewTextBoxColumn
            // 
            this.observacionMatExtrañaDataGridViewTextBoxColumn.DataPropertyName = "Observacion_Mat_Extraña";
            this.observacionMatExtrañaDataGridViewTextBoxColumn.HeaderText = "Observacion_Mat_Extraña";
            this.observacionMatExtrañaDataGridViewTextBoxColumn.Name = "observacionMatExtrañaDataGridViewTextBoxColumn";
            this.observacionMatExtrañaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormAnalisisCalidadPMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(872, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DT_Fecha);
            this.Controls.Add(this.Cmb_Filtro);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.Cmb_Busqueda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAnalisisCalidadPMM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnalisisCalidadPMM";
            this.Load += new System.EventHandler(this.FormAnalisisCalidadPMM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_2017Preseleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTraer_Analisis_Calidad_PPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DT_Fecha;
        private System.Windows.Forms.ComboBox Cmb_Filtro;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.ComboBox Cmb_Busqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Btn_Agregar;
        private Prueba_2017Preseleccion prueba_2017Preseleccion;
        private System.Windows.Forms.BindingSource spTraer_Analisis_Calidad_PPMBindingSource;
        private Prueba_2017PreseleccionTableAdapters.spTraer_Analisis_Calidad_PPMTableAdapter spTraer_Analisis_Calidad_PPMTableAdapter;
        private Prueba_2017PreseleccionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn analisisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn binsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoAnalisisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoTarjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoTarjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoMuestraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cascaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matExtrañaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halvesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn largePiecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediumPiecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallPiecesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraLightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightAmbarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amarilloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionMatExtrañaDataGridViewTextBoxColumn;
    }
}