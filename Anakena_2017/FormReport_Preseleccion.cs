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
    public partial class FormReport_Preseleccion : Form
    {
        int analisis = 0;
        public FormReport_Preseleccion(int analisis_Padre)
        {
            InitializeComponent();
            analisis = analisis_Padre;
        }

        private void FormReport_Preseleccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017Preseleccion.spTraerReporte_Analisis_Calidad_Preseleccion' Puede moverla o quitarla según sea necesario.
            this.spTraerReporte_Analisis_Calidad_PreseleccionTableAdapter.Fill(this.Prueba_2017Preseleccion.spTraerReporte_Analisis_Calidad_Preseleccion,analisis);

            this.reportViewer1.RefreshReport();
        }
    }
}
