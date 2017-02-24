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
    public partial class FormReport : Form
    {
        int report_analisis;
        string condicion_analisis;
        public FormReport(int Analisis,string condicion)
        {
            InitializeComponent();
            report_analisis = Analisis;
            condicion_analisis = condicion;

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017DataSet.spTraerReporte' Puede moverla o quitarla según sea necesario.
            this.spTraerReporteTableAdapter.Fill(this.Prueba_2017DataSet.spTraerReporte,report_analisis,condicion_analisis);
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017DataSet1.spTraerReporte' Puede moverla o quitarla según sea necesario.


          
            this.reportViewer2.RefreshReport();
        }
    }
}
