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
    public partial class FormBusquedaDestino : Form
    {
        public string nombre;
        public string rut;

        public FormBusquedaDestino()
        {
            InitializeComponent();
        }
        private void FormBusquedaDestino_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.spFiltroDestinatarioTableAdapter.Fill(this.prueba_2018DataSet.spFiltroDestinatario, textBox1.Text);
            }
        }

        private void spFiltroDestinatarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.nombre = spFiltroDestinatarioDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            this.rut = spFiltroDestinatarioDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            base.Close();
        }
    }
}
