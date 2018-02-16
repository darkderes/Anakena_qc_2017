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
    public partial class FormReportGuia : Form
    {
        public string check1 = "1";
        public string check2 = "1";
        string guia ;
        public FormReportGuia(string num_guia)
        {
            InitializeComponent();
            guia = num_guia;
        }

        private void FormReportGuia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2018DataSet.spTraer_Guia' Puede moverla o quitarla según sea necesario.
           this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia,"5000","1","1");
       //   this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia, "5000");
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
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
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia, guia,check1,check2);
       //     this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia,guia);
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
            this.spTraer_GuiaTableAdapter.Fill(this.Prueba_2018DataSet.spTraer_Guia,guia, check1, check2);
        //    this.Traer_DetalleGuiaTableAdapter.Fill(this.Prueba_2018DataSet.Traer_DetalleGuia,guia);
            this.reportViewer1.RefreshReport();
        }
    }
}
