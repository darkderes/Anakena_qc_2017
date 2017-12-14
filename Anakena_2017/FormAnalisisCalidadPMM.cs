using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Anakena_2017
{
   
    public partial class FormAnalisisCalidadPMM : Form
    {
        conexion cn = new conexion();
        private DataSet myds = new DataSet();
        public FormAnalisisCalidadPMM()
        {
            InitializeComponent();
        }

        private void FormAnalisisCalidadPMM_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            Btn_Agregar.Visible = false;
            button1.Visible  = false;
            Control.CheckForIllegalCrossThreadCalls = false;
 
            Thread hilo = new Thread(new ThreadStart(this.cargarDatos));
            hilo.Start();

        }
        public void cargarDatos()
        {
               this.spTraer_Analisis_Calidad_PPMTableAdapter.Fill(this.prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM);
            Cmb_Busqueda.SelectedIndex = 0;
            panel1.Visible = false;
            pictureBox1.Visible = true;
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
            Btn_Agregar.Visible = true;
            button1.Visible = true;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Cmb_Busqueda.Text == "Analisis")
            {

                string str2 = string.Concat("Analisis = ", txt_filtro.Text);
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
              
            }
           else
           if (Cmb_Busqueda.Text == "Bins")
            {
                string str2 = string.Concat("Bins = ", txt_filtro.Text);
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
               if (Cmb_Busqueda.Text == "Proceso")
            {
                string str2 = string.Concat("Proceso = ", txt_filtro.Text);
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
           if (Cmb_Busqueda.Text == "Estado")
            {
                string str2 = string.Concat("Estado like '", Cmb_Filtro.Text, "'");
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
           if (Cmb_Busqueda.Text == "Turno")
            {
                string str2 = string.Concat("Turno like '", Cmb_Filtro.Text, "'");
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
           if (Cmb_Busqueda.Text == "Fecha")
            {
                string str2 = string.Concat("Fecha = '", DT_Fecha.Text, "'");
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
               if (Cmb_Busqueda.Text == "Producto Analisis")
            {
                string str2 = string.Concat("Producto_Analisis = '", Cmb_Filtro.Text, "'");
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            else
                   if (Cmb_Busqueda.Text == "Producto Tarja")
            {
                string str2 = string.Concat("Producto_Tarja = '", Cmb_Filtro.Text, "'");
                prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM.DefaultView.RowFilter = str2;
            }
            if (dataGridView1.RowCount < 0)
            {
                MessageBox.Show("no existen datos para el parametro de busqueda", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
            }
            dataGridView1.DataSource = prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPartidoMecanico s = new FormPartidoMecanico();
            s.timer1.Enabled = false;
            s.Lbl_Analisis.Text = dataGridView1.Rows[e.RowIndex].Cells["analisisDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_proceso.Text = dataGridView1.Rows[e.RowIndex].Cells["procesoDataGridViewTextBoxColumn"].Value.ToString();
            s.DT_Calidad.Text = dataGridView1.Rows[e.RowIndex].Cells["fechaDataGridViewTextBoxColumn"].Value.ToString();
            s.TxtBins.Text = dataGridView1.Rows[e.RowIndex].Cells["binsDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Tarja.Text = dataGridView1.Rows[e.RowIndex].Cells["tarjaDataGridViewTextBoxColumn"].Value.ToString();
            s.CmbTurno.Items.Clear();
            s.CmbTurno.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["turnoDataGridViewTextBoxColumn"].Value.ToString());
            s.Cmb_Producto_User.DataSource = null;
            s.Cmb_Producto_User.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["productoAnalisisDataGridViewTextBoxColumn"].Value.ToString());
            s.Cmb_Producto_User.SelectedIndex = 0;
            s.Txt_Producto_user.Text = dataGridView1.Rows[e.RowIndex].Cells["codProductoUserDataGridViewTextBoxColumn"].Value.ToString();
            s.Lbl_Producto_Tarja.Text = dataGridView1.Rows[e.RowIndex].Cells["codProductoTarjaDataGridViewTextBoxColumn"].Value.ToString();
            s.Lbl_ProductoTarja_nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["productoTarjaDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Peso.Text = dataGridView1.Rows[e.RowIndex].Cells["pesoMuestraDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Cascara.Text = dataGridView1.Rows[e.RowIndex].Cells["cascaraDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_extraña.Text = dataGridView1.Rows[e.RowIndex].Cells["matExtrañaDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Halves.Text = dataGridView1.Rows[e.RowIndex].Cells["halvesDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Large_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["largePiecesDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Medium_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["mediumPiecesDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Small_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["smallPiecesDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Extra_Light.Text = dataGridView1.Rows[e.RowIndex].Cells["extraLightDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Light.Text = dataGridView1.Rows[e.RowIndex].Cells["lightDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Light_Ambar.Text = dataGridView1.Rows[e.RowIndex].Cells["lightAmbarDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Ambar.Text = dataGridView1.Rows[e.RowIndex].Cells["ambarDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Amarillo.Text = dataGridView1.Rows[e.RowIndex].Cells["amarilloDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Defectos.Text = dataGridView1.Rows[e.RowIndex].Cells["defectosDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Observaciones.Text = dataGridView1.Rows[e.RowIndex].Cells["observacionDataGridViewTextBoxColumn"].Value.ToString();
            s.Txt_Observacion_Mat_Extraña.Text = dataGridView1.Rows[e.RowIndex].Cells["observacionMatExtrañaDataGridViewTextBoxColumn"].Value.ToString();
           
            if(Btn_Agregar.Visible == true)
            {
                s.groupBox9.Visible = true;
                s.groupBox10.Visible = false;
            }
            else
            {
                s.groupBox9.Visible = false;
                s.groupBox10.Visible = true;
            }
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.spTraer_Analisis_Calidad_PPMTableAdapter.Fill(this.prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM);
        }
        public void CmbProducto()
        {         
                try
                {
                    this.cn.Abrir();
                    SqlCommand sqlCommand = new SqlCommand("spTraer_Control_pmm", this.cn.getConexion());
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet, "Producto");
                    Cmb_Filtro.Refresh();
                    Cmb_Filtro.DataSource = dataSet.Tables["Producto"].DefaultView;
                    Cmb_Filtro.DisplayMember = "Des_Producto";
                    Cmb_Filtro.ValueMember = "Cod_Producto";
                }
                catch
                {
                    MessageBox.Show("Ocurrio un problema al cargar variedades", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            
            finally
            {
                this.cn.Cerrar();
            }
        }

        private void Cmb_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Busqueda.Text == "Analisis")
            {
                txt_filtro.Text = "";
                txt_filtro.Visible = true;
                Cmb_Filtro.Visible = false;
                DT_Fecha.Visible = false;
            }
            else
           if (Cmb_Busqueda.Text == "Bins")
            {
                txt_filtro.Text = "";
                txt_filtro.Visible = true;
                Cmb_Filtro.Visible = false;
                DT_Fecha.Visible = false;
            }
            else
           if (Cmb_Busqueda.Text == "Proceso")
            {
                txt_filtro.Text = "";
                txt_filtro.Visible = true;
                Cmb_Filtro.Visible = false;
                DT_Fecha.Visible = false;
            }
            else
           if (Cmb_Busqueda.Text == "Estado")
            {
                try
                {
                    Cmb_Filtro.Items.Clear();
                    Cmb_Filtro.DataSource = null;
                    Cmb_Filtro.Items.Add("completa");
                    Cmb_Filtro.Items.Add("incompleta");
                    Cmb_Filtro.SelectedIndex = 0;
                    txt_filtro.Visible = false;
                    Cmb_Filtro.Visible = true;
                    DT_Fecha.Visible = false;
                }
                catch { }

            }
            else
           if (Cmb_Busqueda.Text == "Turno")
            {
                try
                {
                    Cmb_Filtro.Items.Clear();
                    Cmb_Filtro.DataSource = null;
                    Cmb_Filtro.Items.Add("Dia");
                    Cmb_Filtro.Items.Add("Noche");
                    Cmb_Filtro.SelectedIndex = 0;
                    txt_filtro.Visible = false;
                    Cmb_Filtro.Visible = true;
                    DT_Fecha.Visible = false;
                }
                catch { }

            }
            else
           if ((Cmb_Busqueda.Text == "Producto Analisis") || (Cmb_Busqueda.Text == "Producto Tarja"))
            {
                try
                {
                    Cmb_Filtro.Items.Clear();
                    Cmb_Filtro.DataSource = null;
                    CmbProducto();
                    Cmb_Filtro.SelectedIndex = 0;
                    txt_filtro.Visible = false;
                    Cmb_Filtro.Visible = true;
                    DT_Fecha.Visible = false;
                }
                catch { }

            }
            else
           if (Cmb_Busqueda.Text == "Fecha")
            {
                txt_filtro.Text = "";
                txt_filtro.Visible = false;
                Cmb_Filtro.Visible = false;
                DT_Fecha.Visible = true;
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FormPartidoMecanico s = new FormPartidoMecanico();
            s.ACCESSO = 1;
            s.groupBox9.Visible = true;
            s.groupBox10.Visible = false;
            s.Btn_Guardar.Enabled = true;
            s.Btn_Print.Enabled = false;
            s.ShowDialog();
            this.spTraer_Analisis_Calidad_PPMTableAdapter.Fill(this.prueba_2017Preseleccion.spTraer_Analisis_Calidad_PPM);
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
