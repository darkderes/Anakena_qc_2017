using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anakena_2017
{
    public partial class FormEmisionGuia : Form
    {
        public FormEmisionGuia()
        {
            InitializeComponent();
        }
        private void FormEmisionGuia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aNAKENADataSet.Envase' Puede moverla o quitarla según sea necesario.
            this.envaseTableAdapter.Fill(this.aNAKENADataSet.Envase);
            radioButton1.Checked = true;
            radioButton8.Checked = true;
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245,25);
                button3.Location = new Point(280, 25);
            }
            else
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultaDetalle();
        }
        public void consultaDetalle()
        {
            DataTable myds = new DataTable();
            DataGridViewRow filaNueva = new DataGridViewRow();
            DataGridViewCell Cantidad = new DataGridViewTextBoxCell();
            DataGridViewCell Descripcion = new DataGridViewTextBoxCell();
            DataGridViewCell Precio = new DataGridViewTextBoxCell();
            Cantidad.Value = TxtCantidad.Text;
            if (radioButton6.Checked == true)
            {
                Descripcion.Value = CmbProductos.Text;
            }
            else
            if (radioButton7.Checked == true)
            {
                Descripcion.Value = TxtDescripcion.Text;
            }
            else
            if (radioButton8.Checked == true)
            {
                Descripcion.Value = CmbEnvases.Text;
                MessageBox.Show(CmbEnvases.SelectedValue.ToString());
            }
     
            Precio.Value = TxtPrecio.Text;
            filaNueva.Cells.Add(Cantidad);
            filaNueva.Cells.Add(Descripcion);
            filaNueva.Cells.Add(Precio);
        
            dataGridView1.Rows.Add(filaNueva);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTransportistas s = new FormTransportistas();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDestinatario s = new FormDestinatario();
            if (radioButton2.Checked == true)
            {
                s.LblDestinatario.Text = "Clientes";
            }
            else
            if (radioButton3.Checked == true)
            {
                s.LblDestinatario.Text = "Proveedores";
            }
            else
            if (radioButton5.Checked == true)
            {
                s.LblDestinatario.Text = "Particulares";
            }

            if ((radioButton4.Checked == false)&&(radioButton1.Checked == false))
            {
              s.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este tipo de guia no soporta el ingreso de nuevos datos","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                CmbProductos.SelectedIndex = 0;
                CmbProductos.Visible = true;
                TxtDescripcion.Visible = false;
                CmbEnvases.Visible = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                CmbProductos.Visible = false;
                TxtDescripcion.Visible = true;
                CmbEnvases.Visible = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                CmbProductos.Visible = false;
                TxtDescripcion.Visible = false;
                CmbEnvases.Visible = true;
                CmbEnvases.SelectedIndex = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("no pude eliminar datos, si no existen ingresadas", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
