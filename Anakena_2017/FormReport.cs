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
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Prueba_2017DataSet1.spTraerReporte' Puede moverla o quitarla según sea necesario.
            this.spTraerReporteTableAdapter.Fill(this.Prueba_2017DataSet1.spTraerReporte,1148,"Rojo");

            this.reportViewer1.RefreshReport();
        }
    }
}
