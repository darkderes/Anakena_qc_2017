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
    public partial class FormAdminDireccion : Form
    {
        public FormAdminDireccion()
        {
            InitializeComponent();
        }



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((rut_DestinatarioTextBox.Text != "") && (direccionTextBox.Text != "") && (comunaTextBox.Text != ""))
                {
                    direccionTableAdapter.InsertarDireccion(rut_DestinatarioTextBox.Text.ToUpper(), direccionTextBox.Text.ToUpper(), comunaTextBox.Text.ToUpper());
                    MessageBox.Show("Direccion de ingresada correctamente ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
