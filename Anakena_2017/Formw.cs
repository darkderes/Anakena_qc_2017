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
    public partial class FormReport_PPM : Form
    {
        int Analisis = 0;
        public FormReport_PPM(int analisis_padre)
        {
            InitializeComponent();
            Analisis = analisis_padre;
        }

        private void FormReport_PPM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017_PMM.spTraerReporte_Analisis_Calidad_PMM' Puede moverla o quitarla según sea necesario.
            this.spTraerReporte_Analisis_Calidad_PMMTableAdapter.Fill(this.Prueba_2017_PMM.spTraerReporte_Analisis_Calidad_PMM,Analisis);

            this.reportViewer1.RefreshReport();
        }
    }
}
