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
    public partial class FormDestinatario : Form
    {
        public FormDestinatario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminDireccion s = new FormAdminDireccion();
            s.rut_DestinatarioTextBox.Text = Txt_Rut.Text;
            s.ShowDialog();
            this.direccionTableAdapter.FillByRut(this.prueba_2017DataSet.Direccion,Txt_Rut.Text);
        }

        private void FormDestinatario_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (LblDestinatario.Text == "Clientes")
            {
                tipo = 2;
            }
            else
            if (LblDestinatario.Text == "Proveedores")
            {
                tipo = 3;
            }
            else
            if (LblDestinatario.Text == "Particulares")
            {
                tipo = 5;
            }
            try
            {
                destinatarioTableAdapter.InsertarDestinatario(Txt_Rut.Text,Txt_Destinatario.Text,Txt_Giro.Text,Txt_Fono.Text,tipo.ToString());
                MessageBox.Show(LblDestinatario.Text + " ingresado perfectamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Sqlexception Ex)
            {
                MessageBox.Show("Error: "+Ex.Message,"Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                throw;
            }
           
        }
    }
}
