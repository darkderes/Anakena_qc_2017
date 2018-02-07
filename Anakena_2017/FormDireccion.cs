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
    public partial class FormDireccion : Form
    {
        public String direccion = "";
        public String comuna = "";
        public String id = "";
        public String rut = "";
        public FormDireccion()
        {
            InitializeComponent();
        }

        private void direccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.direccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prueba_2017DataSet);

        }

        private void FormDireccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_2017DataSet.Direccion' Puede moverla o quitarla según sea necesario.
            this.direccionTableAdapter.FillByRut(this.prueba_2017DataSet.Direccion,rut);

        }

        private void direccionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = direccionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            direccion = direccionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            comuna = direccionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            this.Close();
        }
    }
}
