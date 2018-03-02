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
    public partial class FormEmisionGuia : Form
    {
        char tipo_guia = '0';
        string RUT = null;
        string CODIGO = null;
        short id = 0;
        public string usuario;
        public FormEmisionGuia(string user)
        {
            usuario = user;
            InitializeComponent();
        }
        private void FormEmisionGuia_Load(object sender, EventArgs e)
        {
            this.envaseTableAdapter.Fill(this.aNAKENADataSet.Envase);
            radioButton1.Checked = true;
            radioButton8.Checked = true;
            CmbUnidad.SelectedIndex = 0;
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245,25);
                button3.Location = new Point(280, 25);
            }
            else
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                LblCodigo.Visible = false;
                TxtCodigo.Visible = false;
                button2.Location = new Point(141, 25);
                button3.Location = new Point(176, 25);
                this.destinatarioTableAdapter.FillByDestinatario(this.prueba_2017DataSet1.Destinatario,"78185710-6", "2");
                if (destinatarioDataGridView.RowCount > 0)
                {
                    Txt_Rut.Text = "78185710-6";
                    LblDestinatario.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn20"].Value.ToString();
                    LblGiro.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn21"].Value.ToString();
                    LblFono.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                    CargaDireccion();
                }
                else
                {
                    MessageBox.Show("Datos no se encuentran registrado", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                LblCodigo.Visible = true;
                TxtCodigo.Visible = true;
                button2.Location = new Point(245, 25);
                button3.Location = new Point(280, 25);
            }
        }
        private void button4_Click(object sender, EventArgs e)         
        {
            if (traer_DetalleGuiaDataGridView.RowCount <= 18)
            {
                if ((TxtCantidad.TextLength > 0) && (TxtPrecio.TextLength > 0) && (Txt_NumGuia.Text.Length > 0))
                {
                    string tipo_detalle = "";
                    string descripcion = "";
                    string envases = "";
                    if (radioButton8.Checked)
                    {
                        tipo_detalle = "1";
                        descripcion = "";
                        envases = CmbEnvases.SelectedValue.ToString();
                    }
                    else
                    if (radioButton7.Checked)
                    {
                        tipo_detalle = "2";
                        descripcion = TxtDescripcion.Text.ToUpper();
                        envases = null;
                    }
                    else
                    if (radioButton6.Checked)
                    {
                        tipo_detalle = "3";
                        descripcion = CmbProductos.Text.ToUpper();
                        envases = null;
                    }
                    this.detalle_GuiaTableAdapter.InsertarDetalle(Txt_NumGuia.Text, tipo_detalle, Convert.ToInt32(TxtCantidad.Text), descripcion, Convert.ToInt32(TxtPrecio.Text), envases, CmbUnidad.Text);
                    this.traer_DetalleGuiaTableAdapter.Fill(this.prueba_2017DataSet1.Traer_DetalleGuia, Txt_NumGuia.Text);
                }
                else
                {
                    MessageBox.Show("Debe rellenar los datos de cantidad y precio para poder agregar", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten detallar como maximo 18 descripciones de producto,Si necesita mas realice una nueva guia", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            FormTransportistas s = new FormTransportistas();
            s.ShowDialog();
            TxtRut.Text = s.TxtRut.Text;
            Lbl_Transportista.Text = s.TxtTransportista.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDestinatario s = new FormDestinatario();
            if (radioButton2.Checked == true)
            {
                s.LblDestinatario.Text = "Clientes";
            }
            else
            if (radioButton3.Checked == true)
            {
                s.LblDestinatario.Text = "Proveedores";
            }
            else
            if (radioButton5.Checked == true)
            {
                s.LblDestinatario.Text = "Particulares";
            }
            if ((radioButton4.Checked == false)&&(radioButton1.Checked == false))
            {
              s.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este tipo de guia no soporta el ingreso de nuevos datos","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }           
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                CmbProductos.SelectedIndex = 0;
                CmbProductos.Visible = true;
                TxtDescripcion.Visible = false;
                CmbEnvases.Visible = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                CmbProductos.Visible = false;
                TxtDescripcion.Visible = true;
                CmbEnvases.Visible = false;
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                CmbProductos.Visible = false;
                TxtDescripcion.Visible = false;
                CmbEnvases.Visible = true;
                CmbEnvases.SelectedIndex = 0;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            detalle_GuiaTableAdapter.BorrarDetalle(id);
            this.traer_DetalleGuiaTableAdapter.Fill(this.prueba_2017DataSet1.Traer_DetalleGuia, Txt_NumGuia.Text);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        private void TxtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            string dato = "";
            if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.TxtRut.Text != ""))
            {
             
                transportistaTableAdapter1.FiltroRut(this.prueba_2017DataSet1.Transportista,TxtRut.Text);
                try
                {
                     dato = transportistaDataGridView.Rows[0].Cells[1].Value.ToString();
                }
                catch (Exception)
                {
             
                }
              
                if (!String.IsNullOrEmpty(dato))
                {
                  Lbl_Transportista.Text = dato;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Transportista no registrado en base de datos, desea registrarlo", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        FormTransportistas s = new FormTransportistas();
                        s.TxtRut.Text = TxtRut.Text;
                        s.ShowDialog();
                        Lbl_Transportista.Text = s.TxtTransportista.Text;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (traer_DetalleGuiaDataGridView.RowCount > 0)
            {
                try
                {
                    if ((!String.IsNullOrEmpty(Txt_NumGuia.Text)) && (!String.IsNullOrEmpty(tipo_guia.ToString())))
                    {
                        if (TxtRut.TextLength > 0)
                        {
                            try
                            {
                                this.guiaTableAdapter.InsertarGuia(Txt_NumGuia.Text, tipo_guia.ToString(), Txt_Rut.Text, Txt_Orden.Text, id, Convert.ToDateTime(LblFecha.Text), "Emitida", usuario);
                            }
                            catch (Sqlexception ez)
                            {
                                MessageBox.Show(ez.Message);
                            }
                            transporte1TableAdapter.InsertarTransporte(Txt_NumGuia.Text, TxtRut.Text, TxtPatente.Text.ToUpper(), TxtCarro.Text.ToUpper());
                            MessageBox.Show("Guia ingresada correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormReporteGuia s = new FormReporteGuia(Txt_NumGuia.Text);
                            s.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("De ingresar un trasportista", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtRut.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los valores solicitados", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("no puede ingresar datos sin describir elementos ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                FormBusquedaProductor s = new FormBusquedaProductor();
                s.ShowDialog();
                TxtCodigo.Text = s.codigo;
                Datos_Destiantario();
                if (spTraer_guia_productorDataGridView.RowCount > 0)
                {
                    CargaDireccion();
                    Link_Direccion.Visible = true;
                }
            }
            else
            {
                FormBusquedaDestino s = new FormBusquedaDestino();
                s.ShowDialog();
                Txt_Rut.Text = s.rut;

                Datos_Destiantario();
                if ((spTraer_guia_productorDataGridView.RowCount > 0) || (destinatarioDataGridView.RowCount > 0))
                {
                    CargaDireccion();
                    Link_Direccion.Visible = true;
                }

            }


        }
        public void Datos_Destiantario()
        {
          
          if (radioButton1.Checked)
            {
                tipo_guia = '1';
            }
            else
            if (radioButton2.Checked)
            {
                tipo_guia = '2';
            }
            else
            if (radioButton3.Checked)
            {
                tipo_guia = '3';
            }
            else
            if (radioButton4.Checked)
            {
                tipo_guia = '4';
            }
            else
            if (radioButton5.Checked)
            {
                tipo_guia = '5';
            }
            if (tipo_guia == '1')//destinatoria de Productor
            {
                if (Txt_Rut.TextLength > 0)
                {
                    RUT = Txt_Rut.Text;
                }
                else
                if (TxtCodigo.TextLength > 0)
                {
                    CODIGO = TxtCodigo.Text;
                }
                try
                {
                    this.spTraer_guia_productorTableAdapter.Fill(this.prueba_2017DataSet1.spTraer_guia_productor, CODIGO, RUT);
                    if (spTraer_guia_productorDataGridView.RowCount > 0)
                    {
                        TxtCodigo.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn13"].Value.ToString();
                        Txt_Rut.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn14"].Value.ToString();
                        LblDestinatario.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn15"].Value.ToString();
                        LblGiro.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn18"].Value.ToString();
                        LblFono.Text = spTraer_guia_productorDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn17"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Datos no se encuentran registrado", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Sqlexception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
            else if (tipo_guia == '2')
            {
                
                 this.destinatarioTableAdapter.FillByDestinatario(this.prueba_2017DataSet1.Destinatario, Txt_Rut.Text, "2");
                if (destinatarioDataGridView.RowCount > 0)
                {
                    LblDestinatario.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn20"].Value.ToString();
                    LblGiro.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn21"].Value.ToString();
                    LblFono.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Datos no se encuentran registrado", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else if (tipo_guia == '3')
            {

                this.destinatarioTableAdapter.FillByDestinatario(this.prueba_2017DataSet1.Destinatario, Txt_Rut.Text, "3");
                if (destinatarioDataGridView.RowCount > 0)
                {
                    LblDestinatario.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn20"].Value.ToString();
                    LblGiro.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn21"].Value.ToString();
                    LblFono.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Datos no se encuentran registrado", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else if (tipo_guia == '5')
            {

                this.destinatarioTableAdapter.FillByDestinatario(this.prueba_2017DataSet1.Destinatario, Txt_Rut.Text, "5");
                if (destinatarioDataGridView.RowCount > 0)
                {
                    LblDestinatario.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn20"].Value.ToString();
                    LblGiro.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn21"].Value.ToString();
                    LblFono.Text = destinatarioDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Datos no se encuentran registrado", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void Txt_Rut_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.Txt_Rut.Text != ""))
            {
                Datos_Destiantario();
                if ((spTraer_guia_productorDataGridView.RowCount > 0)||(destinatarioDataGridView.RowCount > 0))
                {
                    CargaDireccion();
                    Link_Direccion.Visible = true;
                }
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != Convert.ToChar(Keys.Return) ? false : this.TxtCodigo.Text != ""))
            {
                Datos_Destiantario();
                if(spTraer_guia_productorDataGridView.RowCount > 0)
                {
                CargaDireccion();
                Link_Direccion.Visible = true;
                }
            }
        }

        public void CargaDireccion()
        {
            try
            {
                this.direccionTableAdapter.FillByRut(this.prueba_2017DataSet1.Direccion, Txt_Rut.Text);

                if (direccionDataGridView.RowCount == 0)
                {

                    switch (MessageBox.Show("No existe direccion agregadas,Desea agregarla ??", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case System.Windows.Forms.DialogResult.Yes:
                            {
                                FormAdminDireccion d = new FormAdminDireccion();
                                d.rut_DestinatarioTextBox.Text = Txt_Rut.Text;
                                d.rut_DestinatarioTextBox.ReadOnly = true;
                                d.ShowDialog();
                                this.direccionTableAdapter.FillByRut(this.prueba_2017DataSet1.Direccion, Txt_Rut.Text);
                                id = Convert.ToInt16(direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn3"].Value.ToString());
                                LblDireccion.Text = direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                                LblComuna.Text = direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                                break;
                            }
                    }

                }
                else if (direccionDataGridView.RowCount == 1)
                {
                    id = Convert.ToInt16(direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn3"].Value.ToString());
                    LblDireccion.Text = direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    LblComuna.Text = direccionDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                }
                else if (direccionDataGridView.RowCount > 1)
                {
                    FormDireccion s = new FormDireccion();
                    s.rut = Txt_Rut.Text;
                    s.ShowDialog();
                    //   this.direccionTableAdapter.FillByRut(this.prueba_2017DataSet1.Direccion, Txt_Rut.Text);
                    id = Convert.ToInt16(s.id);
                    LblDireccion.Text = s.direccion;
                    LblComuna.Text = s.comuna;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
           
    }

        private void Link_Direccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminDireccion d = new FormAdminDireccion();
            d.rut_DestinatarioTextBox.Text = Txt_Rut.Text;
            d.rut_DestinatarioTextBox.ReadOnly = true;
            d.ShowDialog();
            LblDireccion.Text = d.direccionTextBox.Text;
            LblComuna.Text = d.comunaTextBox.Text;
        }

        private void traer_DetalleGuiaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(traer_DetalleGuiaDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Txt_Rut.Text = "";
            TxtCodigo.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormBusquedaProductor s = new FormBusquedaProductor();
                s.ShowDialog();
                TxtCodigo.Text = s.codigo;
                Datos_Destiantario();
                if (spTraer_guia_productorDataGridView.RowCount > 0)
                {
                    CargaDireccion();
                    Link_Direccion.Visible = true;
                }
            }
            else
            {
                FormBusquedaDestino s = new FormBusquedaDestino();
                s.ShowDialog();
                Txt_Rut.Text = s.rut;
              
                Datos_Destiantario();
                if ((spTraer_guia_productorDataGridView.RowCount > 0) || (destinatarioDataGridView.RowCount > 0))
                {
                    CargaDireccion();
                    Link_Direccion.Visible = true;
                }

            }
        }
    }
    
}
