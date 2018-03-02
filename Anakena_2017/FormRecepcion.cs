
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormRecepcion : Form
	{
		private IContainer components = null;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private Label label13;

		private Label label16;

		private Label label9;

		private Label label10;

		private Label label12;

		private Label label14;

		private Label label15;

		private Label label17;

		private Label label18;

		private Label label19;

		private Label label20;

		private Label label11;

		private Label label21;

		private Label label22;

		private Label label23;

		private Label label24;

		private Label label25;

		private Label label26;

		private Label label27;

		private GroupBox groupBox6;

		private Label Lbl_Pelon;

		private Label label34;

		private GroupBox groupBox7;

		private Label lbl_condiciones;

		private Label label29;

		private Label label30;

		private Label label40;

		private Label label39;

		private Label label38;

		private Label label37;

		private Label label36;

		private Label label35;

		private Label label32;

		private Label label31;

		private Label label41;

		private Label label47;

		private Label label46;

		private Label label45;

		private Label label44;

		private Label label43;

		private Label label42;

		private Label label49;

		private Label label48;

		private PictureBox pictureBox1;

		private Label label33;

		private Label label50;

		public TextBox Txt_Lote;

		public GroupBox groupBox1;

		public TextBox Txt_Quebrados;

		public GroupBox groupBox2;

		public Label Lbl_Analisis;

		public ComboBox cmbVariedad;

		public Button Btn_Guardar;

		public TextBox TxtTotalExterno;

		public TextBox Txt_TotalInterno;

		public ComboBox CmbRecepcion;

		public TextBox Txt_ProductorName;

		public TextBox Txt_Productor;

		public DateTimePicker DT_Analisis;

		public DateTimePicker DT_Recepcion;

		public ComboBox CmbPatio;

		public Button button2;

		public TextBox TxtDañados;

		public TextBox Txt_Palos;

		public TextBox Txt_Piedras;

		public TextBox Txt_Negras;

		public TextBox Txt_Cerrado;

		public TextBox Txt_Partidas;

		public TextBox Txt_Adherido;

		public TextBox Txt_Resquebrajado;

		public TextBox Txt_Nuez;

		public TextBox Txt_Ambar;

		public TextBox Txt_LightAmbar;

		public TextBox Txt_Reseca;

		public TextBox Txt_Vanas;

		public TextBox Txt_Extra;

		public TextBox Txt_HongoActivo;

		public TextBox Txt_Daño;

		public TextBox Txt_Light;

		public GroupBox groupBox3;

		public GroupBox groupBox4;

		public GroupBox groupBox5;

		public Label label51;

		public Button Btn_Print;

		public Button button8;

		public Button Btn_Delete;

		public Button Btn_Modificar;

		private Button Btn_Salir;

		public GroupBox groupBox9;

		public GroupBox groupBox10;

		public Button button6;

		private LinkLabel linkLabel1;

		public Button BtnUpdate;

		public TextBox TxtCantidadAnakena;

		public TextBox TxtCantidadProductor;

		private Label label28;

		private Label label52;

		public TextBox Txt_Observaciones;

		private Timer timer1;

		private conexion cn = new conexion();

		private string ultimo = "";

		private string ultimo_Analisis = "";

		private string min = "";

		private string max = "";

		public string usuario = "";
        private Label label53;
        public TextBox Txt_Pelon;
        private Label label54;
        private Label label55;
        public TextBox Txt_HongoInactivo;
        private Label label56;
        public int ACCESSO = 0;

		public FormRecepcion()
		{
			this.InitializeComponent();
		}

		public void agregar_AnalisisExterno()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregarAnalisisExterno", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Partidas_Quebradas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Sin_Pelon", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Pelon_Resquebrajado", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Partidas_Cerrado", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Negras_Momificadas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Pelon_Adherido", SqlDbType.Int);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Partidas_Quebradas"].Value = Convert.ToInt32(this.Txt_Partidas.Text);
					sqlCommand.Parameters["@Sin_Pelon"].Value = Convert.ToInt32(this.Txt_Nuez.Text);
					sqlCommand.Parameters["@Pelon_Resquebrajado"].Value = Convert.ToInt32(this.Txt_Resquebrajado.Text);
					sqlCommand.Parameters["@Partidas_Cerrado"].Value = Convert.ToInt32(this.Txt_Cerrado.Text);
					sqlCommand.Parameters["@Negras_Momificadas"].Value = Convert.ToInt32(this.Txt_Negras.Text);
					sqlCommand.Parameters["@Pelon_Adherido"].Value = Convert.ToInt32(this.Txt_Adherido.Text);
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

		public void agregar_AnalisisInterno()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregarAnalisisInterno", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Daño_Insectos", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Vanas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Reseca", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Hongo_Activo", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Extra_Light", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Light", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Light_Ambar", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Ambar_Amarillo", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Observaciones", SqlDbType.Text);
                    sqlCommand.Parameters.Add("@Hongo_Inactivo", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Daño_Insectos"].Value = Convert.ToInt32(this.Txt_Daño.Text);
					sqlCommand.Parameters["@Vanas"].Value = Convert.ToInt32(this.Txt_Vanas.Text);
					sqlCommand.Parameters["@Reseca"].Value = Convert.ToInt32(this.Txt_Reseca.Text);
					sqlCommand.Parameters["@Hongo_Activo"].Value = Convert.ToInt32(this.Txt_HongoActivo.Text);
					sqlCommand.Parameters["@Extra_Light"].Value = Convert.ToInt32(this.Txt_Extra.Text);
					sqlCommand.Parameters["@Light"].Value = Convert.ToInt32(this.Txt_Light.Text);
					sqlCommand.Parameters["@Light_Ambar"].Value = Convert.ToInt32(this.Txt_LightAmbar.Text);
					sqlCommand.Parameters["@Ambar_Amarillo"].Value = Convert.ToInt32(this.Txt_Ambar.Text);
					sqlCommand.Parameters["@Observaciones"].Value = this.Txt_Observaciones.Text;
                    sqlCommand.Parameters["@Hongo_Inactivo"].Value = Convert.ToInt32(this.Txt_HongoInactivo.Text);
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

		public void agregar_encabezado()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregarEncabezado", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
                    sqlCommand.Parameters.Add("@Analisis", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Lote", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Variedad", SqlDbType.Char, 2);
					sqlCommand.Parameters.Add("@Productor", SqlDbType.Char, 10);
					sqlCommand.Parameters.Add("@Patio", SqlDbType.Text);
					sqlCommand.Parameters.Add("@Fecha_Recepcion", SqlDbType.Date);
					sqlCommand.Parameters.Add("@Fecha_Analisis", SqlDbType.Date);
					sqlCommand.Parameters.Add("@Tipo_Recepcion", SqlDbType.Text);
					sqlCommand.Parameters.Add("@Rut", SqlDbType.VarChar, 40);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    sqlCommand.Parameters["@Analisis"].Value = Lbl_Analisis.Text;
                    sqlCommand.Parameters["@Lote"].Value = this.Txt_Lote.Text;
					sqlCommand.Parameters["@Variedad"].Value = this.cmbVariedad.SelectedValue.ToString();
					sqlCommand.Parameters["@Productor"].Value = this.Txt_Productor.Text;
					sqlCommand.Parameters["@Patio"].Value = this.CmbPatio.Text;
					sqlCommand.Parameters["@Fecha_Recepcion"].Value = this.DT_Recepcion.Value;
					sqlCommand.Parameters["@Fecha_Analisis"].Value = this.DT_Analisis.Value;
					sqlCommand.Parameters["@Tipo_Recepcion"].Value = this.CmbRecepcion.Text;
					sqlCommand.Parameters["@Rut"].Value = this.usuario;
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

		public void agregar_envases()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregarEnvases", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Quebrados", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Dañados", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Productor", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Rut", SqlDbType.VarChar, 40);
					sqlCommand.Parameters.Add("@Condicion", SqlDbType.Text);                  
                    sqlCommand.Parameters.Add("@Anakena", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Condicion_Productor", SqlDbType.Text);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Quebrados"].Value = Convert.ToInt32(this.Txt_Quebrados.Text);
					sqlCommand.Parameters["@Dañados"].Value = Convert.ToInt32(this.TxtDañados.Text);
					sqlCommand.Parameters["@Productor"].Value = Convert.ToInt32(this.TxtCantidadProductor.Text);
					sqlCommand.Parameters["@Rut"].Value = this.usuario;
					sqlCommand.Parameters["@Condicion"].Value = this.lbl_condiciones.Text;
					sqlCommand.Parameters["@Anakena"].Value = Convert.ToInt32(this.TxtCantidadAnakena.Text);
                    sqlCommand.Parameters["@Condicion_Productor"].Value = evaluacion2();
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

		public void agregar_inpurezas()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregarInpurezas", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Piedra", SqlDbType.Float);
					sqlCommand.Parameters.Add("@Palo", SqlDbType.Float);
                    sqlCommand.Parameters.Add("@Pelon", SqlDbType.Float);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Piedra"].Value = Convert.ToDouble(this.Txt_Piedras.Text, CultureInfo.InvariantCulture);
					sqlCommand.Parameters["@Palo"].Value = Convert.ToDouble(this.Txt_Palos.Text, CultureInfo.InvariantCulture);
                    sqlCommand.Parameters["@Pelon"].Value = Convert.ToDouble(Txt_Pelon.Text, CultureInfo.InvariantCulture);
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

		private void Btn_Delete_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar analisis?", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult != System.Windows.Forms.DialogResult.Cancel)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					this.eliminar_recepcion();
					base.Close();
				}
			}
		}

		private void Btn_Modificar_Click(object sender, EventArgs e)
		{
            switch (MessageBox.Show("Desea actualizar la evaluacion de parametros?", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    {
                        this.evaluacion();
                        base.Close();
                        break;
                    }
            }
            int num = Convert.ToInt32(this.Txt_Partidas.Text) + Convert.ToInt32(this.Txt_Nuez.Text) + Convert.ToInt32(this.Txt_Resquebrajado.Text) + Convert.ToInt32(this.Txt_Cerrado.Text) + Convert.ToInt32(this.Txt_Negras.Text);
            int num1 = Convert.ToInt32(this.Txt_Daño.Text) + Convert.ToInt32(this.Txt_Vanas.Text) + Convert.ToInt32(this.Txt_Reseca.Text) + Convert.ToInt32(this.Txt_HongoActivo.Text) + Convert.ToInt32(this.Txt_HongoInactivo.Text) + Convert.ToInt32(this.Txt_Extra.Text) + Convert.ToInt32(this.Txt_Light.Text) + Convert.ToInt32(this.Txt_LightAmbar.Text) + Convert.ToInt32(this.Txt_Ambar.Text);
            if ((num != 100 ? true : num1 != 100))
            {
                MessageBox.Show("compruebe que los analisis externos o internos sumen 100%", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                this.update_encabezado();
                this.update_envases();
                this.update_inpurezas();
                this.update_AnalisisExterno();
                this.update_AnalisisInterno();
                MessageBox.Show("Datos modificados correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                base.Close();
            }
        }

		private void Btn_Print_Click(object sender, EventArgs e)
		{
		}

		private void Btn_Print_Click_1(object sender, EventArgs e)
		{
            FormReport s = new FormReport(Convert.ToInt32(Lbl_Analisis.Text), lbl_condiciones.Text);
            s.ShowDialog();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.evaluacion();
			this.agregar_inpurezas();
			this.agregar_envases();
			this.agregar_AnalisisExterno();
			this.agregar_AnalisisInterno();
			MessageBox.Show("Datos Ingresados correctacmente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.Btn_Guardar.Enabled = false;
			this.Btn_Print.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if ((!(this.Txt_Lote.Text != "") || this.CmbRecepcion.SelectedIndex == 0 || this.cmbVariedad.SelectedIndex == 0 || !(this.Txt_Productor.Text != "") ? true : this.CmbPatio.SelectedIndex == 0))
				{
					MessageBox.Show("Debe seleccion todos los campos solicitados", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.timer1.Enabled = false;
					this.agregar_encabezado();
					this.groupBox2.Enabled = true;
					this.Txt_Quebrados.Focus();
					this.groupBox1.Enabled = false;
					MessageBox.Show("Lote ingresado correctacmente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch
			{
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("Esta seguro que desea salir", "Anakena", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
			{
				case System.Windows.Forms.DialogResult.OK:
				{
					base.Close();
					break;
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (this.groupBox10.Visible)
			{
				this.CmbVariedad();
                cmbVariedad.Enabled = true;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{

            FormEvaluacion s = new FormEvaluacion(cmbVariedad.Text);
            s.btn_modificar.Visible = false;
            s.CmbVariedad.Visible = false;
            s.ShowDialog();

        }

		private void button7_Click(object sender, EventArgs e)
		{
            switch (MessageBox.Show("Esta seguro que desea salir", "Anakena", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.OK:
                    {
                        this.Close();
                        break;
                    }
            }
        }

		private void button8_Click(object sender, EventArgs e)
		{
            FormReport s = new FormReport(Convert.ToInt32(Lbl_Analisis.Text),lbl_condiciones.Text);
            s.ShowDialog();
		}

		private void CmbPatio_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.CmbPatio.Text != "--Seleccione Opcion--")
			{
				this.DT_Recepcion.Enabled = true;
				this.DT_Analisis.Enabled = true;
				this.button2.Enabled = true;
			}
		}

		private void CmbRecepcion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.CmbRecepcion.Text != "--Seleccione Opcion--")
			{
				this.cmbVariedad.Enabled = true;
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
					this.cmbVariedad.Refresh();
					this.cmbVariedad.DataSource = dataSet.Tables["Variedad"].DefaultView;
					this.cmbVariedad.DisplayMember = "Des_Variedad";
					this.cmbVariedad.ValueMember = "Cod_Variedad";
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

		private void cmbVariedad_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void cmbVariedad_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		private void cmbVariedad_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((this.cmbVariedad.SelectedIndex == 0 ? false : this.groupBox9.Visible))
			{
				this.Txt_Productor.Enabled = true;
				this.Txt_Productor.Focus();
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

		public void eliminar_recepcion()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spDeleteRecepcion", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar);
					sqlCommand.Parameters["@Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@msg"].Value = 1;
					this.cn.Abrir();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
					MessageBox.Show("Nº Analisis eliminado correctamente ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		public void evaluacion()
		{
			this.extraerMedicion("Impurezas_Piedras");
			int num = 0;
			if (Convert.ToDouble(this.Txt_Piedras.Text) <= (double)Convert.ToInt32(this.min))
			{
				num = 1;
			}
			else if (Convert.ToDouble(this.Txt_Piedras.Text) <= (double)Convert.ToInt32(this.max))
			{
				num = 2;
			}
			else if (Convert.ToDouble(this.Txt_Piedras.Text) > (double)Convert.ToInt32(this.max))
			{
				num = 3;
			}
			this.extraerMedicion("Impurezas_Palo");
			int num1 = 0;
			if (Convert.ToDouble(this.Txt_Palos.Text) <= (double)Convert.ToInt32(this.min))
			{
				num1 = 1;
			}
			else if (Convert.ToDouble(this.Txt_Palos.Text) <= (double)Convert.ToInt32(this.max))
			{
				num1 = 2;
			}
			else if (Convert.ToDouble(this.Txt_Palos.Text) > (double)Convert.ToInt32(this.max))
			{
				num1 = 3;
			}
            this.extraerMedicion("Impurezas_Pelon");
            int num16 = 0;
            if (Convert.ToDouble(Txt_Pelon.Text) <= (double)Convert.ToInt32(this.min))
            {
                num16 = 1;
            }
            else if (Convert.ToDouble(Txt_Pelon.Text) <= (double)Convert.ToInt32(this.max))
            {
                num16 = 2;
            }
            else if (Convert.ToDouble(Txt_Pelon.Text) > (double)Convert.ToInt32(this.max))
            {
                num16 = 3;
            }
            int num2 = 0;
			num2 = (num <= num1 ? num1 : num);

            if(num2 < num16)
            {
                num2 = num16;
            }



			this.extraerMedicion("Partidas_Quebradas");
			int num3 = 0;
			if (Convert.ToInt32(this.Txt_Partidas.Text) <= Convert.ToInt32(this.min))
			{
				num3 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Partidas.Text) <= Convert.ToInt32(this.max))
			{
				num3 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Partidas.Text) > Convert.ToInt32(this.max))
			{
				num3 = 3;
			}
			this.extraerMedicion("Negras_Momificadas");
			int num4 = 0;
			if (Convert.ToInt32(this.Txt_Negras.Text) <= Convert.ToInt32(this.min))
			{
				num4 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Negras.Text) <= Convert.ToInt32(this.max))
			{
				num4 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Negras.Text) > Convert.ToInt32(this.max))
			{
				num4 = 3;
			}
			int num5 = 0;
			num5 = (num3 <= num4 ? num4 : num3);
			this.extraerMedicion("Pelon_Adherido");
			int num6 = 0;
			if (Convert.ToInt32(this.Txt_Adherido.Text) <= Convert.ToInt32(this.min))
			{
				num6 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Adherido.Text) <= Convert.ToInt32(this.max))
			{
				num6 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Adherido.Text) > Convert.ToInt32(this.max))
			{
				num6 = 3;
			}
			if (num5 < num6)
			{
				num5 = num6;
			}
			this.extraerMedicion("Daño_Insectos");
			int num7 = 0;
			if (Convert.ToInt32(this.Txt_Daño.Text) <= Convert.ToInt32(this.min))
			{
				num7 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Daño.Text) <= Convert.ToInt32(this.max))
			{
				num7 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Daño.Text) > Convert.ToInt32(this.max))
			{
				num7 = 3;
			}
			this.extraerMedicion("Vanas");
			int num8 = 0;
			if (Convert.ToInt32(this.Txt_Vanas.Text) <= Convert.ToInt32(this.min))
			{
				num8 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Vanas.Text) <= Convert.ToInt32(this.max))
			{
				num8 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Vanas.Text) > Convert.ToInt32(this.max))
			{
				num8 = 3;
			}
			int num9 = 0;
			num9 = (num7 <= num8 ? num8 : num7);
			this.extraerMedicion("Reseca");
			int num10 = 0;
			if (Convert.ToInt32(this.Txt_Reseca.Text) <= Convert.ToInt32(this.min))
			{
				num10 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Reseca.Text) <= Convert.ToInt32(this.max))
			{
				num10 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Reseca.Text) > Convert.ToInt32(this.max))
			{
				num10 = 3;
			}
			if (num9 < num10)
			{
				num9 = num10;
			}
			this.extraerMedicion("Hongo_Activo");
			int num11 = 0;
			if (Convert.ToInt32(this.Txt_HongoActivo.Text) <= Convert.ToInt32(this.min))
			{
				num11 = 1;
			}
			else if (Convert.ToInt32(this.Txt_HongoActivo.Text) <= Convert.ToInt32(this.max))
			{
				num11 = 2;
			}
			else if (Convert.ToInt32(this.Txt_HongoActivo.Text) > Convert.ToInt32(this.max))
			{
				num11 = 3;
			}
			if (num9 < num11)
			{
				num9 = num11;
			}
            this.extraerMedicion("Hongo_Inactivo");
            int num15 = 0;
            if (Convert.ToInt32(this.Txt_HongoInactivo.Text) <= Convert.ToInt32(this.min))
            {
                num15 = 1;
            }
            else if (Convert.ToInt32(this.Txt_HongoInactivo.Text) <= Convert.ToInt32(this.max))
            {
                num15 = 2;
            }
            else if (Convert.ToInt32(this.Txt_HongoInactivo.Text) > Convert.ToInt32(this.max))
            {
                num15 = 3;
            }
            if (num9 < num15)
            {
                num9 = num15;
            }
            this.extraerMedicion("Ambar_Amarillo");
			int num12 = 0;
			if (Convert.ToInt32(this.Txt_Ambar.Text) <= Convert.ToInt32(this.min))
			{
				num12 = 1;
			}
			else if (Convert.ToInt32(this.Txt_Ambar.Text) <= Convert.ToInt32(this.max))
			{
				num12 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Ambar.Text) > Convert.ToInt32(this.max))
			{
				num12 = 3;
			}
			if (num9 < num12)
			{
				num9 = num12;
			}
			this.extraerMedicion("Extra_Light");
            //if((min != "0")&&(max != "0"))
            //{ 
			int num13 = 0;
			if (!(Convert.ToInt32(this.Txt_Extra.Text) < Convert.ToInt32(this.min) ? true : Convert.ToInt32(this.Txt_Extra.Text) > 100))
			{
				num13 = 1;
			}
			else if (!(Convert.ToInt32(this.Txt_Extra.Text) < Convert.ToInt32(this.max) ? true : Convert.ToInt32(this.Txt_Extra.Text) >= Convert.ToInt32(this.min)))
			{
				num13 = 2;
			}
			else if (Convert.ToInt32(this.Txt_Extra.Text) < Convert.ToInt32(this.max))
			{
				num13 = 3;
			}
			if (num9 < num13)
			{
				num9 = num13;
			}
            //}
            //else
            //{
                this.extraerMedicion("Light");
                int num14 = 0;
                if (!(Convert.ToInt32(Txt_Light.Text) < Convert.ToInt32(this.min) ? true : Convert.ToInt32(Txt_Light.Text) > 100))
                {
                    num14 = 1;
                }
                else if (!(Convert.ToInt32(Txt_Light.Text) < Convert.ToInt32(this.max) ? true : Convert.ToInt32(Txt_Light.Text) >= Convert.ToInt32(this.min)))
                {
                    num14 = 2;
                }
                else if (Convert.ToInt32(Txt_Light.Text) < Convert.ToInt32(this.max))
                {
                    num14 = 3;
                }
                if (num9 < num14)
                {
                    num9 = num14;
                }

            //}

			if (!(num9 == 3 || num5 == 3 ? false : num2 != 3))
			{
				this.lbl_condiciones.Text = "ROJO";
				this.lbl_condiciones.ForeColor = Color.Red;
			}
			else if ((num9 == 2 || num5 == 2 ? true : num2 == 2))
			{
				this.lbl_condiciones.Text = "AMARILLO";
				this.lbl_condiciones.ForeColor = Color.Yellow;
			}
			if ((num9 != 1 || num5 != 1 ? false : num2 == 1))
			{
				this.lbl_condiciones.Text = "VERDE";
				this.lbl_condiciones.ForeColor = Color.Green;
			}
		}
        public string evaluacion2()
        {
            string evaluacion_productor = "";
            this.extraerMedicion("Impurezas_Piedras");
            int num = 0;
            if (Convert.ToDouble(this.Txt_Piedras.Text) <= (double)Convert.ToInt32(this.min))
            {
                num = 1;
            }
            else if (Convert.ToDouble(this.Txt_Piedras.Text) <= (double)Convert.ToInt32(this.max))
            {
                num = 2;
            }
            else if (Convert.ToDouble(this.Txt_Piedras.Text) > (double)Convert.ToInt32(this.max))
            {
                num = 3;
            }
            this.extraerMedicion("Impurezas_Palo");
            int num1 = 0;
            if (Convert.ToDouble(this.Txt_Palos.Text) <= (double)Convert.ToInt32(this.min))
            {
                num1 = 1;
            }
            else if (Convert.ToDouble(this.Txt_Palos.Text) <= (double)Convert.ToInt32(this.max))
            {
                num1 = 2;
            }
            else if (Convert.ToDouble(this.Txt_Palos.Text) > (double)Convert.ToInt32(this.max))
            {
                num1 = 3;
            }
            this.extraerMedicion("Impurezas_Pelon");
            int num16 = 0;
            if (Convert.ToDouble(Txt_Pelon.Text) <= (double)Convert.ToInt32(this.min))
            {
                num16 = 1;
            }
            else if (Convert.ToDouble(Txt_Pelon.Text) <= (double)Convert.ToInt32(this.max))
            {
                num16 = 2;
            }
            else if (Convert.ToDouble(Txt_Pelon.Text) > (double)Convert.ToInt32(this.max))
            {
                num16 = 3;
            }
            int num2 = 0;
            num2 = (num <= num1 ? num1 : num);

            if (num2 < num16)
            {
                num2 = num16;
            }
            
            this.extraerMedicion("Negras_Momificadas");
            int num4 = 0;
            if (Convert.ToInt32(this.Txt_Negras.Text) <= Convert.ToInt32(this.min))
            {
                num4 = 1;
            }
            else if (Convert.ToInt32(this.Txt_Negras.Text) <= Convert.ToInt32(this.max))
            {
                num4 = 2;
            }
            else if (Convert.ToInt32(this.Txt_Negras.Text) > Convert.ToInt32(this.max))
            {
                num4 = 3;
            }
            this.extraerMedicion("Pelon_Adherido");
            int num6 = 0;
            if (Convert.ToInt32(this.Txt_Adherido.Text) <= Convert.ToInt32(this.min))
            {
                num6 = 1;
            }
            else if (Convert.ToInt32(this.Txt_Adherido.Text) <= Convert.ToInt32(this.max))
            {
                num6 = 2;
            }
            else if (Convert.ToInt32(this.Txt_Adherido.Text) > Convert.ToInt32(this.max))
            {
                num6 = 3;
            }
            if (num4 < num6)
            {
                num4 = num6;
            }
            if (num2 == 3 || num4 == 3 )
            {
                evaluacion_productor = "ROJO";
            
            }
            else if (num2 == 2 || num4 == 2 )
            {
                evaluacion_productor = "AMARILLO";
           
            }
            if (num2 == 1 && num4 == 1)
            {
                evaluacion_productor = "VERDE";
        
            }
            return evaluacion_productor;
        }
        public void extraerMedicion(string parametro)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerEvaluacion", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Parametro", parametro);
            sqlCommand.Parameters.AddWithValue("@Variedad", cmbVariedad.Text);
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

		public void extraerNumANALISIS()
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraer_NumAnalisis", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlDataAdapter.Fill(new DataSet(), "Encabezado");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.ultimo_Analisis = sqlDataReader[0].ToString();
				}
			}
			finally
			{
				if (sqlDataReader != null)
				{
					((IDisposable)sqlDataReader).Dispose();
				}
			}
			if (!(this.ultimo_Analisis == ""))
			{
				int num = Convert.ToInt32(this.ultimo_Analisis) + 1;
				this.Lbl_Analisis.Text = num.ToString();
			}
			else
			{
				this.ultimo_Analisis = "1";
				this.Lbl_Analisis.Text = this.ultimo_Analisis;
			}
			this.cn.Cerrar();
		}

		public void extraerProductores(string productor)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spDistintosProductores_cod", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@productor", productor);
			sqlDataAdapter.Fill(new DataSet(), "producto");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.Txt_ProductorName.Text = sqlDataReader[1].ToString();
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

		private void FormRecepcion_Load(object sender, EventArgs e)
		{
			this.Txt_Lote.Focus();
			if (this.ACCESSO != 0)
			{
				this.traerLote(Convert.ToInt32(this.Txt_Lote.Text));
			}
			else
			{
				this.CmbVariedad();
				this.timer1.Enabled = true;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecepcion));
            this.Lbl_Analisis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DT_Analisis = new System.Windows.Forms.DateTimePicker();
            this.DT_Recepcion = new System.Windows.Forms.DateTimePicker();
            this.Txt_ProductorName = new System.Windows.Forms.TextBox();
            this.CmbPatio = new System.Windows.Forms.ComboBox();
            this.cmbVariedad = new System.Windows.Forms.ComboBox();
            this.CmbRecepcion = new System.Windows.Forms.ComboBox();
            this.Txt_Productor = new System.Windows.Forms.TextBox();
            this.Txt_Lote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCantidadAnakena = new System.Windows.Forms.TextBox();
            this.TxtCantidadProductor = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.TxtDañados = new System.Windows.Forms.TextBox();
            this.Txt_Quebrados = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.Txt_Pelon = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.Txt_Palos = new System.Windows.Forms.TextBox();
            this.Txt_Piedras = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.Txt_Adherido = new System.Windows.Forms.TextBox();
            this.TxtTotalExterno = new System.Windows.Forms.TextBox();
            this.Txt_Resquebrajado = new System.Windows.Forms.TextBox();
            this.Txt_Nuez = new System.Windows.Forms.TextBox();
            this.Txt_Negras = new System.Windows.Forms.TextBox();
            this.Txt_Cerrado = new System.Windows.Forms.TextBox();
            this.Txt_Partidas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.Txt_HongoInactivo = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Txt_Light = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Txt_TotalInterno = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.Txt_Ambar = new System.Windows.Forms.TextBox();
            this.Txt_LightAmbar = new System.Windows.Forms.TextBox();
            this.Txt_Reseca = new System.Windows.Forms.TextBox();
            this.Txt_Vanas = new System.Windows.Forms.TextBox();
            this.Txt_Extra = new System.Windows.Forms.TextBox();
            this.Txt_HongoActivo = new System.Windows.Forms.TextBox();
            this.Txt_Daño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Lbl_Pelon = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_condiciones = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Analisis
            // 
            this.Lbl_Analisis.AutoSize = true;
            this.Lbl_Analisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Analisis.Location = new System.Drawing.Point(1081, 40);
            this.Lbl_Analisis.Name = "Lbl_Analisis";
            this.Lbl_Analisis.Size = new System.Drawing.Size(64, 25);
            this.Lbl_Analisis.TabIndex = 0;
            this.Lbl_Analisis.Text = "####";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.DT_Analisis);
            this.groupBox1.Controls.Add(this.DT_Recepcion);
            this.groupBox1.Controls.Add(this.Txt_ProductorName);
            this.groupBox1.Controls.Add(this.CmbPatio);
            this.groupBox1.Controls.Add(this.cmbVariedad);
            this.groupBox1.Controls.Add(this.CmbRecepcion);
            this.groupBox1.Controls.Add(this.Txt_Productor);
            this.groupBox1.Controls.Add(this.Txt_Lote);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(202, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(301, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Busqueda";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Location = new System.Drawing.Point(327, 99);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(23, 23);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(135, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 26);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DT_Analisis
            // 
            this.DT_Analisis.Enabled = false;
            this.DT_Analisis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Analisis.Location = new System.Drawing.Point(206, 299);
            this.DT_Analisis.Name = "DT_Analisis";
            this.DT_Analisis.Size = new System.Drawing.Size(115, 20);
            this.DT_Analisis.TabIndex = 6;
            // 
            // DT_Recepcion
            // 
            this.DT_Recepcion.Enabled = false;
            this.DT_Recepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Recepcion.Location = new System.Drawing.Point(206, 262);
            this.DT_Recepcion.Name = "DT_Recepcion";
            this.DT_Recepcion.Size = new System.Drawing.Size(115, 20);
            this.DT_Recepcion.TabIndex = 5;
            // 
            // Txt_ProductorName
            // 
            this.Txt_ProductorName.Enabled = false;
            this.Txt_ProductorName.Location = new System.Drawing.Point(115, 184);
            this.Txt_ProductorName.Name = "Txt_ProductorName";
            this.Txt_ProductorName.Size = new System.Drawing.Size(225, 20);
            this.Txt_ProductorName.TabIndex = 10;
            // 
            // CmbPatio
            // 
            this.CmbPatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPatio.Enabled = false;
            this.CmbPatio.FormattingEnabled = true;
            this.CmbPatio.Items.AddRange(new object[] {
            "-- Seleccione Opción --",
            "Patio 1",
            "Patio 2"});
            this.CmbPatio.Location = new System.Drawing.Point(161, 224);
            this.CmbPatio.Name = "CmbPatio";
            this.CmbPatio.Size = new System.Drawing.Size(160, 21);
            this.CmbPatio.TabIndex = 4;
            this.CmbPatio.SelectedIndexChanged += new System.EventHandler(this.CmbPatio_SelectedIndexChanged);
            // 
            // cmbVariedad
            // 
            this.cmbVariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariedad.Enabled = false;
            this.cmbVariedad.FormattingEnabled = true;
            this.cmbVariedad.Location = new System.Drawing.Point(161, 101);
            this.cmbVariedad.Name = "cmbVariedad";
            this.cmbVariedad.Size = new System.Drawing.Size(160, 21);
            this.cmbVariedad.TabIndex = 2;
            this.cmbVariedad.SelectedIndexChanged += new System.EventHandler(this.cmbVariedad_SelectedIndexChanged);
            this.cmbVariedad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbVariedad_MouseClick);
            this.cmbVariedad.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbVariedad_MouseDoubleClick);
            // 
            // CmbRecepcion
            // 
            this.CmbRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRecepcion.Enabled = false;
            this.CmbRecepcion.FormattingEnabled = true;
            this.CmbRecepcion.Items.AddRange(new object[] {
            "-- Seleccione Opción --",
            "Pelón",
            "Humeda"});
            this.CmbRecepcion.Location = new System.Drawing.Point(161, 56);
            this.CmbRecepcion.Name = "CmbRecepcion";
            this.CmbRecepcion.Size = new System.Drawing.Size(160, 21);
            this.CmbRecepcion.TabIndex = 1;
            this.CmbRecepcion.SelectedIndexChanged += new System.EventHandler(this.CmbRecepcion_SelectedIndexChanged);
            // 
            // Txt_Productor
            // 
            this.Txt_Productor.Enabled = false;
            this.Txt_Productor.Location = new System.Drawing.Point(161, 146);
            this.Txt_Productor.Name = "Txt_Productor";
            this.Txt_Productor.Size = new System.Drawing.Size(134, 20);
            this.Txt_Productor.TabIndex = 3;
            this.Txt_Productor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Productor_KeyPress);
            // 
            // Txt_Lote
            // 
            this.Txt_Lote.Location = new System.Drawing.Point(161, 22);
            this.Txt_Lote.Name = "Txt_Lote";
            this.Txt_Lote.Size = new System.Drawing.Size(160, 20);
            this.Txt_Lote.TabIndex = 0;
            this.Txt_Lote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Lote_KeyDown);
            this.Txt_Lote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Lote_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha Analisis / Proceso :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Recepcion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patio Recepcion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Productor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº Productor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Variedad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Recepcion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Lote :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCantidadAnakena);
            this.groupBox2.Controls.Add(this.TxtCantidadProductor);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.TxtDañados);
            this.groupBox2.Controls.Add(this.Txt_Quebrados);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(202, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condicion Envases (Bins)";
            // 
            // TxtCantidadAnakena
            // 
            this.TxtCantidadAnakena.Enabled = false;
            this.TxtCantidadAnakena.Location = new System.Drawing.Point(207, 52);
            this.TxtCantidadAnakena.Name = "TxtCantidadAnakena";
            this.TxtCantidadAnakena.Size = new System.Drawing.Size(74, 20);
            this.TxtCantidadAnakena.TabIndex = 8;
            this.TxtCantidadAnakena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadAnakena_KeyPress);
            // 
            // TxtCantidadProductor
            // 
            this.TxtCantidadProductor.Location = new System.Drawing.Point(207, 17);
            this.TxtCantidadProductor.Name = "TxtCantidadProductor";
            this.TxtCantidadProductor.Size = new System.Drawing.Size(74, 20);
            this.TxtCantidadProductor.TabIndex = 7;
            this.TxtCantidadProductor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadProductor_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(54, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 18);
            this.label28.TabIndex = 6;
            this.label28.Text = "Nº Bins Anakena:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(54, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(131, 18);
            this.label52.TabIndex = 5;
            this.label52.Text = "Nº Bins Productor:";
            // 
            // TxtDañados
            // 
            this.TxtDañados.Enabled = false;
            this.TxtDañados.Location = new System.Drawing.Point(207, 119);
            this.TxtDañados.Name = "TxtDañados";
            this.TxtDañados.Size = new System.Drawing.Size(74, 20);
            this.TxtDañados.TabIndex = 4;
            this.TxtDañados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDañados_KeyPress);
            // 
            // Txt_Quebrados
            // 
            this.Txt_Quebrados.Enabled = false;
            this.Txt_Quebrados.Location = new System.Drawing.Point(207, 84);
            this.Txt_Quebrados.Name = "Txt_Quebrados";
            this.Txt_Quebrados.Size = new System.Drawing.Size(74, 20);
            this.Txt_Quebrados.TabIndex = 3;
            this.Txt_Quebrados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Quebrados_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Bins Dañados:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Bins Quebrados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label53);
            this.groupBox3.Controls.Add(this.Txt_Pelon);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.Txt_Palos);
            this.groupBox3.Controls.Add(this.Txt_Piedras);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(202, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impurezas";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(299, 96);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(31, 18);
            this.label53.TabIndex = 28;
            this.label53.Text = "(%)";
            // 
            // Txt_Pelon
            // 
            this.Txt_Pelon.Location = new System.Drawing.Point(244, 97);
            this.Txt_Pelon.Name = "Txt_Pelon";
            this.Txt_Pelon.Size = new System.Drawing.Size(40, 20);
            this.Txt_Pelon.TabIndex = 26;
            this.Txt_Pelon.TextChanged += new System.EventHandler(this.Txt_Pelon_TextChanged);
            this.Txt_Pelon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pelon_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(27, 96);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(169, 18);
            this.label54.TabIndex = 27;
            this.label54.Text = "Impurezas: Pelon Suelto";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(299, 67);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(31, 18);
            this.label49.TabIndex = 25;
            this.label49.Text = "(%)";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(299, 33);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(31, 18);
            this.label48.TabIndex = 24;
            this.label48.Text = "(%)";
            // 
            // Txt_Palos
            // 
            this.Txt_Palos.Location = new System.Drawing.Point(244, 65);
            this.Txt_Palos.Name = "Txt_Palos";
            this.Txt_Palos.Size = new System.Drawing.Size(40, 20);
            this.Txt_Palos.TabIndex = 1;
            this.Txt_Palos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Palos_KeyPress);
            // 
            // Txt_Piedras
            // 
            this.Txt_Piedras.Location = new System.Drawing.Point(244, 33);
            this.Txt_Piedras.Name = "Txt_Piedras";
            this.Txt_Piedras.Size = new System.Drawing.Size(40, 20);
            this.Txt_Piedras.TabIndex = 0;
            this.Txt_Piedras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Piedras_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Impurezas: Palos, Hojas, Pasto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Impurezas: Piedras, Terrones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.Txt_Adherido);
            this.groupBox4.Controls.Add(this.TxtTotalExterno);
            this.groupBox4.Controls.Add(this.Txt_Resquebrajado);
            this.groupBox4.Controls.Add(this.Txt_Nuez);
            this.groupBox4.Controls.Add(this.Txt_Negras);
            this.groupBox4.Controls.Add(this.Txt_Cerrado);
            this.groupBox4.Controls.Add(this.Txt_Partidas);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(605, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 290);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Analisis externos :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(274, 19);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 18);
            this.label47.TabIndex = 32;
            this.label47.Text = "(%)";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(274, 58);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(31, 18);
            this.label46.TabIndex = 31;
            this.label46.Text = "(%)";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(274, 101);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(31, 18);
            this.label45.TabIndex = 30;
            this.label45.Text = "(%)";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(274, 144);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(31, 18);
            this.label44.TabIndex = 29;
            this.label44.Text = "(%)";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(274, 184);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(31, 18);
            this.label43.TabIndex = 28;
            this.label43.Text = "(%)";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(274, 221);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(31, 18);
            this.label42.TabIndex = 23;
            this.label42.Text = "(%)";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(274, 262);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 18);
            this.label41.TabIndex = 27;
            this.label41.Text = "(%)";
            // 
            // Txt_Adherido
            // 
            this.Txt_Adherido.Enabled = false;
            this.Txt_Adherido.Location = new System.Drawing.Point(207, 263);
            this.Txt_Adherido.Name = "Txt_Adherido";
            this.Txt_Adherido.Size = new System.Drawing.Size(67, 20);
            this.Txt_Adherido.TabIndex = 6;
            this.Txt_Adherido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Adherido_KeyPress);
            // 
            // TxtTotalExterno
            // 
            this.TxtTotalExterno.Enabled = false;
            this.TxtTotalExterno.Location = new System.Drawing.Point(207, 223);
            this.TxtTotalExterno.Name = "TxtTotalExterno";
            this.TxtTotalExterno.Size = new System.Drawing.Size(67, 20);
            this.TxtTotalExterno.TabIndex = 5;
            // 
            // Txt_Resquebrajado
            // 
            this.Txt_Resquebrajado.Enabled = false;
            this.Txt_Resquebrajado.Location = new System.Drawing.Point(207, 99);
            this.Txt_Resquebrajado.Name = "Txt_Resquebrajado";
            this.Txt_Resquebrajado.Size = new System.Drawing.Size(67, 20);
            this.Txt_Resquebrajado.TabIndex = 2;
            this.Txt_Resquebrajado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Resquebrajado_KeyPress);
            // 
            // Txt_Nuez
            // 
            this.Txt_Nuez.Enabled = false;
            this.Txt_Nuez.Location = new System.Drawing.Point(207, 59);
            this.Txt_Nuez.Name = "Txt_Nuez";
            this.Txt_Nuez.Size = new System.Drawing.Size(67, 20);
            this.Txt_Nuez.TabIndex = 1;
            this.Txt_Nuez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nuez_KeyPress);
            // 
            // Txt_Negras
            // 
            this.Txt_Negras.Enabled = false;
            this.Txt_Negras.Location = new System.Drawing.Point(207, 182);
            this.Txt_Negras.Name = "Txt_Negras";
            this.Txt_Negras.Size = new System.Drawing.Size(67, 20);
            this.Txt_Negras.TabIndex = 4;
            this.Txt_Negras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Negras_KeyPress);
            // 
            // Txt_Cerrado
            // 
            this.Txt_Cerrado.Enabled = false;
            this.Txt_Cerrado.Location = new System.Drawing.Point(207, 142);
            this.Txt_Cerrado.Name = "Txt_Cerrado";
            this.Txt_Cerrado.Size = new System.Drawing.Size(67, 20);
            this.Txt_Cerrado.TabIndex = 3;
            this.Txt_Cerrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cerrado_KeyPress);
            // 
            // Txt_Partidas
            // 
            this.Txt_Partidas.Enabled = false;
            this.Txt_Partidas.Location = new System.Drawing.Point(207, 19);
            this.Txt_Partidas.Name = "Txt_Partidas";
            this.Txt_Partidas.Size = new System.Drawing.Size(67, 20);
            this.Txt_Partidas.TabIndex = 0;
            this.Txt_Partidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Partidas_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Pelon Adherido (verde %)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "TOTAL NUECES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "Negras / Momificadas :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Pelon Cerrado :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "Pelon Resquebrajado:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "Nuez Hº sin pelon:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Partidas / Quebradas :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.Txt_HongoInactivo);
            this.groupBox5.Controls.Add(this.label56);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.Txt_Light);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.Txt_TotalInterno);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.Txt_Ambar);
            this.groupBox5.Controls.Add(this.Txt_LightAmbar);
            this.groupBox5.Controls.Add(this.Txt_Reseca);
            this.groupBox5.Controls.Add(this.Txt_Vanas);
            this.groupBox5.Controls.Add(this.Txt_Extra);
            this.groupBox5.Controls.Add(this.Txt_HongoActivo);
            this.groupBox5.Controls.Add(this.Txt_Daño);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(605, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 367);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Analisis internos :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(274, 176);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 18);
            this.label55.TabIndex = 32;
            this.label55.Text = "(%)";
            // 
            // Txt_HongoInactivo
            // 
            this.Txt_HongoInactivo.Enabled = false;
            this.Txt_HongoInactivo.Location = new System.Drawing.Point(207, 142);
            this.Txt_HongoInactivo.Name = "Txt_HongoInactivo";
            this.Txt_HongoInactivo.Size = new System.Drawing.Size(67, 20);
            this.Txt_HongoInactivo.TabIndex = 30;
            this.Txt_HongoInactivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HongoInactivo_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(26, 144);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(115, 18);
            this.label56.TabIndex = 31;
            this.label56.Text = "Hongo Inactivo :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(274, 214);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 18);
            this.label33.TabIndex = 29;
            this.label33.Text = "(%)";
            // 
            // Txt_Light
            // 
            this.Txt_Light.Enabled = false;
            this.Txt_Light.Location = new System.Drawing.Point(207, 212);
            this.Txt_Light.Name = "Txt_Light";
            this.Txt_Light.Size = new System.Drawing.Size(67, 20);
            this.Txt_Light.TabIndex = 5;
            this.Txt_Light.TextChanged += new System.EventHandler(this.Txt_Light_TextChanged);
            this.Txt_Light.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Light_KeyPress_1);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(274, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 18);
            this.label31.TabIndex = 21;
            this.label31.Text = "(%)";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(26, 211);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 18);
            this.label50.TabIndex = 27;
            this.label50.Text = "Light:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(274, 320);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 18);
            this.label40.TabIndex = 23;
            this.label40.Text = "(%)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(274, 281);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 18);
            this.label39.TabIndex = 23;
            this.label39.Text = "(%)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(274, 46);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 18);
            this.label38.TabIndex = 26;
            this.label38.Text = "(%)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(274, 76);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(31, 18);
            this.label37.TabIndex = 25;
            this.label37.Text = "(%)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(274, 109);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 18);
            this.label36.TabIndex = 24;
            this.label36.Text = "(%)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(274, 142);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(31, 18);
            this.label35.TabIndex = 23;
            this.label35.Text = "(%)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(274, 247);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 18);
            this.label32.TabIndex = 22;
            this.label32.Text = "(%)";
            // 
            // Txt_TotalInterno
            // 
            this.Txt_TotalInterno.Enabled = false;
            this.Txt_TotalInterno.Location = new System.Drawing.Point(207, 320);
            this.Txt_TotalInterno.Name = "Txt_TotalInterno";
            this.Txt_TotalInterno.Size = new System.Drawing.Size(67, 20);
            this.Txt_TotalInterno.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 322);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 18);
            this.label27.TabIndex = 19;
            this.label27.Text = "TOTAL NUECES";
            // 
            // Txt_Ambar
            // 
            this.Txt_Ambar.Enabled = false;
            this.Txt_Ambar.Location = new System.Drawing.Point(207, 281);
            this.Txt_Ambar.Name = "Txt_Ambar";
            this.Txt_Ambar.Size = new System.Drawing.Size(67, 20);
            this.Txt_Ambar.TabIndex = 7;
            this.Txt_Ambar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ambar_KeyPress);
            // 
            // Txt_LightAmbar
            // 
            this.Txt_LightAmbar.Enabled = false;
            this.Txt_LightAmbar.Location = new System.Drawing.Point(207, 247);
            this.Txt_LightAmbar.Name = "Txt_LightAmbar";
            this.Txt_LightAmbar.Size = new System.Drawing.Size(67, 20);
            this.Txt_LightAmbar.TabIndex = 6;
            this.Txt_LightAmbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Light_KeyPress);
            // 
            // Txt_Reseca
            // 
            this.Txt_Reseca.Enabled = false;
            this.Txt_Reseca.Location = new System.Drawing.Point(207, 77);
            this.Txt_Reseca.Name = "Txt_Reseca";
            this.Txt_Reseca.Size = new System.Drawing.Size(67, 20);
            this.Txt_Reseca.TabIndex = 2;
            this.Txt_Reseca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Reseca_KeyPress);
            // 
            // Txt_Vanas
            // 
            this.Txt_Vanas.Enabled = false;
            this.Txt_Vanas.Location = new System.Drawing.Point(207, 46);
            this.Txt_Vanas.Name = "Txt_Vanas";
            this.Txt_Vanas.Size = new System.Drawing.Size(67, 20);
            this.Txt_Vanas.TabIndex = 1;
            this.Txt_Vanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Vanas_KeyPress);
            // 
            // Txt_Extra
            // 
            this.Txt_Extra.Enabled = false;
            this.Txt_Extra.Location = new System.Drawing.Point(207, 177);
            this.Txt_Extra.Name = "Txt_Extra";
            this.Txt_Extra.Size = new System.Drawing.Size(67, 20);
            this.Txt_Extra.TabIndex = 4;
            this.Txt_Extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Extra_KeyPress);
            // 
            // Txt_HongoActivo
            // 
            this.Txt_HongoActivo.Enabled = false;
            this.Txt_HongoActivo.Location = new System.Drawing.Point(207, 110);
            this.Txt_HongoActivo.Name = "Txt_HongoActivo";
            this.Txt_HongoActivo.Size = new System.Drawing.Size(67, 20);
            this.Txt_HongoActivo.TabIndex = 3;
            this.Txt_HongoActivo.TextChanged += new System.EventHandler(this.Txt_HongoActivo_TextChanged);
            this.Txt_HongoActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Hongo_KeyPress);
            // 
            // Txt_Daño
            // 
            this.Txt_Daño.Enabled = false;
            this.Txt_Daño.Location = new System.Drawing.Point(207, 14);
            this.Txt_Daño.Name = "Txt_Daño";
            this.Txt_Daño.Size = new System.Drawing.Size(67, 20);
            this.Txt_Daño.TabIndex = 0;
            this.Txt_Daño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Daño_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ambar o Amarillo:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 246);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 18);
            this.label21.TabIndex = 5;
            this.label21.Text = "Light Ambar:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 18);
            this.label22.TabIndex = 4;
            this.label22.Text = "Extra Ligth:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(26, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 18);
            this.label23.TabIndex = 3;
            this.label23.Text = "Hongo Activo :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 18);
            this.label24.TabIndex = 2;
            this.label24.Text = "Reseca Grave:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(26, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 18);
            this.label25.TabIndex = 1;
            this.label25.Text = "Vanas:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(26, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(138, 18);
            this.label26.TabIndex = 0;
            this.label26.Text = "Daño por insectos :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Lbl_Pelon);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Location = new System.Drawing.Point(941, 80);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 148);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "-";
            // 
            // Lbl_Pelon
            // 
            this.Lbl_Pelon.AutoSize = true;
            this.Lbl_Pelon.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pelon.Location = new System.Drawing.Point(74, 42);
            this.Lbl_Pelon.Name = "Lbl_Pelon";
            this.Lbl_Pelon.Size = new System.Drawing.Size(0, 73);
            this.Lbl_Pelon.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(13, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(191, 24);
            this.label34.TabIndex = 0;
            this.label34.Text = "PELÓN ADHERIDO";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbl_condiciones);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Location = new System.Drawing.Point(941, 261);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(227, 148);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // lbl_condiciones
            // 
            this.lbl_condiciones.AutoSize = true;
            this.lbl_condiciones.BackColor = System.Drawing.Color.White;
            this.lbl_condiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condiciones.ForeColor = System.Drawing.Color.Green;
            this.lbl_condiciones.Location = new System.Drawing.Point(17, 59);
            this.lbl_condiciones.Name = "lbl_condiciones";
            this.lbl_condiciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_condiciones.Size = new System.Drawing.Size(0, 42);
            this.lbl_condiciones.TabIndex = 1;
            this.lbl_condiciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(47, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(124, 24);
            this.label29.TabIndex = 0;
            this.label29.Text = "CONDICIÓN";
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(305, 668);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(623, 20);
            this.Txt_Observaciones.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(199, 668);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 18);
            this.label30.TabIndex = 5;
            this.label30.Text = "Observacion :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(951, 40);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(134, 25);
            this.label51.TabIndex = 26;
            this.label51.Text = "Nº Analisis:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Btn_Print);
            this.groupBox9.Controls.Add(this.Btn_Guardar);
            this.groupBox9.Location = new System.Drawing.Point(1003, 456);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(106, 106);
            this.groupBox9.TabIndex = 27;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Opciones";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Print.BackgroundImage")));
            this.Btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Print.Location = new System.Drawing.Point(8, 62);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(93, 26);
            this.Btn_Print.TabIndex = 26;
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click_1);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.BackgroundImage")));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.Location = new System.Drawing.Point(8, 26);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(93, 26);
            this.Btn_Guardar.TabIndex = 23;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.Btn_Delete);
            this.groupBox10.Controls.Add(this.Btn_Modificar);
            this.groupBox10.Location = new System.Drawing.Point(1003, 442);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(116, 144);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Opciones";
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(13, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 26);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.BackgroundImage")));
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.Location = new System.Drawing.Point(13, 102);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(87, 26);
            this.Btn_Delete.TabIndex = 26;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.BackgroundImage")));
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Modificar.Location = new System.Drawing.Point(13, 29);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(87, 26);
            this.Btn_Modificar.TabIndex = 23;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.BackgroundImage")));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Location = new System.Drawing.Point(1040, 658);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(72, 26);
            this.Btn_Salir.TabIndex = 25;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 26);
            this.button6.TabIndex = 28;
            this.button6.Text = "Ver parametros evaluacion";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FormRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1186, 696);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_Analisis);
            this.Name = "FormRecepcion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.FormRecepcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!this.Txt_Productor.ReadOnly)
			{
				FormBusquedaProductor formBusquedaProductor = new FormBusquedaProductor();
				formBusquedaProductor.ShowDialog();
				this.Txt_Productor.Text = formBusquedaProductor.codigo;
				this.Txt_ProductorName.Text = formBusquedaProductor.nombre;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.extraerNumANALISIS();
		}

		public void TraerAnalisisExterno(int analisis)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerAnalisisExterno", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
			sqlDataAdapter.Fill(new DataSet(), "AnalisisExterno");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.Txt_Partidas.Text = sqlDataReader[0].ToString();
					this.Txt_Nuez.Text = sqlDataReader[1].ToString();
					this.Txt_Resquebrajado.Text = sqlDataReader[2].ToString();
					this.Txt_Cerrado.Text = sqlDataReader[3].ToString();
					this.Txt_Negras.Text = sqlDataReader[4].ToString();
					this.Txt_Adherido.Text = sqlDataReader[5].ToString();
					this.Lbl_Pelon.Text = string.Concat(sqlDataReader[5].ToString(), "%");
					this.TxtTotalExterno.Text = "100";
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

		public void TraerAnalisisInterno(int analisis)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerAnalisisInterno", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
			sqlDataAdapter.Fill(new DataSet(), "AnalisisInterno");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.Txt_Daño.Text = sqlDataReader[0].ToString();
					this.Txt_Vanas.Text = sqlDataReader[1].ToString();
					this.Txt_Reseca.Text = sqlDataReader[2].ToString();
					this.Txt_HongoActivo.Text = sqlDataReader[3].ToString();
					this.Txt_Extra.Text = sqlDataReader[4].ToString();
					this.Txt_Light.Text = sqlDataReader[5].ToString();
					this.Txt_LightAmbar.Text = sqlDataReader[6].ToString();
					this.Txt_Ambar.Text = sqlDataReader[7].ToString();
					this.Txt_Observaciones.Text = sqlDataReader[8].ToString();
                    Txt_HongoInactivo.Text = sqlDataReader[9].ToString();
					this.Txt_Observaciones.ReadOnly = true;
					this.Txt_TotalInterno.Text = "100";
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

		public void TraerEnvases(int analisis)
		{
			this.Txt_Quebrados.Text = "";
			this.TxtDañados.Text = "";
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerEnvases", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
			sqlDataAdapter.Fill(new DataSet(), "Envases");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.Txt_Quebrados.Text = sqlDataReader[0].ToString();
					this.TxtDañados.Text = sqlDataReader[1].ToString();
					this.lbl_condiciones.Text = sqlDataReader[3].ToString();
					if (this.lbl_condiciones.Text == "ROJO")
					{
						this.lbl_condiciones.ForeColor = Color.Red;
					}
					else if (this.lbl_condiciones.Text == "AMARILLO")
					{
						this.lbl_condiciones.ForeColor = Color.Yellow;
					}
					else if (this.lbl_condiciones.Text == "VERDE")
					{
						this.lbl_condiciones.ForeColor = Color.Green;
					}
					this.TxtCantidadProductor.Text = sqlDataReader[2].ToString();
					this.TxtCantidadAnakena.Text = sqlDataReader[4].ToString();
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

		public void TraerImpurezas(int analisis)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerImpurezas", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
			sqlDataAdapter.Fill(new DataSet(), "Impurezas");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.Txt_Piedras.Text = sqlDataReader[0].ToString();
					this.Txt_Palos.Text = sqlDataReader[1].ToString();
                    this.Txt_Pelon.Text = sqlDataReader[2].ToString();
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

		public void traerLote(int lote)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerEncabezado", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Lote", lote);
			sqlDataAdapter.Fill(new DataSet(), "Encabezado");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					this.cmbVariedad.Text = sqlDataReader[2].ToString();
					this.ultimo = sqlDataReader[0].ToString();
					this.CmbRecepcion.Text = sqlDataReader[1].ToString();
					this.Txt_Productor.Text = sqlDataReader[3].ToString();
					this.CmbPatio.Text = sqlDataReader[4].ToString();
					this.DT_Recepcion.Text = sqlDataReader[5].ToString();
					this.DT_Analisis.Text = sqlDataReader[6].ToString();
				}
			}
			finally
			{
				if (sqlDataReader != null)
				{
					((IDisposable)sqlDataReader).Dispose();
				}
			}
			if (this.ultimo != "")
			{
				this.Lbl_Analisis.Text = this.ultimo;
			}
			this.cn.Cerrar();
			this.extraerProductores(this.Txt_Productor.Text);
		}

		private void Txt_Adherido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Adherido.Text != ""))
			{
				this.groupBox5.Enabled = true;
				this.Txt_Daño.Enabled = true;
				this.Txt_Daño.Focus();
				this.Lbl_Pelon.Text = string.Concat(this.Txt_Adherido.Text, "%");
			}
		}

		private void Txt_Ambar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Ambar.Text != ""))
			{
				int num = Convert.ToInt32(this.Txt_Daño.Text) + Convert.ToInt32(this.Txt_Vanas.Text) + Convert.ToInt32(this.Txt_Reseca.Text) + Convert.ToInt32(this.Txt_HongoActivo.Text) + Convert.ToInt32(this.Txt_Extra.Text) + Convert.ToInt32(this.Txt_Light.Text) + Convert.ToInt32(this.Txt_LightAmbar.Text) + Convert.ToInt32(this.Txt_Ambar.Text)+Convert.ToInt32(Txt_HongoInactivo.Text);
				if (num != 100)
				{
					MessageBox.Show(string.Concat("La suma esperada es 100% , la suma actual es ", num, "%"), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else if (!this.Txt_Ambar.ReadOnly)
				{
					this.Btn_Guardar.Enabled = true;
					this.Txt_TotalInterno.Text = num.ToString();
					this.Txt_Observaciones.Focus();
				}
			}
		}

		private void Txt_Cerrado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Cerrado.Text != ""))
			{
				this.Txt_Negras.Enabled = true;
				this.Txt_Negras.Focus();
			}
		}

		private void Txt_Daño_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Daño.Text != ""))
			{
				this.Txt_Vanas.Enabled = true;
				this.Txt_Vanas.Focus();
			}
		}

		private void Txt_Extra_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Extra.Text != ""))
			{
				this.Txt_Light.Enabled = true;
				this.Txt_Light.Focus();
			}
		}

		private void Txt_Hongo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_HongoActivo.Text != ""))
			{
				this.Txt_HongoInactivo.Enabled = true;
				this.Txt_HongoInactivo.Focus();
			}
		}

		private void Txt_Light_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_LightAmbar.Text != ""))
			{
				this.Txt_Ambar.Enabled = true;
				this.Txt_Ambar.Focus();
			}
		}

		private void Txt_Light_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Extra.Text != ""))
			{
				this.Txt_LightAmbar.Enabled = true;
				this.Txt_LightAmbar.Focus();
			}
		}

		private void Txt_Light_TextChanged(object sender, EventArgs e)
		{
		}

		private void Txt_Lote_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.Tab)
			//{
			//	MessageBox.Show("si funka");
			//}
		}

		private void Txt_Lote_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if (this.groupBox9.Visible)
			{
				this.ultimo = "";
				if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Lote.Text != ""))
				{
					this.traerLote(Convert.ToInt32(this.Txt_Lote.Text));
					if (!(this.ultimo == ""))
					{
						this.Btn_Guardar.Enabled = false;
						this.Txt_Lote.ReadOnly = true;
						this.CmbRecepcion.Enabled = false;
						this.CmbRecepcion.DropDownStyle = ComboBoxStyle.Simple;
						this.cmbVariedad.DropDownStyle = ComboBoxStyle.Simple;
						this.cmbVariedad.Enabled = false;
						this.Txt_Productor.Enabled = true;
						this.Txt_Productor.ReadOnly = true;
						this.Txt_ProductorName.Enabled = true;
						this.Txt_ProductorName.ReadOnly = true;
						this.CmbPatio.Enabled = false;
						this.DT_Analisis.Enabled = true;
						this.DT_Recepcion.Enabled = true;
						this.CmbPatio.DropDownStyle = ComboBoxStyle.Simple;
						this.button2.Enabled = false;
						this.traerLote(Convert.ToInt32(this.Txt_Lote.Text));
						this.TraerEnvases(Convert.ToInt32(this.ultimo));
						if (this.Txt_Quebrados.Text != "")
						{
							this.groupBox2.Enabled = true;
							this.TraerImpurezas(Convert.ToInt32(this.ultimo));
							this.TraerAnalisisExterno(Convert.ToInt32(this.ultimo));
							this.TraerAnalisisInterno(Convert.ToInt32(this.ultimo));
							this.groupBox3.Enabled = true;
							this.groupBox4.Enabled = true;
							this.groupBox5.Enabled = true;
							this.Txt_Quebrados.Enabled = true;
							this.Txt_Quebrados.ReadOnly = true;
							this.TxtDañados.Enabled = true;
							this.TxtDañados.ReadOnly = true;
							this.Txt_Piedras.Enabled = true;
							this.Txt_Piedras.ReadOnly = true;
							this.Txt_Palos.Enabled = true;
							this.Txt_Palos.ReadOnly = true;
							this.Txt_Partidas.Enabled = true;
							this.Txt_Partidas.ReadOnly = true;
							this.Txt_Nuez.Enabled = true;
							this.Txt_Nuez.ReadOnly = true;
							this.Txt_Resquebrajado.Enabled = true;
							this.Txt_Resquebrajado.ReadOnly = true;
							this.Txt_Cerrado.Enabled = true;
							this.Txt_Cerrado.ReadOnly = true;
							this.Txt_Negras.Enabled = true;
							this.Txt_Negras.ReadOnly = true;
							this.TxtTotalExterno.Enabled = true;
							this.TxtTotalExterno.ReadOnly = true;
							this.Txt_Adherido.Enabled = true;
							this.Txt_Adherido.ReadOnly = true;
							this.Txt_Daño.Enabled = true;
							this.Txt_Daño.ReadOnly = true;
							this.Txt_Vanas.Enabled = true;
							this.Txt_Vanas.ReadOnly = true;
							this.Txt_Reseca.Enabled = true;
							this.Txt_Reseca.ReadOnly = true;
							this.Txt_HongoActivo.Enabled = true;
							this.Txt_HongoActivo.ReadOnly = true;
                            this.Txt_HongoInactivo.Enabled = true;
                            this.Txt_HongoInactivo.ReadOnly = true;
                            this.Txt_Extra.Enabled = true;
							this.Txt_Extra.ReadOnly = true;
							this.Txt_Light.Enabled = true;
							this.Txt_Light.ReadOnly = true;
							this.Txt_LightAmbar.Enabled = true;
							this.Txt_LightAmbar.ReadOnly = true;
							this.Txt_Ambar.Enabled = true;
							this.Txt_Ambar.ReadOnly = true;
							this.Txt_TotalInterno.Enabled = true;
							this.Txt_TotalInterno.ReadOnly = true;
							this.Btn_Print.Enabled = true;
							this.evaluacion();
						}
						if ((!this.Txt_Productor.ReadOnly ? false : this.Txt_Quebrados.Text == ""))
						{
							this.groupBox2.Enabled = true;
							this.TxtDañados.ReadOnly = false;
							this.TxtDañados.Enabled = false;
							this.Txt_Quebrados.ReadOnly = false;
							this.groupBox3.Enabled = false;
							this.groupBox4.Enabled = false;
							this.groupBox5.Enabled = false;
							this.Txt_Piedras.ReadOnly = false;
							this.Txt_Piedras.Text = "";
							this.Txt_Palos.ReadOnly = false;
							this.Txt_Palos.Text = "";
							this.Txt_Partidas.ReadOnly = false;
							this.Txt_Partidas.Text = "";
							this.Txt_Nuez.ReadOnly = false;
							this.Txt_Nuez.Text = "";
							this.Txt_Resquebrajado.ReadOnly = false;
							this.Txt_Resquebrajado.Text = "";
							this.Txt_Cerrado.ReadOnly = false;
							this.Txt_Cerrado.Text = "";
							this.Txt_Negras.ReadOnly = false;
							this.Txt_Negras.Text = "";
							this.TxtTotalExterno.ReadOnly = false;
							this.TxtTotalExterno.Text = "";
							this.Txt_Adherido.ReadOnly = false;
							this.Txt_Adherido.Text = "";
							this.Txt_Daño.ReadOnly = false;
							this.Txt_Daño.Text = "";
							this.Txt_Vanas.ReadOnly = false;
							this.Txt_Vanas.Text = "";
							this.Txt_Reseca.ReadOnly = false;
							this.Txt_Reseca.Text = "";
							this.Txt_HongoActivo.ReadOnly = false;
							this.Txt_HongoActivo.Text = "";
                            this.Txt_HongoInactivo.ReadOnly = false;
                            this.Txt_HongoInactivo.Text = "";
                            this.Txt_Extra.ReadOnly = false;
							this.Txt_Extra.Text = "";
							this.Txt_Light.ReadOnly = false;
							this.Txt_Light.Text = "";
							this.Txt_LightAmbar.ReadOnly = false;
							this.Txt_LightAmbar.Text = "";
							this.Txt_Ambar.ReadOnly = false;
							this.Txt_Ambar.Text = "";
							this.Txt_TotalInterno.ReadOnly = false;
							this.Txt_TotalInterno.Text = "";
							this.Txt_Observaciones.Text = "";
							this.Txt_Observaciones.ReadOnly = false;
						}
					}
					else
					{
						this.CmbRecepcion.Enabled = true;
						this.CmbRecepcion.SelectedIndex = 0;
						this.Refresh();
						if (this.Txt_Productor.ReadOnly)
						{
							base.Close();
							FormRecepcion formRecepcion = new FormRecepcion();
							formRecepcion.Txt_Lote.Text = this.Txt_Lote.Text;
							formRecepcion.CmbRecepcion.Enabled = true;
							formRecepcion.CmbRecepcion.SelectedIndex = 0;
							formRecepcion.ShowDialog();
						}
					}
				}
			}
		}

		private void Txt_Negras_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Negras.Text != ""))
			{
				int num = Convert.ToInt32(this.Txt_Partidas.Text) + Convert.ToInt32(this.Txt_Nuez.Text) + Convert.ToInt32(this.Txt_Resquebrajado.Text) + Convert.ToInt32(this.Txt_Cerrado.Text) + Convert.ToInt32(this.Txt_Negras.Text);
				if (num != 100)
				{
					MessageBox.Show(string.Concat("La suma esperada es 100% , la suma actual es ", num, "%"), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.Txt_Adherido.Enabled = true;
					this.Txt_Adherido.Focus();
					this.TxtTotalExterno.Text = num.ToString();
				}
			}
		}

		private void Txt_Nuez_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Nuez.Text != ""))
			{
				this.Txt_Resquebrajado.Enabled = true;
				this.Txt_Resquebrajado.Focus();
			}
		}

		private void Txt_Palos_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '\r' ? true : e.KeyChar == '.'))
			{
				MessageBox.Show("Solo se permiten numeros decimales con '.'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Palos.Text != ""))
			{
			//	((this.groupBox4.Enabled = true;
                Txt_Pelon.Enabled = true;
                Txt_Pelon.Focus();
			}
		}

		private void Txt_Partidas_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Partidas.Text != ""))
			{
				this.Txt_Nuez.Enabled = true;
				this.Txt_Nuez.Focus();
			}
		}

		private void Txt_Piedras_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '\r' ? true : e.KeyChar == '.'))
			{
				MessageBox.Show("Solo se permiten numeros enteros con '.'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Piedras.Text != ""))
			{
				this.Txt_Palos.Enabled = true;
				this.Txt_Palos.Focus();
			}
		}

		private void Txt_Productor_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if ((e.KeyChar != Convert.ToChar(Keys.Return) || !(this.Txt_Productor.Text != "") ? false : !this.Txt_Productor.ReadOnly))
				{
					this.Txt_ProductorName.Text = "";
					this.CmbPatio.Enabled = false;
					if ((Convert.ToInt16(this.Txt_Productor.Text) >= 9 ? false : this.Txt_Productor.TextLength < 2))
					{
						this.Txt_Productor.Text = string.Concat("0", this.Txt_Productor.Text);
					}
					this.extraerProductores(this.Txt_Productor.Text);
					if (!(this.Txt_ProductorName.Text != ""))
					{
						MessageBox.Show("Comprueba que codigo de productor realmente existe", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if (this.groupBox9.Visible)
					{
						this.CmbPatio.Enabled = true;
						this.CmbPatio.SelectedIndex = 0;
					}
				}
			}
			catch
			{
			}
		}

		private void Txt_Quebrados_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != '\r' ? false : this.Txt_Quebrados.Text != ""))
			{
				this.TxtDañados.Enabled = true;
				this.TxtDañados.Focus();
			}
		}

		private void Txt_Reseca_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Reseca.Text != ""))
			{
				this.Txt_HongoActivo.Enabled = true;
				this.Txt_HongoActivo.Focus();
			}
		}

		private void Txt_Resquebrajado_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Resquebrajado.Text != ""))
			{
				this.Txt_Cerrado.Enabled = true;
				this.Txt_Cerrado.Focus();
			}
		}

		private void Txt_Vanas_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Vanas.Text != ""))
			{
				this.Txt_Reseca.Enabled = true;
				this.Txt_Reseca.Focus();
			}
		}

		private void TxtCantidadAnakena_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != '\r' ? false : this.TxtCantidadAnakena.Text != ""))
			{
				this.Txt_Quebrados.Enabled = true;
				this.Txt_Quebrados.Focus();
			}
		}

		private void TxtCantidadProductor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != '\r' ? false : this.TxtCantidadProductor.Text != ""))
			{
				this.TxtCantidadAnakena.Enabled = true;
				this.TxtCantidadAnakena.Focus();
			}
		}

		private void TxtDañados_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
			{
				MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
			}
			else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.TxtDañados.Text != ""))
			{
				this.groupBox3.Enabled = true;
				this.Txt_Piedras.Enabled = true;
				this.Txt_Piedras.Focus();
			}
		}

		public void update_AnalisisExterno()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateAnalisisExterno", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Partidas_Quebradas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Sin_Pelon", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Pelon_Resquebrajado", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Partidas_Cerrado", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Negras_Momificadas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Pelon_Adherido", SqlDbType.Int);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Partidas_Quebradas"].Value = Convert.ToInt32(this.Txt_Partidas.Text);
					sqlCommand.Parameters["@Sin_Pelon"].Value = Convert.ToInt32(this.Txt_Nuez.Text);
					sqlCommand.Parameters["@Pelon_Resquebrajado"].Value = Convert.ToInt32(this.Txt_Resquebrajado.Text);
					sqlCommand.Parameters["@Partidas_Cerrado"].Value = Convert.ToInt32(this.Txt_Cerrado.Text);
					sqlCommand.Parameters["@Negras_Momificadas"].Value = Convert.ToInt32(this.Txt_Negras.Text);
					sqlCommand.Parameters["@Pelon_Adherido"].Value = Convert.ToInt32(this.Txt_Adherido.Text);
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

		public void update_AnalisisInterno()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateAnalisisInterno", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Daño_Insectos", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Vanas", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Reseca", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Hongo_Activo", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Extra_Light", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Light", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Light_Ambar", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Ambar_Amarillo", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Observaciones", SqlDbType.Text);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    sqlCommand.Parameters.Add("@Hongo_Inactivo", SqlDbType.Int);
                    sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Daño_Insectos"].Value = Convert.ToInt32(this.Txt_Daño.Text);
					sqlCommand.Parameters["@Vanas"].Value = Convert.ToInt32(this.Txt_Vanas.Text);
					sqlCommand.Parameters["@Reseca"].Value = Convert.ToInt32(this.Txt_Reseca.Text);
					sqlCommand.Parameters["@Hongo_Activo"].Value = Convert.ToInt32(this.Txt_HongoActivo.Text);
					sqlCommand.Parameters["@Extra_Light"].Value = Convert.ToInt32(this.Txt_Extra.Text);
					sqlCommand.Parameters["@Light"].Value = Convert.ToInt32(this.Txt_Light.Text);
					sqlCommand.Parameters["@Light_Ambar"].Value = Convert.ToInt32(this.Txt_LightAmbar.Text);
					sqlCommand.Parameters["@Ambar_Amarillo"].Value = Convert.ToInt32(this.Txt_Ambar.Text);
					sqlCommand.Parameters["@Observaciones"].Value = this.Txt_Observaciones.Text;
                    sqlCommand.Parameters["@Hongo_Inactivo"].Value = Convert.ToInt32(this.Txt_HongoInactivo.Text);
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

		public void update_encabezado()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateEncabezado", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Lote", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Variedad", SqlDbType.Char, 40);
					sqlCommand.Parameters.Add("@Productor", SqlDbType.Char, 10);
					sqlCommand.Parameters.Add("@Patio", SqlDbType.Text);
					sqlCommand.Parameters.Add("@Fecha_Recepcion", SqlDbType.Date);
					sqlCommand.Parameters.Add("@Fecha_Analisis", SqlDbType.Date);
					sqlCommand.Parameters.Add("@Tipo_Recepcion", SqlDbType.Text);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Analisis"].Value = this.Lbl_Analisis.Text;
					sqlCommand.Parameters["@Lote"].Value = this.Txt_Lote.Text;
					sqlCommand.Parameters["@Variedad"].Value = this.cmbVariedad.Text;
					sqlCommand.Parameters["@Productor"].Value = this.Txt_Productor.Text;
					sqlCommand.Parameters["@Patio"].Value = this.CmbPatio.Text;
					sqlCommand.Parameters["@Fecha_Recepcion"].Value = this.DT_Recepcion.Value;
					sqlCommand.Parameters["@Fecha_Analisis"].Value = this.DT_Analisis.Value;
					sqlCommand.Parameters["@Tipo_Recepcion"].Value = this.CmbRecepcion.Text;
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

		public void update_envases()
		{
           string x = evaluacion2();
         
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateEnvases", this.cn.getConexion());
					this.cn.Abrir();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Quebrados", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Dañados", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Productor", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Condicion", SqlDbType.Text);
					sqlCommand.Parameters.Add("@Anakena", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Condicion_Productor", SqlDbType.Text);
                    sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Quebrados"].Value = Convert.ToInt32(this.Txt_Quebrados.Text);
					sqlCommand.Parameters["@Dañados"].Value = Convert.ToInt32(this.TxtDañados.Text);
					sqlCommand.Parameters["@Productor"].Value = Convert.ToInt32(this.TxtCantidadProductor.Text);
					sqlCommand.Parameters["@Condicion"].Value = this.lbl_condiciones.Text;
					sqlCommand.Parameters["@Anakena"].Value = Convert.ToInt32(this.TxtCantidadAnakena.Text);
                    sqlCommand.Parameters["@Condicion_Productor"].Value = x;
                    sqlCommand.Parameters["@msg"].Value = 1;
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error SQL ", exception), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.cn.Cerrar();
            }
			
			finally
			{
				this.cn.Cerrar();
			}
		}

		public void update_inpurezas()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateInpurezas", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Num_Analisis", SqlDbType.Int);
					sqlCommand.Parameters.Add("@Piedra", SqlDbType.Float);
					sqlCommand.Parameters.Add("@Palo", SqlDbType.Float);
                    sqlCommand.Parameters.Add("@Pelon", SqlDbType.Float);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Num_Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
					sqlCommand.Parameters["@Piedra"].Value = Convert.ToDouble(this.Txt_Piedras.Text.Replace(",", "."), CultureInfo.InvariantCulture);
					sqlCommand.Parameters["@Palo"].Value = Convert.ToDouble(this.Txt_Palos.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                    sqlCommand.Parameters["@Pelon"].Value = Convert.ToDouble(Txt_Pelon.Text.Replace(",", "."), CultureInfo.InvariantCulture);
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

        private void Txt_Pelon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '\r' ? true : e.KeyChar == '.'))
            {
                MessageBox.Show("Solo se permiten numeros decimales con '.'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Palos.Text != ""))
            {
              	this.groupBox4.Enabled = true;
                Txt_Partidas.Enabled = true;
                Txt_Partidas.Focus();
            }
        }

        private void Txt_HongoInactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_HongoInactivo.Text != ""))
            {
                this.Txt_Extra.Enabled = true;
                this.Txt_Extra.Focus();
            }
        }

        private void Txt_HongoActivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Pelon_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}