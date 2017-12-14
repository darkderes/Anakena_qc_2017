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
	public class FormUsuarioMain : Form
	{
		private IContainer components = null;

		private DataGridView dataGridView1;

		private Button button1;

		private PictureBox pictureBox1;

		private Button button7;

		private conexion cn = new conexion();

		public FormUsuarioMain()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormUsuario formUsuario = new FormUsuario();
			formUsuario.CmbTipo.SelectedIndex = 0;
			formUsuario.btn_modificar.Enabled = false;
			formUsuario.Btn_Eliminar.Enabled = false;
			formUsuario.ShowDialog();
			this.traerUsuarios();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				try
				{
					FormUsuario formUsuario = new FormUsuario();
					formUsuario.txt_Rut.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Rut"].Value.ToString();
					formUsuario.txt_Rut.ReadOnly = true;
					formUsuario.txtPassword.Text = this.dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
					formUsuario.txt_repite.Text = this.dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
					formUsuario.txt_Nombre.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
					formUsuario.CmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
					formUsuario.CmbTipo.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Tipo Usuario"].Value.ToString();
					formUsuario.btn_guardar.Enabled = false;
					formUsuario.ShowDialog();
				}
				catch
				{
				}
			}
			finally
			{
				this.traerUsuarios();
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

		private void FormUsuarioMain_Load(object sender, EventArgs e)
		{
			this.traerUsuarios();
			this.dataGridView1.Columns["password"].Visible = false;
		}

		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(470, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(553, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 28);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormUsuarioMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(667, 435);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUsuarioMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FormUsuarioMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		public void traerUsuarios()
		{
			SqlCommand sqlCommand = new SqlCommand("spTraerUsuario", this.cn.getConexion())
			{
				CommandType = CommandType.StoredProcedure
			};
			this.cn.Abrir();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			this.dataGridView1.DataSource = dataSet.Tables[0];
			this.cn.Cerrar();
		}
	}
}