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
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
        {
            InitializeComponent();
        }

        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            this.envaseTableAdapter.Fill(this.aNAKENADataSet.Envase);
        }
        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Codigo.Text != ""))
            {
            
                try
                {
                    this.spTraer_guia_productorTableAdapter.Fill(this.prueba_2017DataSet.spTraer_guia_productor, Txt_Codigo.Text, Txt_Rut.Text);
           
                        Txt_Rut.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                        Lbl_Productor.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               this.devolucion_EnvasesTableAdapter.InsertarDevolucion(dateTimePicker1.Value,Txt_NumGuia.Text,Txt_Codigo.Text,CmbEnvases.SelectedValue.ToString(),Convert.ToInt32(TxtCantidad.Text));
                MessageBox.Show("Devolución ingresada correctamente","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ex, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBusquedaProductor s = new FormBusquedaProductor();
            s.ShowDialog();
            Txt_Codigo.Text = s.codigo;
            this.spTraer_guia_productorTableAdapter.Fill(this.prueba_2017DataSet.spTraer_guia_productor, Txt_Codigo.Text, Txt_Rut.Text);
            Txt_Rut.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            Lbl_Productor.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn3"].Value.ToString();

        }
    }
}
