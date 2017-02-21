using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormUsuario : Form
	{
		private IContainer components = null;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private PictureBox pictureBox1;

		private Label label6;

		public TextBox txt_Rut;

		public TextBox txtPassword;

		public TextBox txt_Nombre;

		public ComboBox CmbTipo;

		public TextBox txt_repite;

		public Button btn_guardar;

		public Button btn_modificar;

		public Button Btn_Eliminar;

		private conexion cn = new conexion();

		public FormUsuario()
		{
			this.InitializeComponent();
		}

		public void actualizar_Usuarios()
		{
			char chr;
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spUpdateUsuarios", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Rut", SqlDbType.VarChar, 10);
					sqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
					sqlCommand.Parameters.Add("@password", SqlDbType.VarChar, 300);
					sqlCommand.Parameters.Add("@tipo", SqlDbType.Char, 1);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Rut"].Value = this.txt_Rut.Text;
					sqlCommand.Parameters["@nombre"].Value = this.txt_Nombre.Text.ToUpper();
					sqlCommand.Parameters["@password"].Value = this.txtPassword.Text;
					chr = (!(this.CmbTipo.Text == "Administrador") ? '2' : '1');
					sqlCommand.Parameters["@tipo"].Value = chr;
					sqlCommand.Parameters["@msg"].Value = 1;
					this.cn.Abrir();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
					MessageBox.Show("Usuario modificado correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void Btn_Eliminar_Click(object sender, EventArgs e)
		{
			this.eliminar_Usuarios();
			base.Close();
		}

		private void btn_guardar_Click(object sender, EventArgs e)
		{
			if (!(this.txtPassword.Text == this.txt_repite.Text))
			{
				this.txtPassword.Text = "";
				this.txt_repite.Text = "";
				this.txtPassword.Focus();
				MessageBox.Show("Contraseñas ingresadas no concuerdan", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (this.CmbTipo.SelectedIndex == 0)
			{
				MessageBox.Show("Debe completar nombre del usuario", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txt_Nombre.Focus();
			}
			else if (!(this.txt_Nombre.Text != ""))
			{
				MessageBox.Show("Nombre no puede ser vacio", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.ingresar_Usuarios();
				base.Close();
			}
		}

		private void btn_modificar_Click(object sender, EventArgs e)
		{
			if (!(this.txtPassword.Text == this.txt_repite.Text))
			{
				this.txtPassword.Text = "";
				this.txt_repite.Text = "";
				this.txtPassword.Focus();
				MessageBox.Show("Contraseñas ingresadas no concuerdan", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (this.CmbTipo.SelectedIndex == 0)
			{
				MessageBox.Show("Debe completar nombre del usuario", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txt_Nombre.Focus();
			}
			else if (!(this.txt_Nombre.Text != ""))
			{
				MessageBox.Show("Nombre no puede ser vacio", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.actualizar_Usuarios();
				base.Close();
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

		public void eliminar_Usuarios()
		{
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spDeleteUsuarios", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Rut", SqlDbType.VarChar, 10);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Rut"].Value = this.txt_Rut.Text;
					sqlCommand.Parameters["@msg"].Value = 1;
					this.cn.Abrir();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
					MessageBox.Show("Usuario eliminado correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void FormUsuario_Load(object sender, EventArgs e)
		{
		}

		public void ingresar_Usuarios()
		{
			char chr;
			try
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand("spAgregaUsuario", this.cn.getConexion())
					{
						CommandType = CommandType.StoredProcedure
					};
					sqlCommand.Parameters.Add("@Rut", SqlDbType.VarChar, 10);
					sqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 40);
					sqlCommand.Parameters.Add("@password", SqlDbType.VarChar, 300);
					sqlCommand.Parameters.Add("@tipo", SqlDbType.Char, 1);
					sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);
					sqlCommand.Parameters["@Rut"].Value = this.txt_Rut.Text;
					sqlCommand.Parameters["@nombre"].Value = this.txt_Nombre.Text.ToUpper();
					sqlCommand.Parameters["@password"].Value = this.txtPassword.Text;
					chr = (!(this.CmbTipo.Text == "Administrador") ? '2' : '1');
					sqlCommand.Parameters["@tipo"].Value = chr;
					sqlCommand.Parameters["@msg"].Value = 1;
					this.cn.Abrir();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Parameters["@msg"].Value.ToString();
					MessageBox.Show("Usuario ingresado correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.txt_Rut = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_repite = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Rut
            // 
            this.txt_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rut.Location = new System.Drawing.Point(158, 100);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(155, 26);
            this.txt_Rut.TabIndex = 0;
            this.txt_Rut.Leave += new System.EventHandler(this.txt_Rut_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(158, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(158, 140);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 26);
            this.txt_Nombre.TabIndex = 1;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "--Seleccione Opcion--",
            "Administrador",
            "Normal"});
            this.CmbTipo.Location = new System.Drawing.Point(158, 270);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(203, 28);
            this.CmbTipo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo usuario:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(33, 329);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 35);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "(sin puntos,con guion)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repita password:";
            // 
            // txt_repite
            // 
            this.txt_repite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repite.Location = new System.Drawing.Point(158, 227);
            this.txt_repite.Name = "txt_repite";
            this.txt_repite.PasswordChar = '*';
            this.txt_repite.Size = new System.Drawing.Size(228, 26);
            this.txt_repite.TabIndex = 3;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(167, 329);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(122, 35);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.BackgroundImage")));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.Location = new System.Drawing.Point(304, 329);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(126, 35);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(455, 379);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_repite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txt_Rut);
            this.Name = "FormUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void txt_Rut_Leave(object sender, EventArgs e)
		{
			bool flag = this.validarRut(this.txt_Rut.Text);
			if (!flag)
			{
				MessageBox.Show("Rut incorrecto", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.txt_Rut.Focus();
				this.btn_guardar.Enabled = false;
			}
			else if ((!flag ? false : !this.txt_Rut.ReadOnly))
			{
				this.btn_guardar.Enabled = true;
			}
		}

		public bool validarRut(string rut)
		{
			bool flag = false;
			try
			{
				rut = rut.ToUpper();
				rut = rut.Replace(".", "");
				rut = rut.Replace("-", "");
				int num = int.Parse(rut.Substring(0, rut.Length - 1));
				char chr = char.Parse(rut.Substring(rut.Length - 1, 1));
				int num1 = 0;
				int num2 = 1;
				while (num != 0)
				{
					int num3 = num1;
					num1 = num3 + 1;
					num2 = (num2 + num % 10 * (9 - num3 % 6)) % 11;
					num = num / 10;
				}
				if (chr == (char)((num2 != 0 ? num2 + 47 : 75)))
				{
					flag = true;
				}
			}
			catch (Exception exception)
			{
			}
			return flag;
		}
	}
}