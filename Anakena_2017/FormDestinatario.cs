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
        }
    }
}
