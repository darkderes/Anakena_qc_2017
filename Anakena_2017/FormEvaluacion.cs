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
	public class FormEvaluacion : Form
    {
		private string min = "";
		private string max = "";
		private conexion cn = new conexion();
		private IContainer components = null;
		private Label label9;
		private Label label10;
    	private Label label15;
        String Variedad_2 = "";
		private Label label20;

		private Label label12;

		private Label label22;

		private Label label23;

		private Label label24;

		private Label label25;

		private Label label26;

		private Label label11;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Label label7;

		private Label label8;

		private Label label13;

		private Label label14;

		private Label label16;

		private Label label17;

		private Label label18;

		private Label label19;

		private Label label21;

		private Label label27;

		private Label label28;

		private Label label29;

		private Label label30;

		private Label label31;

		private Label label32;

		private Label label33;

		private TextBox txtVerde_min;

		private TextBox txtVanas_min;

		private TextBox txtReseca_min;

		private TextBox txtHongoActivo_min;

		private TextBox txtExtra_min;

		private TextBox txtAmbar_min;

		private TextBox txtPelon_min;

		private TextBox txtNegra_min;

		private TextBox txtPartidas_min;

		private TextBox txtPalos_min;

		private TextBox txtInsectos_min;

		private TextBox txtInsectos_max;

		private TextBox txtPalos_max;

		private TextBox txtPartidas_max;

		private TextBox txtNegra_max;

		private TextBox txtPelon_max;

		private TextBox txtAmbar_max;

		private TextBox txtExtra_max;

		private TextBox txtHongoActivo_max;

		private TextBox txtReseca_max;

		private TextBox txtVanas_max;

		private TextBox txtAmarillo_max;

		private Label label34;

		private Label label35;

		private Label label36;

		private Label label37;

		private Label label38;

		private Label label39;

		private Label label40;

		private Label label41;

		private Label label42;

		private Label label43;

		private Label label44;

		private Label lblHongoActivo_min;

		private Label lblExtra_min;

		private Label lblAmbar_min;

		private Label lblPalo_min;

		private Label lblPartidas_min;

		private Label lblNegra_min;

		private Label lblPelon_min;

		private Label lblInsectos_min;

		private Label lblVanas_min;

		private Label lblReseca_min;

		private Label lblAmarillo_max;

		private Label label56;

		private Label label57;

		private Label label58;

		private Label label59;

		private Label label60;

		private Label label61;

		private Label label62;

		private Label label63;

		private Label label64;

		private Label label65;

		private Label label66;

		private Label lblHongoActivo_max;

		private Label lblExtra_max;

		private Label lblAmbar_max;

		private Label lblPalo_max;

		private Label lblPartidas_max;

		private Label lblNegra_max;

		private Label lblPelon_max;

		private Label lblInsectos_max;

		private Label lblVanas_max;

		private Label lblReseca_max;

		private Label LblRojo_max;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private PictureBox pictureBox1;

        private BindingSource analisis_ExternoBindingSource;
        public ComboBox CmbVariedad;
        private Label label45;
        private Label LblPelonSuelto_max;
        private TextBox txtPelonSuelto_max;
        private Label label47;
        private Label LblPelonSuelto_min;
        private TextBox txtPelonSuelto_min;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label lblLight_max;
        private TextBox txtLight_max;
        private Label label52;
        private Label lblLight_min;
        private TextBox txtLight_min;
        private Label label54;
        private Label label55;
        private Label label67;
        private Label label48;
        private Label lblHongoInactivo_max;
        private TextBox txtHongoInactivo_max;
        private Label label68;
        private Label lblHongoInactivo_min;
        private TextBox txtHongoInactivo_min;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label46;
        public Button btn_modificar;

		public FormEvaluacion(String Variedad)
		{
			this.InitializeComponent();
            Variedad_2 = Variedad;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					this.update_parametro(Convert.ToInt32(this.txtVerde_min.Text), Convert.ToInt32(this.txtAmarillo_max.Text), "Impurezas_Piedras");
					this.update_parametro(Convert.ToInt32(this.txtPalos_min.Text), Convert.ToInt32(this.txtPalos_max.Text), "Impurezas_Palo");
                    this.update_parametro(Convert.ToInt32(txtPelonSuelto_min.Text), Convert.ToInt32(txtPelonSuelto_max.Text), "Impurezas_Pelon");
                    this.update_parametro(Convert.ToInt32(txtPelonSuelto_min.Text), Convert.ToInt32(txtPelonSuelto_max.Text), "Pelon_Adherido");
                    this.update_parametro(Convert.ToInt32(this.txtPartidas_min.Text), Convert.ToInt32(this.txtPartidas_max.Text), "Partidas_Quebradas");
					this.update_parametro(Convert.ToInt32(this.txtNegra_min.Text), Convert.ToInt32(this.txtNegra_max.Text), "Negras_Momificadas");
					this.update_parametro(Convert.ToInt32(this.txtPelon_min.Text), Convert.ToInt32(this.txtPelon_max.Text), "Pelon_Adherido");
					this.update_parametro(Convert.ToInt32(this.txtInsectos_min.Text), Convert.ToInt32(this.txtInsectos_max.Text), "Daño_Insectos");
					this.update_parametro(Convert.ToInt32(this.txtVanas_min.Text), Convert.ToInt32(this.txtVanas_max.Text), "Vanas");
					this.update_parametro(Convert.ToInt32(this.txtReseca_min.Text), Convert.ToInt32(this.txtReseca_max.Text), "Reseca");
					this.update_parametro(Convert.ToInt32(this.txtHongoActivo_min.Text), Convert.ToInt32(this.txtHongoActivo_max.Text), "Hongo_Activo");
                    this.update_parametro(Convert.ToInt32(this.txtHongoInactivo_min.Text), Convert.ToInt32(this.txtHongoInactivo_max.Text), "Hongo_Inactivo");
                    this.update_parametro(Convert.ToInt32(this.txtAmbar_min.Text), Convert.ToInt32(this.txtAmbar_max.Text), "Ambar_Amarillo");
					this.update_parametro(Convert.ToInt32(this.txtExtra_min.Text), Convert.ToInt32(this.txtExtra_max.Text), "Extra_Light");
                    this.update_parametro(Convert.ToInt32(this.txtLight_min.Text), Convert.ToInt32(this.txtLight_max.Text), "Light");
                    MessageBox.Show("informacion actualizada correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch
				{
					MessageBox.Show("Error al tratar de modificar parametros de evaluacion", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			finally
			{
				this.traer_datos();
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

		public void extraerMedicion(string parametro,string variedad)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerEvaluacion", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Parametro", parametro);
            sqlCommand.Parameters.AddWithValue("@Variedad",variedad);
            sqlDataAdapter.Fill(new DataSet(), "producto");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.min = sqlDataReader[0].ToString();
					this.max = sqlDataReader[1].ToString();
				}
			}
			finally
			{
				if (sqlDataReader != null)
				{
					((IDisposable)sqlDataReader).Dispose();
				}
			}
			this.cn.Cerrar();
		}

		private void FormEvaluacion_Load(object sender, EventArgs e)
		{
            // TODO: esta línea de código carga datos en la tabla 'prueba_2017DataSet.Analisis_Externo' Puede moverla o quitarla según sea necesario.
         
            traer_datos();
          //  CmbVariedad_traer();
		}
        public void CmbVariedad_traer()
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
                    this.CmbVariedad.Refresh();
                    this.CmbVariedad.DataSource = dataSet.Tables["Variedad"].DefaultView;
                    this.CmbVariedad.DisplayMember = "Des_Variedad";
                    this.CmbVariedad.ValueMember = "Cod_Variedad";
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

        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvaluacion));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtVerde_min = new System.Windows.Forms.TextBox();
            this.txtVanas_min = new System.Windows.Forms.TextBox();
            this.txtReseca_min = new System.Windows.Forms.TextBox();
            this.txtHongoActivo_min = new System.Windows.Forms.TextBox();
            this.txtExtra_min = new System.Windows.Forms.TextBox();
            this.txtAmbar_min = new System.Windows.Forms.TextBox();
            this.txtPelon_min = new System.Windows.Forms.TextBox();
            this.txtNegra_min = new System.Windows.Forms.TextBox();
            this.txtPartidas_min = new System.Windows.Forms.TextBox();
            this.txtPalos_min = new System.Windows.Forms.TextBox();
            this.txtInsectos_min = new System.Windows.Forms.TextBox();
            this.txtInsectos_max = new System.Windows.Forms.TextBox();
            this.txtPalos_max = new System.Windows.Forms.TextBox();
            this.txtPartidas_max = new System.Windows.Forms.TextBox();
            this.txtNegra_max = new System.Windows.Forms.TextBox();
            this.txtPelon_max = new System.Windows.Forms.TextBox();
            this.txtAmbar_max = new System.Windows.Forms.TextBox();
            this.txtExtra_max = new System.Windows.Forms.TextBox();
            this.txtHongoActivo_max = new System.Windows.Forms.TextBox();
            this.txtReseca_max = new System.Windows.Forms.TextBox();
            this.txtVanas_max = new System.Windows.Forms.TextBox();
            this.txtAmarillo_max = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lblHongoActivo_min = new System.Windows.Forms.Label();
            this.lblExtra_min = new System.Windows.Forms.Label();
            this.lblAmbar_min = new System.Windows.Forms.Label();
            this.lblPalo_min = new System.Windows.Forms.Label();
            this.lblPartidas_min = new System.Windows.Forms.Label();
            this.lblNegra_min = new System.Windows.Forms.Label();
            this.lblPelon_min = new System.Windows.Forms.Label();
            this.lblInsectos_min = new System.Windows.Forms.Label();
            this.lblVanas_min = new System.Windows.Forms.Label();
            this.lblReseca_min = new System.Windows.Forms.Label();
            this.lblAmarillo_max = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lblHongoActivo_max = new System.Windows.Forms.Label();
            this.lblExtra_max = new System.Windows.Forms.Label();
            this.lblAmbar_max = new System.Windows.Forms.Label();
            this.lblPalo_max = new System.Windows.Forms.Label();
            this.lblPartidas_max = new System.Windows.Forms.Label();
            this.lblNegra_max = new System.Windows.Forms.Label();
            this.lblPelon_max = new System.Windows.Forms.Label();
            this.lblInsectos_max = new System.Windows.Forms.Label();
            this.lblVanas_max = new System.Windows.Forms.Label();
            this.lblReseca_max = new System.Windows.Forms.Label();
            this.LblRojo_max = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbVariedad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.LblPelonSuelto_max = new System.Windows.Forms.Label();
            this.txtPelonSuelto_max = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.LblPelonSuelto_min = new System.Windows.Forms.Label();
            this.txtPelonSuelto_min = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.lblLight_max = new System.Windows.Forms.Label();
            this.txtLight_max = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.lblLight_min = new System.Windows.Forms.Label();
            this.txtLight_min = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblHongoInactivo_max = new System.Windows.Forms.Label();
            this.txtHongoInactivo_max = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.lblHongoInactivo_min = new System.Windows.Forms.Label();
            this.txtHongoInactivo_min = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Impurezas: Palos, Hojas, Pasto :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Impurezas: Piedras, Terrones :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Negras / Momificadas :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(21, 297);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 18);
            this.label20.TabIndex = 6;
            this.label20.Text = "Partidas / Quebradas :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Pelon Adherido (verde %) :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 582);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 18);
            this.label22.TabIndex = 13;
            this.label22.Text = "Extra Light:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(21, 517);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 18);
            this.label23.TabIndex = 12;
            this.label23.Text = "Hongo Activo:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(21, 480);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 18);
            this.label24.TabIndex = 11;
            this.label24.Text = "Reseca Grave:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(21, 442);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 18);
            this.label25.TabIndex = 10;
            this.label25.Text = "Vanas:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(21, 402);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(138, 18);
            this.label26.TabIndex = 9;
            this.label26.Text = "Daño por insectos :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ambar o Amarillo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 648);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(262, 582);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(278, 517);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(294, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 18);
            this.label17.TabIndex = 26;
            this.label17.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(294, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 18);
            this.label18.TabIndex = 27;
            this.label18.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(294, 442);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 18);
            this.label19.TabIndex = 28;
            this.label19.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(294, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 18);
            this.label21.TabIndex = 29;
            this.label21.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(294, 365);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 18);
            this.label27.TabIndex = 30;
            this.label27.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(294, 328);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 18);
            this.label28.TabIndex = 31;
            this.label28.Text = "-";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(294, 297);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 18);
            this.label29.TabIndex = 32;
            this.label29.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(294, 231);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 18);
            this.label30.TabIndex = 33;
            this.label30.Text = "-";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(294, 648);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 18);
            this.label31.TabIndex = 34;
            this.label31.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(294, 582);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 18);
            this.label32.TabIndex = 35;
            this.label32.Text = "-";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(294, 517);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 18);
            this.label33.TabIndex = 36;
            this.label33.Text = "-";
            // 
            // txtVerde_min
            // 
            this.txtVerde_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerde_min.Location = new System.Drawing.Point(309, 195);
            this.txtVerde_min.MaxLength = 2;
            this.txtVerde_min.Name = "txtVerde_min";
            this.txtVerde_min.Size = new System.Drawing.Size(30, 24);
            this.txtVerde_min.TabIndex = 37;
            // 
            // txtVanas_min
            // 
            this.txtVanas_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanas_min.Location = new System.Drawing.Point(309, 439);
            this.txtVanas_min.MaxLength = 2;
            this.txtVanas_min.Name = "txtVanas_min";
            this.txtVanas_min.Size = new System.Drawing.Size(30, 24);
            this.txtVanas_min.TabIndex = 38;
            // 
            // txtReseca_min
            // 
            this.txtReseca_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReseca_min.Location = new System.Drawing.Point(309, 477);
            this.txtReseca_min.MaxLength = 2;
            this.txtReseca_min.Name = "txtReseca_min";
            this.txtReseca_min.Size = new System.Drawing.Size(30, 24);
            this.txtReseca_min.TabIndex = 39;
            // 
            // txtHongoActivo_min
            // 
            this.txtHongoActivo_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHongoActivo_min.Location = new System.Drawing.Point(309, 514);
            this.txtHongoActivo_min.MaxLength = 2;
            this.txtHongoActivo_min.Name = "txtHongoActivo_min";
            this.txtHongoActivo_min.Size = new System.Drawing.Size(30, 24);
            this.txtHongoActivo_min.TabIndex = 40;
            // 
            // txtExtra_min
            // 
            this.txtExtra_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra_min.Location = new System.Drawing.Point(309, 578);
            this.txtExtra_min.MaxLength = 2;
            this.txtExtra_min.Name = "txtExtra_min";
            this.txtExtra_min.Size = new System.Drawing.Size(30, 24);
            this.txtExtra_min.TabIndex = 41;
            // 
            // txtAmbar_min
            // 
            this.txtAmbar_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmbar_min.Location = new System.Drawing.Point(309, 645);
            this.txtAmbar_min.MaxLength = 2;
            this.txtAmbar_min.Name = "txtAmbar_min";
            this.txtAmbar_min.Size = new System.Drawing.Size(30, 24);
            this.txtAmbar_min.TabIndex = 42;
            // 
            // txtPelon_min
            // 
            this.txtPelon_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelon_min.Location = new System.Drawing.Point(309, 363);
            this.txtPelon_min.MaxLength = 2;
            this.txtPelon_min.Name = "txtPelon_min";
            this.txtPelon_min.Size = new System.Drawing.Size(30, 24);
            this.txtPelon_min.TabIndex = 43;
            // 
            // txtNegra_min
            // 
            this.txtNegra_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegra_min.Location = new System.Drawing.Point(309, 325);
            this.txtNegra_min.MaxLength = 2;
            this.txtNegra_min.Name = "txtNegra_min";
            this.txtNegra_min.Size = new System.Drawing.Size(30, 24);
            this.txtNegra_min.TabIndex = 44;
            // 
            // txtPartidas_min
            // 
            this.txtPartidas_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidas_min.Location = new System.Drawing.Point(309, 294);
            this.txtPartidas_min.MaxLength = 2;
            this.txtPartidas_min.Name = "txtPartidas_min";
            this.txtPartidas_min.Size = new System.Drawing.Size(30, 24);
            this.txtPartidas_min.TabIndex = 45;
            // 
            // txtPalos_min
            // 
            this.txtPalos_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalos_min.Location = new System.Drawing.Point(309, 228);
            this.txtPalos_min.MaxLength = 2;
            this.txtPalos_min.Name = "txtPalos_min";
            this.txtPalos_min.Size = new System.Drawing.Size(30, 24);
            this.txtPalos_min.TabIndex = 46;
            // 
            // txtInsectos_min
            // 
            this.txtInsectos_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsectos_min.Location = new System.Drawing.Point(309, 399);
            this.txtInsectos_min.MaxLength = 2;
            this.txtInsectos_min.Name = "txtInsectos_min";
            this.txtInsectos_min.Size = new System.Drawing.Size(30, 24);
            this.txtInsectos_min.TabIndex = 47;
            // 
            // txtInsectos_max
            // 
            this.txtInsectos_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsectos_max.Location = new System.Drawing.Point(429, 399);
            this.txtInsectos_max.MaxLength = 2;
            this.txtInsectos_max.Name = "txtInsectos_max";
            this.txtInsectos_max.Size = new System.Drawing.Size(30, 24);
            this.txtInsectos_max.TabIndex = 81;
            // 
            // txtPalos_max
            // 
            this.txtPalos_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalos_max.Location = new System.Drawing.Point(429, 228);
            this.txtPalos_max.MaxLength = 2;
            this.txtPalos_max.Name = "txtPalos_max";
            this.txtPalos_max.Size = new System.Drawing.Size(30, 24);
            this.txtPalos_max.TabIndex = 80;
            // 
            // txtPartidas_max
            // 
            this.txtPartidas_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidas_max.Location = new System.Drawing.Point(429, 294);
            this.txtPartidas_max.MaxLength = 2;
            this.txtPartidas_max.Name = "txtPartidas_max";
            this.txtPartidas_max.Size = new System.Drawing.Size(30, 24);
            this.txtPartidas_max.TabIndex = 79;
            // 
            // txtNegra_max
            // 
            this.txtNegra_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegra_max.Location = new System.Drawing.Point(429, 325);
            this.txtNegra_max.MaxLength = 2;
            this.txtNegra_max.Name = "txtNegra_max";
            this.txtNegra_max.Size = new System.Drawing.Size(30, 24);
            this.txtNegra_max.TabIndex = 78;
            // 
            // txtPelon_max
            // 
            this.txtPelon_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelon_max.Location = new System.Drawing.Point(429, 363);
            this.txtPelon_max.MaxLength = 2;
            this.txtPelon_max.Name = "txtPelon_max";
            this.txtPelon_max.Size = new System.Drawing.Size(30, 24);
            this.txtPelon_max.TabIndex = 77;
            // 
            // txtAmbar_max
            // 
            this.txtAmbar_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmbar_max.Location = new System.Drawing.Point(429, 645);
            this.txtAmbar_max.MaxLength = 2;
            this.txtAmbar_max.Name = "txtAmbar_max";
            this.txtAmbar_max.Size = new System.Drawing.Size(30, 24);
            this.txtAmbar_max.TabIndex = 76;
            // 
            // txtExtra_max
            // 
            this.txtExtra_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra_max.Location = new System.Drawing.Point(429, 578);
            this.txtExtra_max.MaxLength = 2;
            this.txtExtra_max.Name = "txtExtra_max";
            this.txtExtra_max.Size = new System.Drawing.Size(30, 24);
            this.txtExtra_max.TabIndex = 75;
            // 
            // txtHongoActivo_max
            // 
            this.txtHongoActivo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHongoActivo_max.Location = new System.Drawing.Point(429, 514);
            this.txtHongoActivo_max.MaxLength = 2;
            this.txtHongoActivo_max.Name = "txtHongoActivo_max";
            this.txtHongoActivo_max.Size = new System.Drawing.Size(30, 24);
            this.txtHongoActivo_max.TabIndex = 74;
            // 
            // txtReseca_max
            // 
            this.txtReseca_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReseca_max.Location = new System.Drawing.Point(429, 477);
            this.txtReseca_max.MaxLength = 2;
            this.txtReseca_max.Name = "txtReseca_max";
            this.txtReseca_max.Size = new System.Drawing.Size(30, 24);
            this.txtReseca_max.TabIndex = 73;
            // 
            // txtVanas_max
            // 
            this.txtVanas_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanas_max.Location = new System.Drawing.Point(429, 439);
            this.txtVanas_max.MaxLength = 2;
            this.txtVanas_max.Name = "txtVanas_max";
            this.txtVanas_max.Size = new System.Drawing.Size(30, 24);
            this.txtVanas_max.TabIndex = 72;
            // 
            // txtAmarillo_max
            // 
            this.txtAmarillo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmarillo_max.Location = new System.Drawing.Point(429, 195);
            this.txtAmarillo_max.MaxLength = 2;
            this.txtAmarillo_max.Name = "txtAmarillo_max";
            this.txtAmarillo_max.Size = new System.Drawing.Size(30, 24);
            this.txtAmarillo_max.TabIndex = 71;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(414, 517);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 18);
            this.label34.TabIndex = 70;
            this.label34.Text = "-";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(414, 582);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 18);
            this.label35.TabIndex = 69;
            this.label35.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(414, 648);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 18);
            this.label36.TabIndex = 68;
            this.label36.Text = "-";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(414, 231);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 18);
            this.label37.TabIndex = 67;
            this.label37.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(414, 297);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 18);
            this.label38.TabIndex = 66;
            this.label38.Text = "-";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(414, 328);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 18);
            this.label39.TabIndex = 65;
            this.label39.Text = "-";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(414, 365);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(13, 18);
            this.label40.TabIndex = 64;
            this.label40.Text = "-";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(410, 480);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(13, 18);
            this.label41.TabIndex = 63;
            this.label41.Text = "-";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(414, 442);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 18);
            this.label42.TabIndex = 62;
            this.label42.Text = "-";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(414, 402);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(13, 18);
            this.label43.TabIndex = 61;
            this.label43.Text = "-";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(414, 198);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 18);
            this.label44.TabIndex = 60;
            this.label44.Text = "-";
            // 
            // lblHongoActivo_min
            // 
            this.lblHongoActivo_min.AutoSize = true;
            this.lblHongoActivo_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHongoActivo_min.Location = new System.Drawing.Point(392, 517);
            this.lblHongoActivo_min.Name = "lblHongoActivo_min";
            this.lblHongoActivo_min.Size = new System.Drawing.Size(16, 18);
            this.lblHongoActivo_min.TabIndex = 59;
            this.lblHongoActivo_min.Text = "0";
            // 
            // lblExtra_min
            // 
            this.lblExtra_min.AutoSize = true;
            this.lblExtra_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra_min.Location = new System.Drawing.Point(392, 581);
            this.lblExtra_min.Name = "lblExtra_min";
            this.lblExtra_min.Size = new System.Drawing.Size(16, 18);
            this.lblExtra_min.TabIndex = 58;
            this.lblExtra_min.Text = "0";
            // 
            // lblAmbar_min
            // 
            this.lblAmbar_min.AutoSize = true;
            this.lblAmbar_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbar_min.Location = new System.Drawing.Point(392, 648);
            this.lblAmbar_min.Name = "lblAmbar_min";
            this.lblAmbar_min.Size = new System.Drawing.Size(16, 18);
            this.lblAmbar_min.TabIndex = 57;
            this.lblAmbar_min.Text = "0";
            // 
            // lblPalo_min
            // 
            this.lblPalo_min.AutoSize = true;
            this.lblPalo_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalo_min.Location = new System.Drawing.Point(392, 232);
            this.lblPalo_min.Name = "lblPalo_min";
            this.lblPalo_min.Size = new System.Drawing.Size(16, 18);
            this.lblPalo_min.TabIndex = 56;
            this.lblPalo_min.Text = "0";
            // 
            // lblPartidas_min
            // 
            this.lblPartidas_min.AutoSize = true;
            this.lblPartidas_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas_min.Location = new System.Drawing.Point(392, 297);
            this.lblPartidas_min.Name = "lblPartidas_min";
            this.lblPartidas_min.Size = new System.Drawing.Size(16, 18);
            this.lblPartidas_min.TabIndex = 55;
            this.lblPartidas_min.Text = "0";
            // 
            // lblNegra_min
            // 
            this.lblNegra_min.AutoSize = true;
            this.lblNegra_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegra_min.Location = new System.Drawing.Point(392, 328);
            this.lblNegra_min.Name = "lblNegra_min";
            this.lblNegra_min.Size = new System.Drawing.Size(16, 18);
            this.lblNegra_min.TabIndex = 54;
            this.lblNegra_min.Text = "0";
            // 
            // lblPelon_min
            // 
            this.lblPelon_min.AutoSize = true;
            this.lblPelon_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelon_min.Location = new System.Drawing.Point(392, 365);
            this.lblPelon_min.Name = "lblPelon_min";
            this.lblPelon_min.Size = new System.Drawing.Size(16, 18);
            this.lblPelon_min.TabIndex = 53;
            this.lblPelon_min.Text = "0";
            // 
            // lblInsectos_min
            // 
            this.lblInsectos_min.AutoSize = true;
            this.lblInsectos_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsectos_min.Location = new System.Drawing.Point(392, 402);
            this.lblInsectos_min.Name = "lblInsectos_min";
            this.lblInsectos_min.Size = new System.Drawing.Size(16, 18);
            this.lblInsectos_min.TabIndex = 52;
            this.lblInsectos_min.Text = "0";
            // 
            // lblVanas_min
            // 
            this.lblVanas_min.AutoSize = true;
            this.lblVanas_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanas_min.Location = new System.Drawing.Point(392, 442);
            this.lblVanas_min.Name = "lblVanas_min";
            this.lblVanas_min.Size = new System.Drawing.Size(16, 18);
            this.lblVanas_min.TabIndex = 51;
            this.lblVanas_min.Text = "0";
            // 
            // lblReseca_min
            // 
            this.lblReseca_min.AutoSize = true;
            this.lblReseca_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReseca_min.Location = new System.Drawing.Point(392, 480);
            this.lblReseca_min.Name = "lblReseca_min";
            this.lblReseca_min.Size = new System.Drawing.Size(16, 18);
            this.lblReseca_min.TabIndex = 50;
            this.lblReseca_min.Text = "0";
            // 
            // lblAmarillo_max
            // 
            this.lblAmarillo_max.AutoSize = true;
            this.lblAmarillo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarillo_max.Location = new System.Drawing.Point(392, 198);
            this.lblAmarillo_max.Name = "lblAmarillo_max";
            this.lblAmarillo_max.Size = new System.Drawing.Size(16, 18);
            this.lblAmarillo_max.TabIndex = 49;
            this.lblAmarillo_max.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(514, 517);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 18);
            this.label56.TabIndex = 103;
            this.label56.Text = ">";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(514, 581);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(17, 18);
            this.label57.TabIndex = 102;
            this.label57.Text = "<";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(510, 648);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(17, 18);
            this.label58.TabIndex = 101;
            this.label58.Text = ">";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(514, 231);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(17, 18);
            this.label59.TabIndex = 100;
            this.label59.Text = ">";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(514, 297);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(17, 18);
            this.label60.TabIndex = 99;
            this.label60.Text = ">";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(514, 328);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(17, 18);
            this.label61.TabIndex = 98;
            this.label61.Text = ">";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(514, 365);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(17, 18);
            this.label62.TabIndex = 97;
            this.label62.Text = ">";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(514, 480);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(17, 18);
            this.label63.TabIndex = 96;
            this.label63.Text = ">";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(514, 442);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 18);
            this.label64.TabIndex = 95;
            this.label64.Text = ">";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(514, 402);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(17, 18);
            this.label65.TabIndex = 94;
            this.label65.Text = ">";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(514, 198);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(17, 18);
            this.label66.TabIndex = 93;
            this.label66.Text = ">";
            // 
            // lblHongoActivo_max
            // 
            this.lblHongoActivo_max.AutoSize = true;
            this.lblHongoActivo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHongoActivo_max.Location = new System.Drawing.Point(533, 517);
            this.lblHongoActivo_max.Name = "lblHongoActivo_max";
            this.lblHongoActivo_max.Size = new System.Drawing.Size(16, 18);
            this.lblHongoActivo_max.TabIndex = 92;
            this.lblHongoActivo_max.Text = "0";
            // 
            // lblExtra_max
            // 
            this.lblExtra_max.AutoSize = true;
            this.lblExtra_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra_max.Location = new System.Drawing.Point(533, 581);
            this.lblExtra_max.Name = "lblExtra_max";
            this.lblExtra_max.Size = new System.Drawing.Size(32, 18);
            this.lblExtra_max.TabIndex = 91;
            this.lblExtra_max.Text = "100";
            // 
            // lblAmbar_max
            // 
            this.lblAmbar_max.AutoSize = true;
            this.lblAmbar_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbar_max.Location = new System.Drawing.Point(533, 648);
            this.lblAmbar_max.Name = "lblAmbar_max";
            this.lblAmbar_max.Size = new System.Drawing.Size(16, 18);
            this.lblAmbar_max.TabIndex = 90;
            this.lblAmbar_max.Text = "0";
            // 
            // lblPalo_max
            // 
            this.lblPalo_max.AutoSize = true;
            this.lblPalo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalo_max.Location = new System.Drawing.Point(533, 231);
            this.lblPalo_max.Name = "lblPalo_max";
            this.lblPalo_max.Size = new System.Drawing.Size(16, 18);
            this.lblPalo_max.TabIndex = 89;
            this.lblPalo_max.Text = "0";
            // 
            // lblPartidas_max
            // 
            this.lblPartidas_max.AutoSize = true;
            this.lblPartidas_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas_max.Location = new System.Drawing.Point(533, 297);
            this.lblPartidas_max.Name = "lblPartidas_max";
            this.lblPartidas_max.Size = new System.Drawing.Size(16, 18);
            this.lblPartidas_max.TabIndex = 88;
            this.lblPartidas_max.Text = "0";
            // 
            // lblNegra_max
            // 
            this.lblNegra_max.AutoSize = true;
            this.lblNegra_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegra_max.Location = new System.Drawing.Point(533, 328);
            this.lblNegra_max.Name = "lblNegra_max";
            this.lblNegra_max.Size = new System.Drawing.Size(16, 18);
            this.lblNegra_max.TabIndex = 87;
            this.lblNegra_max.Text = "0";
            // 
            // lblPelon_max
            // 
            this.lblPelon_max.AutoSize = true;
            this.lblPelon_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelon_max.Location = new System.Drawing.Point(533, 366);
            this.lblPelon_max.Name = "lblPelon_max";
            this.lblPelon_max.Size = new System.Drawing.Size(16, 18);
            this.lblPelon_max.TabIndex = 86;
            this.lblPelon_max.Text = "0";
            // 
            // lblInsectos_max
            // 
            this.lblInsectos_max.AutoSize = true;
            this.lblInsectos_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsectos_max.Location = new System.Drawing.Point(533, 402);
            this.lblInsectos_max.Name = "lblInsectos_max";
            this.lblInsectos_max.Size = new System.Drawing.Size(16, 18);
            this.lblInsectos_max.TabIndex = 85;
            this.lblInsectos_max.Text = "0";
            // 
            // lblVanas_max
            // 
            this.lblVanas_max.AutoSize = true;
            this.lblVanas_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanas_max.Location = new System.Drawing.Point(533, 442);
            this.lblVanas_max.Name = "lblVanas_max";
            this.lblVanas_max.Size = new System.Drawing.Size(16, 18);
            this.lblVanas_max.TabIndex = 84;
            this.lblVanas_max.Text = "0";
            // 
            // lblReseca_max
            // 
            this.lblReseca_max.AutoSize = true;
            this.lblReseca_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReseca_max.Location = new System.Drawing.Point(533, 480);
            this.lblReseca_max.Name = "lblReseca_max";
            this.lblReseca_max.Size = new System.Drawing.Size(16, 18);
            this.lblReseca_max.TabIndex = 83;
            this.lblReseca_max.Text = "0";
            // 
            // LblRojo_max
            // 
            this.LblRojo_max.AutoSize = true;
            this.LblRojo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRojo_max.Location = new System.Drawing.Point(533, 198);
            this.LblRojo_max.Name = "LblRojo_max";
            this.LblRojo_max.Size = new System.Drawing.Size(16, 18);
            this.LblRojo_max.TabIndex = 82;
            this.LblRojo_max.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(281, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 21);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(395, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 21);
            this.panel2.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(501, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 21);
            this.panel3.TabIndex = 106;
            // 
            // CmbVariedad
            // 
            this.CmbVariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVariedad.FormattingEnabled = true;
            this.CmbVariedad.Location = new System.Drawing.Point(231, 112);
            this.CmbVariedad.Name = "CmbVariedad";
            this.CmbVariedad.Size = new System.Drawing.Size(219, 21);
            this.CmbVariedad.TabIndex = 109;
            this.CmbVariedad.SelectedIndexChanged += new System.EventHandler(this.CmbVariedad_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(265, 689);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(162, 34);
            this.btn_modificar.TabIndex = 107;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(514, 263);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(17, 18);
            this.label45.TabIndex = 118;
            this.label45.Text = ">";
            // 
            // LblPelonSuelto_max
            // 
            this.LblPelonSuelto_max.AutoSize = true;
            this.LblPelonSuelto_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPelonSuelto_max.Location = new System.Drawing.Point(533, 263);
            this.LblPelonSuelto_max.Name = "LblPelonSuelto_max";
            this.LblPelonSuelto_max.Size = new System.Drawing.Size(16, 18);
            this.LblPelonSuelto_max.TabIndex = 117;
            this.LblPelonSuelto_max.Text = "0";
            // 
            // txtPelonSuelto_max
            // 
            this.txtPelonSuelto_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelonSuelto_max.Location = new System.Drawing.Point(429, 260);
            this.txtPelonSuelto_max.MaxLength = 2;
            this.txtPelonSuelto_max.Name = "txtPelonSuelto_max";
            this.txtPelonSuelto_max.Size = new System.Drawing.Size(30, 24);
            this.txtPelonSuelto_max.TabIndex = 116;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(414, 263);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(13, 18);
            this.label47.TabIndex = 115;
            this.label47.Text = "-";
            // 
            // LblPelonSuelto_min
            // 
            this.LblPelonSuelto_min.AutoSize = true;
            this.LblPelonSuelto_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPelonSuelto_min.Location = new System.Drawing.Point(392, 264);
            this.LblPelonSuelto_min.Name = "LblPelonSuelto_min";
            this.LblPelonSuelto_min.Size = new System.Drawing.Size(16, 18);
            this.LblPelonSuelto_min.TabIndex = 114;
            this.LblPelonSuelto_min.Text = "0";
            // 
            // txtPelonSuelto_min
            // 
            this.txtPelonSuelto_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelonSuelto_min.Location = new System.Drawing.Point(309, 260);
            this.txtPelonSuelto_min.MaxLength = 2;
            this.txtPelonSuelto_min.Name = "txtPelonSuelto_min";
            this.txtPelonSuelto_min.Size = new System.Drawing.Size(30, 24);
            this.txtPelonSuelto_min.TabIndex = 113;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(294, 263);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(13, 18);
            this.label49.TabIndex = 112;
            this.label49.Text = "-";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(278, 263);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(16, 18);
            this.label50.TabIndex = 111;
            this.label50.Text = "0";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(21, 264);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(177, 18);
            this.label51.TabIndex = 110;
            this.label51.Text = "Impurezas: Pelón Suelto :";
            // 
            // lblLight_max
            // 
            this.lblLight_max.AutoSize = true;
            this.lblLight_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight_max.Location = new System.Drawing.Point(533, 614);
            this.lblLight_max.Name = "lblLight_max";
            this.lblLight_max.Size = new System.Drawing.Size(16, 18);
            this.lblLight_max.TabIndex = 126;
            this.lblLight_max.Text = "0";
            // 
            // txtLight_max
            // 
            this.txtLight_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLight_max.Location = new System.Drawing.Point(429, 611);
            this.txtLight_max.MaxLength = 2;
            this.txtLight_max.Name = "txtLight_max";
            this.txtLight_max.Size = new System.Drawing.Size(30, 24);
            this.txtLight_max.TabIndex = 125;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(414, 614);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(13, 18);
            this.label52.TabIndex = 124;
            this.label52.Text = "-";
            // 
            // lblLight_min
            // 
            this.lblLight_min.AutoSize = true;
            this.lblLight_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight_min.Location = new System.Drawing.Point(392, 614);
            this.lblLight_min.Name = "lblLight_min";
            this.lblLight_min.Size = new System.Drawing.Size(16, 18);
            this.lblLight_min.TabIndex = 123;
            this.lblLight_min.Text = "0";
            // 
            // txtLight_min
            // 
            this.txtLight_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLight_min.Location = new System.Drawing.Point(309, 611);
            this.txtLight_min.MaxLength = 2;
            this.txtLight_min.Name = "txtLight_min";
            this.txtLight_min.Size = new System.Drawing.Size(30, 24);
            this.txtLight_min.TabIndex = 122;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(294, 614);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(13, 18);
            this.label54.TabIndex = 121;
            this.label54.Text = "-";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(262, 614);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 18);
            this.label55.TabIndex = 120;
            this.label55.Text = "100";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(21, 614);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(43, 18);
            this.label67.TabIndex = 119;
            this.label67.Text = "Light:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(514, 549);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(17, 18);
            this.label48.TabIndex = 136;
            this.label48.Text = ">";
            // 
            // lblHongoInactivo_max
            // 
            this.lblHongoInactivo_max.AutoSize = true;
            this.lblHongoInactivo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHongoInactivo_max.Location = new System.Drawing.Point(533, 549);
            this.lblHongoInactivo_max.Name = "lblHongoInactivo_max";
            this.lblHongoInactivo_max.Size = new System.Drawing.Size(16, 18);
            this.lblHongoInactivo_max.TabIndex = 135;
            this.lblHongoInactivo_max.Text = "0";
            // 
            // txtHongoInactivo_max
            // 
            this.txtHongoInactivo_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHongoInactivo_max.Location = new System.Drawing.Point(429, 546);
            this.txtHongoInactivo_max.MaxLength = 2;
            this.txtHongoInactivo_max.Name = "txtHongoInactivo_max";
            this.txtHongoInactivo_max.Size = new System.Drawing.Size(30, 24);
            this.txtHongoInactivo_max.TabIndex = 134;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(414, 549);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(13, 18);
            this.label68.TabIndex = 133;
            this.label68.Text = "-";
            // 
            // lblHongoInactivo_min
            // 
            this.lblHongoInactivo_min.AutoSize = true;
            this.lblHongoInactivo_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHongoInactivo_min.Location = new System.Drawing.Point(392, 549);
            this.lblHongoInactivo_min.Name = "lblHongoInactivo_min";
            this.lblHongoInactivo_min.Size = new System.Drawing.Size(16, 18);
            this.lblHongoInactivo_min.TabIndex = 132;
            this.lblHongoInactivo_min.Text = "0";
            // 
            // txtHongoInactivo_min
            // 
            this.txtHongoInactivo_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHongoInactivo_min.Location = new System.Drawing.Point(309, 546);
            this.txtHongoInactivo_min.MaxLength = 2;
            this.txtHongoInactivo_min.Name = "txtHongoInactivo_min";
            this.txtHongoInactivo_min.Size = new System.Drawing.Size(30, 24);
            this.txtHongoInactivo_min.TabIndex = 131;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(294, 549);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(13, 18);
            this.label70.TabIndex = 130;
            this.label70.Text = "-";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(278, 549);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(16, 18);
            this.label71.TabIndex = 129;
            this.label71.Text = "0";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(21, 549);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(119, 18);
            this.label72.TabIndex = 128;
            this.label72.Text = "Hongo  Inactivo :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(514, 614);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(17, 18);
            this.label46.TabIndex = 137;
            this.label46.Text = "<";
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(665, 735);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.lblHongoInactivo_max);
            this.Controls.Add(this.txtHongoInactivo_max);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.lblHongoInactivo_min);
            this.Controls.Add(this.txtHongoInactivo_min);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.lblLight_max);
            this.Controls.Add(this.txtLight_max);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.lblLight_min);
            this.Controls.Add(this.txtLight_min);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.LblPelonSuelto_max);
            this.Controls.Add(this.txtPelonSuelto_max);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.LblPelonSuelto_min);
            this.Controls.Add(this.txtPelonSuelto_min);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.CmbVariedad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.lblHongoActivo_max);
            this.Controls.Add(this.lblExtra_max);
            this.Controls.Add(this.lblAmbar_max);
            this.Controls.Add(this.lblPalo_max);
            this.Controls.Add(this.lblPartidas_max);
            this.Controls.Add(this.lblNegra_max);
            this.Controls.Add(this.lblPelon_max);
            this.Controls.Add(this.lblInsectos_max);
            this.Controls.Add(this.lblVanas_max);
            this.Controls.Add(this.lblReseca_max);
            this.Controls.Add(this.LblRojo_max);
            this.Controls.Add(this.txtInsectos_max);
            this.Controls.Add(this.txtPalos_max);
            this.Controls.Add(this.txtPartidas_max);
            this.Controls.Add(this.txtNegra_max);
            this.Controls.Add(this.txtPelon_max);
            this.Controls.Add(this.txtAmbar_max);
            this.Controls.Add(this.txtExtra_max);
            this.Controls.Add(this.txtHongoActivo_max);
            this.Controls.Add(this.txtReseca_max);
            this.Controls.Add(this.txtVanas_max);
            this.Controls.Add(this.txtAmarillo_max);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.lblHongoActivo_min);
            this.Controls.Add(this.lblExtra_min);
            this.Controls.Add(this.lblAmbar_min);
            this.Controls.Add(this.lblPalo_min);
            this.Controls.Add(this.lblPartidas_min);
            this.Controls.Add(this.lblNegra_min);
            this.Controls.Add(this.lblPelon_min);
            this.Controls.Add(this.lblInsectos_min);
            this.Controls.Add(this.lblVanas_min);
            this.Controls.Add(this.lblReseca_min);
            this.Controls.Add(this.lblAmarillo_max);
            this.Controls.Add(this.txtInsectos_min);
            this.Controls.Add(this.txtPalos_min);
            this.Controls.Add(this.txtPartidas_min);
            this.Controls.Add(this.txtNegra_min);
            this.Controls.Add(this.txtPelon_min);
            this.Controls.Add(this.txtAmbar_min);
            this.Controls.Add(this.txtExtra_min);
            this.Controls.Add(this.txtHongoActivo_min);
            this.Controls.Add(this.txtReseca_min);
            this.Controls.Add(this.txtVanas_min);
            this.Controls.Add(this.txtVerde_min);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormEvaluacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion";
            this.Load += new System.EventHandler(this.FormEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public void traer_datos()
		{
			this.extraerMedicion("Impurezas_Piedras",Variedad_2);
			this.txtVerde_min.Text = this.min;
			int num = Convert.ToInt32(this.min) + 1;
			this.lblAmarillo_max.Text = num.ToString();
			this.txtAmarillo_max.Text = this.max;
			num = Convert.ToInt32(this.max);
			this.LblRojo_max.Text = num.ToString();
			this.extraerMedicion("Impurezas_Palo", Variedad_2);
			this.txtPalos_min.Text = this.min;
			this.txtPalos_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblPalo_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblPalo_max.Text = num.ToString();
            this.extraerMedicion("Impurezas_Pelon", Variedad_2);
            txtPelonSuelto_min.Text = this.min;
            txtPelonSuelto_max.Text = this.max;
            num = Convert.ToInt32(this.min) + 1;
            LblPelonSuelto_min.Text = num.ToString();
            num = Convert.ToInt32(this.max) ;
            LblPelonSuelto_max.Text = num.ToString();
            this.extraerMedicion("Partidas_Quebradas", Variedad_2);
			this.txtPartidas_min.Text = this.min;
			this.txtPartidas_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblPartidas_min.Text = num.ToString();
			num = Convert.ToInt32(this.max) ;
			this.lblPartidas_max.Text = num.ToString();
			this.extraerMedicion("Negras_Momificadas", Variedad_2);
			this.txtNegra_min.Text = this.min;
			this.txtNegra_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblNegra_min.Text = num.ToString();
			num = Convert.ToInt32(this.max) ;
			this.lblNegra_max.Text = num.ToString();
			this.extraerMedicion("Pelon_Adherido", Variedad_2);
			this.txtPelon_min.Text = this.min;
			this.txtPelon_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblPelon_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblPelon_max.Text = num.ToString();
			this.extraerMedicion("Daño_Insectos", Variedad_2);
			this.txtInsectos_min.Text = this.min;
			this.txtInsectos_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblInsectos_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblInsectos_max.Text = num.ToString();
			this.extraerMedicion("Vanas", Variedad_2);
			this.txtVanas_min.Text = this.min;
			this.txtVanas_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblVanas_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblVanas_max.Text = num.ToString();
			this.extraerMedicion("Reseca", Variedad_2);
			this.txtReseca_min.Text = this.min;
			this.txtReseca_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblReseca_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblReseca_max.Text = num.ToString();
			this.extraerMedicion("Hongo_Activo", Variedad_2);
			this.txtHongoActivo_min.Text = this.min;
			this.txtHongoActivo_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblHongoActivo_min.Text = num.ToString();
			num = Convert.ToInt32(this.max);
			this.lblHongoActivo_max.Text = num.ToString();
            this.extraerMedicion("Hongo_Inactivo", Variedad_2);
            this.txtHongoInactivo_min.Text = this.min;
            this.txtHongoInactivo_max.Text = this.max;
            num = Convert.ToInt32(this.min) + 1;
            this.lblHongoInactivo_min.Text = num.ToString();
            num = Convert.ToInt32(this.max);
            this.lblHongoInactivo_max.Text = num.ToString();
            this.extraerMedicion("Ambar_Amarillo", Variedad_2);
			this.txtAmbar_min.Text = this.min;
			this.txtAmbar_max.Text = this.max;
			num = Convert.ToInt32(this.min) + 1;
			this.lblAmbar_min.Text = num.ToString();
			num = Convert.ToInt32(this.max) ;
			this.lblAmbar_max.Text = num.ToString();
			this.extraerMedicion("Extra_Light", Variedad_2);
			this.txtExtra_min.Text = this.min;
			this.txtExtra_max.Text = this.max;
            if((min == "0")&&(max == "0"))
            {
                min = "1";
                max = "1";
            }
			num = Convert.ToInt32(this.min) - 1;
			this.lblExtra_min.Text = num.ToString();
			num = Convert.ToInt32(this.max) ;
			this.lblExtra_max.Text = num.ToString();
            this.extraerMedicion("Light", Variedad_2);
            this.txtLight_min.Text = this.min;
            this.txtLight_max.Text = this.max;
            if ((min == "0") && (max == "0"))
            {
                min = "1";
                max = "1";
            }
            num = Convert.ToInt32(this.min) - 1;
            this.lblLight_min.Text = num.ToString();
            num = Convert.ToInt32(this.max);
            this.lblLight_max.Text = num.ToString();
        }

		public void update_parametro(int verde_max, int amarillo_max, string parametro)
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("UpdateEvaluacion", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Verde_max", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Amarillo_max", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Parametro", SqlDbType.Text);
                    sqlCommand.Parameters.Add("@Variedad", SqlDbType.Text);
                    sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Verde_max"].Value = verde_max;
					sqlCommand.Parameters["@Amarillo_max"].Value = amarillo_max;
					sqlCommand.Parameters["@Parametro"].Value = parametro;
                    sqlCommand.Parameters["@Variedad"].Value = CmbVariedad.SelectedValue.ToString();
                    sqlCommand.Parameters["@msg"].Value = 1;
					this.cn.Abrir();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error SQL ", exception), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			finally
			{
				this.cn.Cerrar();
			}
		}

        private void analisis_ExternoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analisis_ExternoBindingSource.EndEdit();


        }

        private void CmbVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbVariedad.SelectedIndex != 0)
            { 
               Variedad_2 = CmbVariedad.Text;
               traer_datos();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}