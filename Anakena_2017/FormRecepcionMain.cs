using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormRecepcionMain : Form
	{
		private IContainer components = null;

		private DataGridView dataGridView1;

		private Label label1;

		private ComboBox CmbFiltro;

		private TextBox Txt_Busqueda;

		private Button BtnBuscar;

		private Button Btn_Limpiar;

		private ComboBox Cmb_Busqueda;

		private DateTimePicker Dt_Busqueda;

		private Button button2;

		public Button Btn_Agregar;

		private LinkLabel linkLabel1;

		private conexion cn = new conexion();

		public int x = 0;

		private DataSet myds = new DataSet();
        private PictureBox pictureBox1;
        public string usuario = "";
        private GroupBox groupBox1;
        public int acceso = 0;
		public FormRecepcionMain()
		{
			this.InitializeComponent();
		}

		private void Btn_Limpiar_Click(object sender, EventArgs e)
		{
			this.traerDistintosProductores();
			this.CmbFiltro.SelectedIndex = 0;
			this.Txt_Busqueda.Focus();
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.CmbFiltro.Text == "Analisis")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Analisis = '", this.Txt_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Nº Lote")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Lote = '", this.Txt_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Recepcion")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Recepcion = '", this.Cmb_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Patio recepcion")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Patio_recepcion = '", this.Cmb_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Variedad")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Variedad = '", this.Cmb_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Fecha recepcion")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Fecha_recepcion = '", this.Dt_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Fecha analisis")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Fecha_analisis = '", this.Dt_Busqueda.Text, "'");
				}
				else if (this.CmbFiltro.Text == "Productor")
				{
					this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Productor = '", this.Txt_Busqueda.Text, "'");
				}
			}
			catch
			{
			}
			if (this.dataGridView1.RowCount < 1)
			{
				MessageBox.Show("No se a encontrado parametro de busqueda", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.traerDistintosProductores();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormRecepcion formRecepcion = new FormRecepcion();
			formRecepcion.Txt_Lote.Focus();
			formRecepcion.groupBox10.Visible = false;
			formRecepcion.groupBox9.Visible = true;
			formRecepcion.Btn_Print.Enabled = false;
			formRecepcion.usuario = this.usuario;
			formRecepcion.ShowDialog();
			this.traerDistintosProductores();
			this.CmbFiltro.SelectedIndex = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void Cmb_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.linkLabel1.Visible = false;
			if (!(this.CmbFiltro.Text == "Analisis" ? false : !(this.CmbFiltro.Text == "Nº Lote")))
			{
				this.Dt_Busqueda.Visible = false;
				this.Txt_Busqueda.Text = "";
				this.Txt_Busqueda.Visible = true;
				this.Cmb_Busqueda.Visible = false;
			}
			else if (this.CmbFiltro.Text == "Recepcion")
			{
				this.Dt_Busqueda.Visible = false;
				this.Txt_Busqueda.Visible = false;
				this.Cmb_Busqueda.Visible = true;
				this.Cmb_Busqueda.DataSource = null;
				this.Cmb_Busqueda.Items.Clear();
				this.Cmb_Busqueda.Items.Add("Humeda");
				this.Cmb_Busqueda.Items.Add("Pelón");
				this.Cmb_Busqueda.SelectedIndex = 0;
			}
			else if (this.CmbFiltro.Text == "Patio recepcion")
			{
				this.Dt_Busqueda.Visible = false;
				this.Txt_Busqueda.Visible = false;
				this.Cmb_Busqueda.Visible = true;
				this.Cmb_Busqueda.DataSource = null;
				this.Cmb_Busqueda.Items.Clear();
				this.Cmb_Busqueda.Items.Add("Patio 1");
				this.Cmb_Busqueda.Items.Add("Patio 2");
				this.Cmb_Busqueda.SelectedIndex = 0;
			}
			else if (this.CmbFiltro.Text == "Variedad")
			{
				this.Dt_Busqueda.Visible = false;
				this.Txt_Busqueda.Visible = false;
				this.Cmb_Busqueda.Visible = true;
				this.CmbVariedad();
			}
			else if (this.CmbFiltro.Text == "Fecha recepcion")
			{
				this.Txt_Busqueda.Visible = false;
				this.Cmb_Busqueda.Visible = false;
				this.Dt_Busqueda.Visible = true;
			}
			else if (this.CmbFiltro.Text == "Fecha analisis")
			{
				this.Txt_Busqueda.Visible = false;
				this.Cmb_Busqueda.Visible = false;
				this.Dt_Busqueda.Visible = true;
			}
			else if (this.CmbFiltro.Text == "Productor")
			{
				this.Txt_Busqueda.Text = "";
				this.Txt_Busqueda.Visible = true;
				this.Cmb_Busqueda.Visible = false;
				this.Dt_Busqueda.Visible = false;
				this.linkLabel1.Visible = true;
			}
		}

		public void CmbVariedad()
		{
			try
			{
				try
				{
					this.cn.Abrir();
					SqlCommand sqlCommand = new SqlCommand("spTraerVariedad", this.cn.getConexion());
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					DataSet dataSet = new DataSet();
					sqlDataAdapter.Fill(dataSet, "Variedad");
					this.Cmb_Busqueda.Refresh();
					this.Cmb_Busqueda.DataSource = dataSet.Tables["Variedad"].DefaultView;
					this.Cmb_Busqueda.DisplayMember = "Des_Variedad";
					this.Cmb_Busqueda.ValueMember = "Cod_Variedad";
				}
				catch
				{
					MessageBox.Show("Ocurrio un problema al cargar variedades", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			finally
			{
				this.cn.Cerrar();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            if (acceso == 0)
            {

                FormRecepcion formRecepcion = new FormRecepcion();
                try
                {
                    formRecepcion.Txt_Lote.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Lote"].Value.ToString();
                    formRecepcion.TraerEnvases(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerImpurezas(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerAnalisisExterno(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerAnalisisInterno(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.Lbl_Analisis.Text = string.Concat("Nº Analisis ", this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString());
                }
                catch
                {
                }
                formRecepcion.ACCESSO = 1;
                if (!(formRecepcion.Txt_Quebrados.Text == ""))
                {
                    formRecepcion.groupBox2.Enabled = true;
                    formRecepcion.groupBox3.Enabled = true;
                    formRecepcion.groupBox4.Enabled = true;
                    formRecepcion.groupBox5.Enabled = true;
                    formRecepcion.Txt_Quebrados.Enabled = true;
                    formRecepcion.Txt_Quebrados.ReadOnly = true;
                    formRecepcion.TxtDañados.Enabled = true;
                    formRecepcion.TxtDañados.ReadOnly = true;
                    formRecepcion.Txt_Piedras.Enabled = true;
                    formRecepcion.Txt_Piedras.ReadOnly = true;
                    formRecepcion.Txt_Palos.Enabled = true;
                    formRecepcion.Txt_Palos.ReadOnly = true;
                    formRecepcion.TxtCantidadProductor.Enabled = true;
                    formRecepcion.TxtCantidadProductor.ReadOnly = true;
                    formRecepcion.TxtCantidadAnakena.Enabled = true;
                    formRecepcion.TxtCantidadAnakena.ReadOnly = true;
                    formRecepcion.Txt_Partidas.Enabled = true;
                    formRecepcion.Txt_Partidas.ReadOnly = true;
                    formRecepcion.Txt_Nuez.Enabled = true;
                    formRecepcion.Txt_Nuez.ReadOnly = true;
                    formRecepcion.Txt_Resquebrajado.Enabled = true;
                    formRecepcion.Txt_Resquebrajado.ReadOnly = true;
                    formRecepcion.Txt_Cerrado.Enabled = true;
                    formRecepcion.Txt_Cerrado.ReadOnly = true;
                    formRecepcion.Txt_Negras.Enabled = true;
                    formRecepcion.Txt_Negras.ReadOnly = true;
                    formRecepcion.TxtTotalExterno.Enabled = true;
                    formRecepcion.TxtTotalExterno.ReadOnly = true;
                    formRecepcion.Txt_Adherido.Enabled = true;
                    formRecepcion.Txt_Adherido.ReadOnly = true;
                    formRecepcion.Txt_Daño.Enabled = true;
                    formRecepcion.Txt_Daño.ReadOnly = true;
                    formRecepcion.Txt_Vanas.Enabled = true;
                    formRecepcion.Txt_Vanas.ReadOnly = true;
                    formRecepcion.Txt_Reseca.Enabled = true;
                    formRecepcion.Txt_Reseca.ReadOnly = true;
                    formRecepcion.Txt_HongoActivo.Enabled = true;
                    formRecepcion.Txt_HongoActivo.ReadOnly = true;
                    formRecepcion.Txt_HongoInactivo.Enabled = true;
                    formRecepcion.Txt_HongoInactivo.ReadOnly = true;
                    formRecepcion.Txt_Extra.Enabled = true;
                    formRecepcion.Txt_Extra.ReadOnly = true;
                    formRecepcion.Txt_Light.Enabled = true;
                    formRecepcion.Txt_Light.ReadOnly = true;
                    formRecepcion.Txt_LightAmbar.Enabled = true;
                    formRecepcion.Txt_LightAmbar.ReadOnly = true;
                    formRecepcion.Txt_Ambar.Enabled = true;
                    formRecepcion.Txt_Ambar.ReadOnly = true;
                    formRecepcion.Txt_TotalInterno.Enabled = true;
                    formRecepcion.Txt_TotalInterno.ReadOnly = true;
                }
                else
                {
                    formRecepcion.groupBox2.Enabled = true;
                    formRecepcion.TxtCantidadProductor.Enabled = true;
                    formRecepcion.TxtCantidadProductor.Focus();
                    formRecepcion.usuario = this.usuario;
                }
                try
                {
                    formRecepcion.traerLote(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Lote"].Value.ToString()));
                    formRecepcion.Btn_Guardar.Enabled = false;
                    formRecepcion.Txt_Lote.ReadOnly = true;
                    formRecepcion.CmbRecepcion.Enabled = false;
                    formRecepcion.CmbRecepcion.DropDownStyle = ComboBoxStyle.Simple;
                    formRecepcion.cmbVariedad.DropDownStyle = ComboBoxStyle.Simple;
                    formRecepcion.cmbVariedad.Enabled = false;
                    formRecepcion.Txt_Productor.Enabled = true;
                    formRecepcion.Txt_Productor.ReadOnly = true;
                    formRecepcion.Txt_ProductorName.Enabled = true;
                    formRecepcion.Txt_ProductorName.ReadOnly = true;
                    formRecepcion.CmbPatio.Enabled = false;
                    formRecepcion.CmbPatio.DropDownStyle = ComboBoxStyle.Simple;
                    formRecepcion.DT_Analisis.Enabled = false;
                    formRecepcion.DT_Recepcion.Enabled = false;
                    formRecepcion.button2.Enabled = false;
                }
                catch
                {
                }
                if (!this.Btn_Agregar.Visible)
                {
                    formRecepcion.Btn_Guardar.Enabled = true;
                    formRecepcion.Txt_Lote.ReadOnly = false;
                    formRecepcion.BtnUpdate.Visible = true;
                    formRecepcion.CmbRecepcion.Enabled = true;
                    formRecepcion.CmbRecepcion.DropDownStyle = ComboBoxStyle.DropDownList;
                    formRecepcion.cmbVariedad.DropDownStyle = ComboBoxStyle.DropDown;
                    formRecepcion.Txt_Productor.Enabled = true;
                    formRecepcion.Txt_Productor.ReadOnly = false;
                    formRecepcion.Txt_ProductorName.Enabled = true;
                    formRecepcion.Txt_ProductorName.ReadOnly = false;
                    formRecepcion.CmbPatio.Enabled = true;
                    formRecepcion.CmbPatio.DropDownStyle = ComboBoxStyle.DropDownList;
                    formRecepcion.button2.Visible = false;
                    formRecepcion.groupBox9.Visible = false;
                    formRecepcion.groupBox10.Visible = true;
                    formRecepcion.groupBox2.Enabled = true;
                    formRecepcion.groupBox3.Enabled = true;
                    formRecepcion.groupBox4.Enabled = true;
                    formRecepcion.groupBox5.Enabled = true;
                    formRecepcion.Txt_Quebrados.Enabled = true;
                    formRecepcion.Txt_Quebrados.ReadOnly = false;
                    formRecepcion.TxtDañados.Enabled = true;
                    formRecepcion.TxtDañados.ReadOnly = false;
                    formRecepcion.TxtCantidadProductor.Enabled = true;
                    formRecepcion.TxtCantidadProductor.ReadOnly = false;
                    formRecepcion.TxtCantidadAnakena.Enabled = true;
                    formRecepcion.TxtCantidadAnakena.ReadOnly = false;
                    formRecepcion.Txt_Piedras.Enabled = true;
                    formRecepcion.Txt_Piedras.ReadOnly = false;
                    formRecepcion.Txt_Palos.Enabled = true;
                    formRecepcion.Txt_Palos.ReadOnly = false;
                    formRecepcion.Txt_Observaciones.Enabled = true;
                    formRecepcion.Txt_Observaciones.ReadOnly = false;
                    formRecepcion.Txt_Partidas.Enabled = true;
                    formRecepcion.Txt_Partidas.ReadOnly = false;
                    formRecepcion.Txt_Nuez.Enabled = true;
                    formRecepcion.Txt_Nuez.ReadOnly = false;
                    formRecepcion.Txt_Resquebrajado.Enabled = true;
                    formRecepcion.Txt_Resquebrajado.ReadOnly = false;
                    formRecepcion.Txt_Cerrado.Enabled = true;
                    formRecepcion.Txt_Cerrado.ReadOnly = false;
                    formRecepcion.Txt_Negras.Enabled = true;
                    formRecepcion.Txt_Negras.ReadOnly = false;
                    formRecepcion.TxtTotalExterno.Enabled = true;
                    formRecepcion.TxtTotalExterno.ReadOnly = false;
                    formRecepcion.Txt_Adherido.Enabled = true;
                    formRecepcion.Txt_Adherido.ReadOnly = false;
                    formRecepcion.Txt_Daño.Enabled = true;
                    formRecepcion.Txt_Daño.ReadOnly = false;
                    formRecepcion.Txt_Vanas.Enabled = true;
                    formRecepcion.Txt_Vanas.ReadOnly = false;
                    formRecepcion.Txt_Reseca.Enabled = true;
                    formRecepcion.Txt_Reseca.ReadOnly = false;
                    formRecepcion.Txt_HongoActivo.Enabled = true;
                    formRecepcion.Txt_HongoActivo.ReadOnly = false;
                    formRecepcion.Txt_HongoInactivo.Enabled = true;
                    formRecepcion.Txt_HongoInactivo.ReadOnly = false;
                    formRecepcion.Txt_Extra.Enabled = true;
                    formRecepcion.Txt_Extra.ReadOnly = false;
                    formRecepcion.Txt_Light.Enabled = true;
                    formRecepcion.Txt_Light.ReadOnly = false;
                    formRecepcion.Txt_LightAmbar.Enabled = true;
                    formRecepcion.Txt_LightAmbar.ReadOnly = false;
                    formRecepcion.Txt_Ambar.Enabled = true;
                    formRecepcion.Txt_Ambar.ReadOnly = false;
                    formRecepcion.Txt_TotalInterno.Enabled = true;
                    formRecepcion.Txt_TotalInterno.ReadOnly = false;
                }
                else
                {
                    formRecepcion.groupBox9.Visible = true;
                    formRecepcion.groupBox10.Visible = false;
                }
                try
                {
                    if (!(this.dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString() == "Completa"))
                    {
                        formRecepcion.Btn_Print.Enabled = false;
                    }
                    else
                    {
                        formRecepcion.Btn_Print.Enabled = true;
                    }
                    formRecepcion.ShowDialog();
                    this.traerDistintosProductores();
                }
                catch
                {
                }
            }
            else
            {
                FormRecepcionProductor formRecepcion = new FormRecepcionProductor();
                try
                {
                    formRecepcion.Txt_Lote.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Lote"].Value.ToString();
                  
                    formRecepcion.TraerImpurezas(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerAnalisisExterno(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerAnalisisInterno(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.TraerEnvases(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString()));
                    formRecepcion.Lbl_Analisis.Text = string.Concat("Nº Analisis ", this.dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString());
                }
                catch
                {
                }
                formRecepcion.ShowDialog();
            }
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Dt_Busqueda_ValueChanged(object sender, EventArgs e)
		{
		}

		private void FormRecepcionMain_Load(object sender, EventArgs e)
		{
			this.traerDistintosProductores();
			this.CmbFiltro.SelectedIndex = 0;
		}

		private void FormRecepcionMain_Load_1(object sender, EventArgs e)
		{
			this.traerDistintosProductores();
			this.CmbFiltro.SelectedIndex = 0;
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecepcionMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Cmb_Busqueda = new System.Windows.Forms.ComboBox();
            this.Dt_Busqueda = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar.BackgroundImage")));
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Agregar.Location = new System.Drawing.Point(735, 641);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 26);
            this.Btn_Agregar.TabIndex = 0;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(892, 514);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Analisis",
            "Nº Lote",
            "Recepcion",
            "Variedad",
            "Productor",
            "Patio recepcion",
            "Fecha recepcion",
            "Fecha analisis"});
            this.CmbFiltro.Location = new System.Drawing.Point(83, 23);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(147, 24);
            this.CmbFiltro.TabIndex = 3;
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Busqueda.Location = new System.Drawing.Point(236, 22);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(185, 22);
            this.Txt_Busqueda.TabIndex = 4;
            this.Txt_Busqueda.TextChanged += new System.EventHandler(this.Txt_Busqueda_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(427, 22);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 25);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.BackgroundImage")));
            this.Btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Limpiar.Location = new System.Drawing.Point(504, 22);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(71, 25);
            this.Btn_Limpiar.TabIndex = 6;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Cmb_Busqueda
            // 
            this.Cmb_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Busqueda.FormattingEnabled = true;
            this.Cmb_Busqueda.Location = new System.Drawing.Point(236, 23);
            this.Cmb_Busqueda.Name = "Cmb_Busqueda";
            this.Cmb_Busqueda.Size = new System.Drawing.Size(185, 24);
            this.Cmb_Busqueda.TabIndex = 7;
            this.Cmb_Busqueda.Visible = false;
            this.Cmb_Busqueda.SelectedIndexChanged += new System.EventHandler(this.Cmb_Busqueda_SelectedIndexChanged);
            // 
            // Dt_Busqueda
            // 
            this.Dt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Busqueda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_Busqueda.Location = new System.Drawing.Point(236, 23);
            this.Dt_Busqueda.Name = "Dt_Busqueda";
            this.Dt_Busqueda.Size = new System.Drawing.Size(185, 22);
            this.Dt_Busqueda.TabIndex = 8;
            this.Dt_Busqueda.Visible = false;
            this.Dt_Busqueda.ValueChanged += new System.EventHandler(this.Dt_Busqueda_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(820, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 26);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(424, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "busqueda avanzada";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbFiltro);
            this.groupBox1.Controls.Add(this.Txt_Busqueda);
            this.groupBox1.Controls.Add(this.Dt_Busqueda);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.Cmb_Busqueda);
            this.groupBox1.Controls.Add(this.Btn_Limpiar);
            this.groupBox1.Location = new System.Drawing.Point(212, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // FormRecepcionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(916, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormRecepcionMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.FormRecepcionMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormBusquedaProductor formBusquedaProductor = new FormBusquedaProductor();
			formBusquedaProductor.ShowDialog();
			this.Txt_Busqueda.Text = formBusquedaProductor.codigo;
			if (this.CmbFiltro.Text == "Productor")
			{
				this.myds.Tables[0].DefaultView.RowFilter = string.Concat("Productor = '", this.Txt_Busqueda.Text, "'");
			}
			if (this.dataGridView1.RowCount < 1)
			{
				MessageBox.Show("No se a encontrado parametro de busqueda", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.traerDistintosProductores();
			}
		}

		public void traerDistintosProductores()
		{
			SqlCommand sqlCommand = new SqlCommand("spTraerEncabezados", this.cn.getConexion())
			{
				CommandType = CommandType.StoredProcedure
			};
			this.cn.Abrir();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			this.myds = new DataSet();
			sqlDataAdapter.Fill(this.myds);
			this.dataGridView1.DataSource = this.myds.Tables[0];
			this.cn.Cerrar();
		}

		private void Txt_Busqueda_TextChanged(object sender, EventArgs e)
		{
		}
	}
}