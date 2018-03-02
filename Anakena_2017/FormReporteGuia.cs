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
    public partial class FormReporteGuia : Form
    {
        string x;
        string check1 = "1";
        string check2 = "1";
        string chech3 = "3";
        public FormReporteGuia(string guia)
        {
            InitializeComponent();
            x = guia;
        }

        private void FormReporteGuia_Load(object sender, EventArgs e)
        {
            try
            {  
                // TODO: esta línea de código carga datos en la tabla 'Prueba_2018DataSet.spTraer_Guia' Puede moverla o quitarla según sea necesario.
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia,x,"1","1","1");
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2018DataSet.Traer_DetalleGuia' Puede moverla o quitarla según sea necesario.
            this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia,x);
                Traer_TransporteTableAdapter.Fill(Prueba_2018DataSet.Traer_Transporte, x);
            this.reportViewer1.RefreshReport();

            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                check1 = "0";
            }
            else
            {
                check1 = "1";
            }
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia,x, check1, check2,chech3);
              this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia,x);
            this.reportViewer1.RefreshReport();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                check2 = "0";
            }
            else
            {
                check2 = "1";
            }
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia, x, check1, check2,chech3);
            this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia, x);
            this.reportViewer1.RefreshReport();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                chech3 = "0";
            }
            else
            {
                chech3 = "1";
            }
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia, x, check1, check2, chech3);
            this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia, x);
            this.reportViewer1.RefreshReport();
        }
    }
}
