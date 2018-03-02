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
    public partial class FormAdministracionGuia : Form
    {
        string guia;
        public FormAdministracionGuia()
        {
            InitializeComponent();
        }

        private void FormAdministracionGuia_Load(object sender, EventArgs e)
        {
            spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
            spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
            this.spTraer_Administracion_GuiaTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia);
            CmbFiltro.SelectedIndex = 0;
        }

        private void spTraer_Administracion_GuiaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guia = spTraer_Administracion_GuiaDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormReporteGuia s = new FormReporteGuia(guia);
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (CmbFiltro.Text == "Guia")
                {
                    spTraer_Administracion_GuiaDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = true;
                    spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = false;
                    this.spTraer_Administracion_Guia_PorGuiaTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia_PorGuia, TxtFiltro.Text);
                }
                else
                if (CmbFiltro.Text == "Destinatario")
                {
                    spTraer_Administracion_GuiaDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorRutDataGridView.Visible = true;
                    this.spTraer_Administracion_Guia_PorRutTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia_PorRut, TxtFiltro.Text);
                }
                else
                if (CmbFiltro.Text == "Todos")
                {
                    this.spTraer_Administracion_GuiaTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia);
                    spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
                    spTraer_Administracion_GuiaDataGridView.Visible = true;
                    spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
                    spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = false;

                }
            }
        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFiltro.Text == "Guia")
            {
                TxtFiltro.Visible = true;
                CmbEstado.Visible = false;
            }
            else
             if (CmbFiltro.Text == "Destinatario")
            {
                TxtFiltro.Visible = true;
                CmbEstado.Visible = false;
            }
            else
             if (CmbFiltro.Text == "Todos")
            {
                TxtFiltro.Visible = false;
                CmbEstado.Visible = false;
                this.spTraer_Administracion_GuiaTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia);
                spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
                spTraer_Administracion_GuiaDataGridView.Visible = true;
                spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
                spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = false;

            }
            else
            if (CmbFiltro.Text == "Estado")
            {
                TxtFiltro.Visible = false;
                CmbEstado.Visible = true;
                CmbEstado.SelectedIndex = 0;
            }
        }

        private void spTraer_Administracion_Guia_PorRutDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               guia = spTraer_Administracion_Guia_PorRutDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn19"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void spTraer_Administracion_Guia_PorGuiaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex > 0)
                {  guia = spTraer_Administracion_Guia_PorGuiaDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn10"].Value.ToString();}
              
            }
            catch (Exception)
            {

                throw;
            }
          
        
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this,"Seguro desea anular guia :"+guia,"Anakena",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.guiaTableAdapter.ModificarEstadoGuia("Anulada", guia);
                    MessageBox.Show("Guia anuluda correctamente", "Anakena", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.spTraer_Administracion_GuiaTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia);
                    spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
                    spTraer_Administracion_GuiaDataGridView.Visible = true;
                    spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }


        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CmbEstado.SelectedIndex == 1)
            {
                this.spTraer_Administracion_Guia_PorEstadoTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia_PorEstado, CmbEstado.Text);
            }
            else  
            if (CmbEstado.SelectedIndex == 2)
            {
              
                this.spTraer_Administracion_Guia_PorEstadoTableAdapter.Fill(this.prueba_2018DataSet.spTraer_Administracion_Guia_PorEstado, CmbEstado.Text);
                
            }
            if (CmbEstado.SelectedIndex != 0)
            {
            spTraer_Administracion_Guia_PorGuiaDataGridView.Visible = false;
            spTraer_Administracion_GuiaDataGridView.Visible = false;
            spTraer_Administracion_Guia_PorRutDataGridView.Visible = false;
            spTraer_Administracion_Guia_PorEstadoDataGridView.Visible = true;
            }
           
        }

        private void spTraer_Administracion_Guia_PorEstadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
