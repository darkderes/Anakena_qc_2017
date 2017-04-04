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

namespace Anakena_2017
{
    public partial class FormAnalisisCalidadPreseleccion : Form
    {
        conexion cn = new conexion();
        private DataSet myds = new DataSet();
        public FormAnalisisCalidadPreseleccion()
        {
            InitializeComponent();
        }

        private void FormAnalisisCalidadPreseleccion_Load(object sender, EventArgs e)
        {
            Traer_Analisis_Calidad_Preseleccion();
            Cmb_Busqueda.SelectedIndex = 0;
            dataGridView1.Columns["Cod_Producto_User"].Visible = false;
            dataGridView1.Columns["Cod_Producto_Tarja"].Visible = false;
            dataGridView1.Columns["Peso_Muestra"].Visible = false;
            dataGridView1.Columns["Cascara"].Visible = false;
            dataGridView1.Columns["Mat_Extraña"].Visible = false;
            dataGridView1.Columns["Halves"].Visible = false;
            dataGridView1.Columns["Large_Pieces"].Visible = false;
            dataGridView1.Columns["Medium_Pieces"].Visible = false;
            dataGridView1.Columns["Small_Pieces"].Visible = false;
            dataGridView1.Columns["Extra_Light"].Visible = false;
            dataGridView1.Columns["Light"].Visible = false;
            dataGridView1.Columns["Light_Ambar"].Visible = false;
            dataGridView1.Columns["Ambar"].Visible = false;
            dataGridView1.Columns["Amarillo"].Visible = false;
            dataGridView1.Columns["Defectos"].Visible = false;
            dataGridView1.Columns["Observacion"].Visible = false;
            dataGridView1.Columns["Observacion_Mat_Extraña"].Visible = false;
            dataGridView1.Columns["Septum"].Visible = false;
            dataGridView1.Columns["Reseca_Leve"].Visible = false;
            dataGridView1.Columns["Reseca_Grave"].Visible = false;
            dataGridView1.Columns["Daño_Insecto"].Visible = false;
            dataGridView1.Columns["Mancha_Agua"].Visible = false;
            dataGridView1.Columns["Hongo_Inactivo"].Visible = false;
            dataGridView1.Columns["Hongo_Activo"].Visible = false;
            dataGridView1.Columns["Observacion_Cascara"].Visible = false;
            dataGridView1.Columns["Observacion_Septum"].Visible = false;
        }
        public void Traer_Analisis_Calidad_Preseleccion()
        {
            SqlCommand sqlCommand = new SqlCommand("spTraer_Analisis_Calidad_Preseleccion", this.cn.getConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            this.cn.Abrir();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            this.myds = new DataSet();
            sqlDataAdapter.Fill(this.myds);
            this.dataGridView1.DataSource = this.myds.Tables[0];
            this.cn.Cerrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPreseleccion s = new FormPreseleccion();
            s.timer1.Enabled = false;
            s.Lbl_Analisis.Text = dataGridView1.Rows[e.RowIndex].Cells["Analisis"].Value.ToString();
            s.Txt_proceso.Text = dataGridView1.Rows[e.RowIndex].Cells["Proceso"].Value.ToString();
            s.DT_Calidad.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            s.TxtBins.Text = dataGridView1.Rows[e.RowIndex].Cells["Bins"].Value.ToString();
            s.Txt_Tarja.Text = dataGridView1.Rows[e.RowIndex].Cells["Tarja"].Value.ToString();
            s.CmbTurno.Items.Clear();
            s.CmbTurno.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["Turno"].Value.ToString());
            s.Cmb_Producto_User.DataSource = null;
            s.Cmb_Producto_User.Items.Add(dataGridView1.Rows[e.RowIndex].Cells["Producto_Analisis"].Value.ToString());
            s.Cmb_Producto_User.SelectedIndex = 0;
            s.Txt_Producto_user.Text = dataGridView1.Rows[e.RowIndex].Cells["Cod_Producto_User"].Value.ToString();
            s.Lbl_Producto_Tarja.Text = dataGridView1.Rows[e.RowIndex].Cells["Cod_Producto_Tarja"].Value.ToString();
            s.Lbl_ProductoTarja_nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Producto_Tarja"].Value.ToString();
            s.Txt_Peso.Text = dataGridView1.Rows[e.RowIndex].Cells["Peso_Muestra"].Value.ToString();
            s.Txt_Cascara.Text = dataGridView1.Rows[e.RowIndex].Cells["Cascara"].Value.ToString();
            s.Txt_Septum.Text = dataGridView1.Rows[e.RowIndex].Cells["Septum"].Value.ToString();
            s.Txt_extraña.Text = dataGridView1.Rows[e.RowIndex].Cells["Mat_Extraña"].Value.ToString();
            s.Txt_Halves.Text = dataGridView1.Rows[e.RowIndex].Cells["Halves"].Value.ToString();
            s.Txt_Large_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["Large_Pieces"].Value.ToString();
            s.Txt_Medium_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["Medium_Pieces"].Value.ToString();
            s.Txt_Small_Pieces.Text = dataGridView1.Rows[e.RowIndex].Cells["Small_Pieces"].Value.ToString();
            s.Txt_Extra_Light.Text = dataGridView1.Rows[e.RowIndex].Cells["Extra_Light"].Value.ToString();
            s.Txt_Light.Text = dataGridView1.Rows[e.RowIndex].Cells["Light"].Value.ToString();
            s.Txt_Light_Ambar.Text = dataGridView1.Rows[e.RowIndex].Cells["Light_Ambar"].Value.ToString();
            s.Txt_Ambar.Text = dataGridView1.Rows[e.RowIndex].Cells["Ambar"].Value.ToString();
            s.Txt_Amarillo.Text = dataGridView1.Rows[e.RowIndex].Cells["Amarillo"].Value.ToString();
            s.Txt_Defectos.Text = dataGridView1.Rows[e.RowIndex].Cells["Defectos"].Value.ToString();
            s.TxtReseca_Leve.Text = dataGridView1.Rows[e.RowIndex].Cells["Reseca_Leve"].Value.ToString();
            s.TxtReseca_Grave.Text = dataGridView1.Rows[e.RowIndex].Cells["Reseca_Grave"].Value.ToString();
            s.TxtDaño_Insecto.Text = dataGridView1.Rows[e.RowIndex].Cells["Daño_Insecto"].Value.ToString();
            s.TxtMancha_Agua.Text = dataGridView1.Rows[e.RowIndex].Cells["Mancha_Agua"].Value.ToString();
            s.TxtHongo_Inactivo.Text = dataGridView1.Rows[e.RowIndex].Cells["Hongo_Inactivo"].Value.ToString();
            s.TxtHongo_Activo.Text = dataGridView1.Rows[e.RowIndex].Cells["Hongo_Activo"].Value.ToString();
            s.Txt_Observaciones.Text = dataGridView1.Rows[e.RowIndex].Cells["Observacion"].Value.ToString();
            s.Txt_Observacion_Mat_Extraña.Text = dataGridView1.Rows[e.RowIndex].Cells["Observacion_Mat_Extraña"].Value.ToString();
            s.Txt_Observacion_Cascara.Text = dataGridView1.Rows[e.RowIndex].Cells["Observacion_Cascara"].Value.ToString();
            s.Txt_Observacion_Septum.Text = dataGridView1.Rows[e.RowIndex].Cells["Observacion_Septum"].Value.ToString();

            if (Btn_Agregar.Visible == true)
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

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FormPreseleccion s = new FormPreseleccion();
            s.ACCESSO = 1;
            s.groupBox9.Visible = true;
            s.groupBox10.Visible = false;
            s.Btn_Guardar.Enabled = true;
            s.Btn_Print.Enabled = false;
            s.ShowDialog();
        }
    }
}
