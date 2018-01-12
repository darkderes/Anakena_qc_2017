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
    public partial class FormTransportistas : Form
    {
        public FormTransportistas()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarRut(TxtRut.Text))
                {
                    transportistaTableAdapter.Insert(TxtRut.Text, TxtTransportista.Text.ToUpper());

                    MessageBox.Show("Transportista ingresado correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rut incorrecto", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error :" + ex, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show(exception.ToString(), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return flag;
        }

    }
 
}
