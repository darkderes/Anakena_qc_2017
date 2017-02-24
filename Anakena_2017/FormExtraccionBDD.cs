using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormExtraccionBDD : Form
	{
		private conexion cn = new conexion();

		private DataSet myds = new DataSet();

		private IContainer components = null;

		private DataGridView dataGridView1;

		private System.Windows.Forms.Button button1;

		private ComboBox Cmb_Variedad;

        private System.Windows.Forms.Button BtnBuscar;

		private System.Windows.Forms.TextBox Txt_Busqueda;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label4;

		private RadioButton radioButton1;

		private RadioButton radioButton2;

		private RadioButton radioButton3;

		private System.Windows.Forms.GroupBox groupBox1;

		private System.Windows.Forms.Button Btn_Limpiar;

		private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;

		public FormExtraccionBDD()
		{
			this.InitializeComponent();
		}

		private void Btn_Limpiar_Click(object sender, EventArgs e)
		{
			this.traerDistintosProductores();
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			string str = "";
			string str1 = "";
			if (this.radioButton2.Checked)
			{
				str1 = " AND Recepcion = 'Humeda'";
			}
			else if (this.radioButton3.Checked)
			{
				str1 = " AND Recepcion = 'Pelón'";
			}
			if (this.Cmb_Variedad.SelectedIndex != 0)
			{
				str = string.Concat(" AND Variedad = '", this.Cmb_Variedad.Text, "'");
			}
			if (!(this.Txt_Busqueda.Text != ""))
			{
				MessageBox.Show("Se debe ingresar productor para filtro de busqueda", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				string str2 = string.Concat("Productor = ", this.Txt_Busqueda.Text, str, str1);
				this.myds.Tables[0].DefaultView.RowFilter = str2;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.exporta_a_excel();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			base.Close();
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
					this.Cmb_Variedad.Refresh();
					this.Cmb_Variedad.DataSource = dataSet.Tables["Variedad"].DefaultView;
					this.Cmb_Variedad.DisplayMember = "Des_Variedad";
					this.Cmb_Variedad.ValueMember = "Cod_Variedad";
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

		private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
		}

		private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void exporta_a_excel()
		{
            try
            {
                var applicationClass = new Excel.Application();
                applicationClass.Workbooks.Add(true);
                int num = 0;
                foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                {
                    num++;
                    applicationClass.Cells[1, num] = column.Name;
                    applicationClass.get_Range("A1", "AE1").Interior.ColorIndex = 9;
                    applicationClass.get_Range("A1", "AE1").Font.ColorIndex = 2;
                }
                int num1 = 0;
                foreach (DataGridViewRow row in (IEnumerable)this.dataGridView1.Rows)
                {
                    num1++;
                    num = 0;
                    foreach (DataGridViewColumn dataGridViewColumn in this.dataGridView1.Columns)
                    {
                        num++;
                        applicationClass.Cells[num1 + 1, num] = row.Cells[dataGridViewColumn.Name].Value;
                    }
                }
                applicationClass.Visible = true;
                ((Excel.Worksheet)applicationClass.ActiveSheet).Name = "Reporte";
                ((Excel.Worksheet)applicationClass.ActiveSheet).Activate();
            }
            catch { }
        }

		private void FormExtraccionBDD_Load(object sender, EventArgs e)
		{
			this.traerDistintosProductores();
			this.radioButton1.Checked = true;
			this.CmbVariedad();
		}

		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtraccionBDD));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cmb_Variedad = new System.Windows.Forms.ComboBox();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(74, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1157, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Cmb_Variedad
            // 
            this.Cmb_Variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Variedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Variedad.FormattingEnabled = true;
            this.Cmb_Variedad.Items.AddRange(new object[] {
            "Humeda",
            "Pelón"});
            this.Cmb_Variedad.Location = new System.Drawing.Point(138, 61);
            this.Cmb_Variedad.Name = "Cmb_Variedad";
            this.Cmb_Variedad.Size = new System.Drawing.Size(185, 24);
            this.Cmb_Variedad.TabIndex = 13;
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Busqueda.Location = new System.Drawing.Point(137, 19);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(185, 22);
            this.Txt_Busqueda.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Productor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Variedad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo recepcion :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(196, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Humedas";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(270, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pelon";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.Btn_Limpiar);
            this.groupBox1.Controls.Add(this.Txt_Busqueda);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.Cmb_Variedad);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(394, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 133);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(218, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Busqueda Productor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(1116, 684);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 38);
            this.button7.TabIndex = 27;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.BackgroundImage")));
            this.Btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Limpiar.Location = new System.Drawing.Point(422, 16);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(88, 28);
            this.Btn_Limpiar.TabIndex = 20;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(328, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 28);
            this.BtnBuscar.TabIndex = 28;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(615, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 73);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormExtraccionBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1276, 752);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormExtraccionBDD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Base de Datos";
            this.Load += new System.EventHandler(this.FormExtraccionBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormBusquedaProductor formBusquedaProductor = new FormBusquedaProductor();
			formBusquedaProductor.ShowDialog();
			this.Txt_Busqueda.Text = formBusquedaProductor.codigo;
		}

		public void traerDistintosProductores()
		{
			SqlCommand sqlCommand = new SqlCommand("spTraerExtraccion", this.cn.getConexion())
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

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            string str = "";
            string str1 = "";
            if (this.radioButton2.Checked)
            {
                str1 = " AND Recepcion = 'Humeda'";
            }
            else if (this.radioButton3.Checked)
            {
                str1 = " AND Recepcion = 'Pelón'";
            }
            if (this.Cmb_Variedad.SelectedIndex != 0)
            {
                str = string.Concat(" AND Variedad = '", this.Cmb_Variedad.Text, "'");
            }
            if (!(this.Txt_Busqueda.Text != ""))
            {
                MessageBox.Show("Se debe ingresar productor para filtro de busqueda", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string str2 = string.Concat("Productor = ", this.Txt_Busqueda.Text, str, str1);
                this.myds.Tables[0].DefaultView.RowFilter = str2;
            }
        }
	}
}