using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormLogin : Form
	{
		private conexion cn = new conexion();
        private IContainer components = null;
		private TextBox Txt_Rut;
		private TextBox TxtPass;
        private PictureBox Pc_New;
        private Button button1;

		public FormLogin()
		{
			Thread thread = new Thread(new ThreadStart(this.screen1));
			thread.Start();
			Thread.Sleep(7000);
			this.InitializeComponent();
			thread.Abort();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.login();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			if ((int)Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
			{
				MessageBox.Show("La aplicación ya se está ejecutando...");
				base.Close();
			}
		}

		private void InitializeComponent()
		{
            this.Txt_Rut = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pc_New = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pc_New)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Rut
            // 
            this.Txt_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Rut.Location = new System.Drawing.Point(12, 210);
            this.Txt_Rut.Name = "Txt_Rut";
            this.Txt_Rut.Size = new System.Drawing.Size(168, 26);
            this.Txt_Rut.TabIndex = 2;
            this.Txt_Rut.Tag = "";
            this.Txt_Rut.Text = "RUT";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(12, 254);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(168, 26);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.Text = "PASSWORD";
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pc_New
            // 
            this.Pc_New.Image = global::Anakena_2017.Properties.Resources.compartir_anakena;
            this.Pc_New.Location = new System.Drawing.Point(-5, -3);
            this.Pc_New.Name = "Pc_New";
            this.Pc_New.Size = new System.Drawing.Size(200, 195);
            this.Pc_New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pc_New.TabIndex = 5;
            this.Pc_New.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(195, 366);
            this.Controls.Add(this.Pc_New);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.Txt_Rut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pc_New)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public void login()
		{
			string str = "";
			string str1 = "";
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerLogin", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Rut", this.Txt_Rut.Text);
			sqlCommand.Parameters.AddWithValue("@Password", this.TxtPass.Text);
			sqlDataAdapter.Fill(new DataSet(), "producto");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
					str = sqlDataReader[0].ToString();
					str1 = sqlDataReader[1].ToString();
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
			if (!(str != ""))
			{
				MessageBox.Show("login incorrecto");
			}
			else
			{
				base.Hide();
                FormPrincipal formPrincipal = new FormPrincipal(str1);
                formPrincipal.lbl_poductor.Text = str;
                formPrincipal.ShowDialog();
                base.Close();
			}
		}

		public void screen1()
		{
			Application.Run(new splash());
		}

		private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Rut.Text != ""))
			{
				this.login();
			}
		}

		private void TxtPass_TextChanged(object sender, EventArgs e)
		{
			this.TxtPass.UseSystemPasswordChar = true;
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
	}
}