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
    public partial class FormReporte_Analisis_Productor : Form
    {
        int report_analisis;
        string condicion_analisis;
        public FormReporte_Analisis_Productor(int Analisis, string condicion)
        {
            InitializeComponent();
            report_analisis = Analisis;
            condicion_analisis = condicion;
        }

        private void FormReporte_Analisis_Productor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017DataSet.spTraerReporte' Puede moverla o quitarla según sea necesario.
            this.spTraerReporteTableAdapter.Fill(this.Prueba_2017DataSet.spTraerReporte, report_analisis, condicion_analisis);

            this.reportViewer1.RefreshReport();
        }
    }
}
