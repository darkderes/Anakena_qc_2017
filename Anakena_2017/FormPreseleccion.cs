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
    public partial class FormPreseleccion : Form
    {
        conexion cn = new conexion();
        private string ultimo_Analisis = "";
        public int ACCESSO = 0;
        public FormPreseleccion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPreseleccion_Load(object sender, EventArgs e)
        {
            CmbTurno.SelectedIndex = 0;
            if (ACCESSO == 1)
            {
                timer1.Enabled = true;

            }
            //timer1.Enabled = true;


        }
        public void extraerNumANALISIS()
        {
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraer_NumAnalisis_Calidad_Preseleccion", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(new DataSet(), "Encabezado");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    ultimo_Analisis = sqlDataReader[0].ToString();
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            if (!(this.ultimo_Analisis == ""))
            {
                int num = Convert.ToInt32(ultimo_Analisis) + 1;
                this.Lbl_Analisis.Text = num.ToString();
            }
            else
            {
                ultimo_Analisis = "1";
                Lbl_Analisis.Text = ultimo_Analisis;
            }
            this.cn.Cerrar();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Txt_proceso.Text != "")
            {
                FormBuscarTarja s = new FormBuscarTarja(Txt_proceso.Text);
                s.Busqueda_Tarjas();
                if (s.data_tarjas.RowCount > 0)
                {
                    s.ShowDialog();
                }
                Txt_Tarja.Text = s.tarja;
                traer_tarja();
            }
            else
            {
                MessageBox.Show("Debe rellenar campo proceso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void traer_tarja()
        {
            string tarja = "0";
            string str = "";
            string str1 = "";
            string producto = "";
            Lbl_Producto_Tarja.Text = "";
            Txt_proceso.Text = "";
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraer_Tarja", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            Txt_Tarja.Text = Txt_Tarja.Text.PadLeft(10, '0');
            sqlCommand.Parameters.AddWithValue("@tarja", Txt_Tarja.Text);
            sqlDataAdapter.Fill(new DataSet(), "tarjas");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                if (!sqlDataReader.HasRows)
                {
                    cn.Cerrar();
                    MessageBox.Show("no se encontro tarja", "ANAKENA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Tarja.Text = "";
                    Txt_Tarja.Focus();

                }
                else
                {
                    while (sqlDataReader.Read())
                    {
                        tarja = sqlDataReader[0].ToString();
                        str = sqlDataReader[1].ToString();
                        str1 = sqlDataReader[2].ToString();
                        producto = sqlDataReader[3].ToString();
                    }
                    if (tarja == "1")
                    {
                        Lbl_Producto_Tarja.Text = str;
                        Txt_proceso.Text = str1;
                        Lbl_ProductoTarja_nombre.Text = producto;
                    }
                
                }
            }
            catch { }
            finally { cn.Cerrar(); }
        }
        public void CmbProducto()
        {
            try
            {
                this.cn.Abrir();
                SqlCommand sqlCommand = new SqlCommand("spTraer_Control_preseleccion", this.cn.getConexion());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Producto");
                this.Cmb_Producto_User.Refresh();
                this.Cmb_Producto_User.DataSource = dataSet.Tables["Producto"].DefaultView;
                this.Cmb_Producto_User.DisplayMember = "Des_Producto";
                this.Cmb_Producto_User.ValueMember = "Cod_Producto";
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

        private void Txt_Producto_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    Txt_Producto_user.Text = Txt_Producto_user.Text.PadLeft(4, '0');
                    CmbProducto_cod(Txt_Producto_user.Text);

                    if (Cmb_Producto_User.Items.Count < 1)
                    {
                        MessageBox.Show("No existen datos vinculados al codigo ingresado");
                        CmbProducto();
                        Txt_Producto_user.Text = "";
                    }
                }
            }
        }
        public void CmbProducto_cod(string cod)
        {
            try
            {
                try
                {
                    this.cn.Abrir();
                    SqlCommand sqlCommand = new SqlCommand("spTraer_Control_preseleccion_cod", this.cn.getConexion());
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@producto", cod);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet, "Producto");
                    this.Cmb_Producto_User.Refresh();
                    this.Cmb_Producto_User.DataSource = dataSet.Tables["Producto"].DefaultView;
                    this.Cmb_Producto_User.DisplayMember = "Des_Producto";
                    this.Cmb_Producto_User.ValueMember = "Cod_Producto";
                }
                catch
                {
                    MessageBox.Show("Ocurrio un problema al cargar variedades", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            finally
            {
                this.cn.Cerrar();
            }
        }

        private void Cmb_Producto_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Producto_User.SelectedIndex != 0)
                    Txt_Producto_user.Text = Cmb_Producto_User.SelectedValue.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            traer_tarja();
        }

        private void Txt_Peso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Peso.Text))
                {
                    Txt_Peso.Text = "0";
                }
                Txt_Pepa.Text = (Convert.ToDouble(Txt_Peso.Text) - Convert.ToDouble(Txt_Septum.Text) - Convert.ToDouble(Txt_Cascara.Text) - Convert.ToDouble(Txt_extraña.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Cascara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Cascara.Text))
                {
                    Txt_Cascara.Text = "0";
                }
                Txt_Pepa.Text = (Convert.ToDouble(Txt_Peso.Text) - Convert.ToDouble(Txt_Septum.Text) - Convert.ToDouble(Txt_Cascara.Text) - Convert.ToDouble(Txt_extraña.Text)).ToString();
            }
            catch { }
        }

        private void Txt_extraña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_extraña.Text))
                {
                    Txt_extraña.Text = "0";
                }
                Txt_Pepa.Text = (Convert.ToDouble(Txt_Peso.Text) - Convert.ToDouble(Txt_Septum.Text) - Convert.ToDouble(Txt_Cascara.Text) - Convert.ToDouble(Txt_extraña.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Cascara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Septum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_extraña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Septum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Septum.Text))
                {
                    Txt_extraña.Text = "0";
                }
                Txt_Pepa.Text = (Convert.ToDouble(Txt_Peso.Text) - Convert.ToDouble(Txt_Septum.Text) - Convert.ToDouble(Txt_Cascara.Text) - Convert.ToDouble(Txt_extraña.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Halves_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Halves.Text))
                {
                    Txt_Halves.Text = "0";
                }
                Txt_Total_Productos.Text = (Convert.ToDouble(Txt_Halves.Text) + Convert.ToDouble(Txt_Large_Pieces.Text) + Convert.ToDouble(Txt_Medium_Pieces.Text) + Convert.ToDouble(Txt_Small_Pieces.Text)).ToString();
                Txt_Halves_por.Text = ((Convert.ToDouble(Txt_Halves.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Large_Pieces_por.Text = ((Convert.ToDouble(Txt_Large_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Medium_Pieces_por.Text = ((Convert.ToDouble(Txt_Medium_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Small_Pieces_por.Text = ((Convert.ToDouble(Txt_Small_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Productos_Por.Text = (Convert.ToDouble(Txt_Halves_por.Text) + Convert.ToDouble(Txt_Large_Pieces_por.Text) + Convert.ToDouble(Txt_Medium_Pieces_por.Text) + Convert.ToDouble(Txt_Small_Pieces_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Large_Pieces_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Large_Pieces.Text))
                {
                    Txt_Large_Pieces.Text = "0";
                }
                Txt_Total_Productos.Text = (Convert.ToDouble(Txt_Halves.Text) + Convert.ToDouble(Txt_Large_Pieces.Text) + Convert.ToDouble(Txt_Medium_Pieces.Text) + Convert.ToDouble(Txt_Small_Pieces.Text)).ToString();
                Txt_Halves_por.Text = ((Convert.ToDouble(Txt_Halves.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Large_Pieces_por.Text = ((Convert.ToDouble(Txt_Large_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Medium_Pieces_por.Text = ((Convert.ToDouble(Txt_Medium_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Small_Pieces_por.Text = ((Convert.ToDouble(Txt_Small_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Productos_Por.Text = (Convert.ToDouble(Txt_Halves_por.Text) + Convert.ToDouble(Txt_Large_Pieces_por.Text) + Convert.ToDouble(Txt_Medium_Pieces_por.Text) + Convert.ToDouble(Txt_Small_Pieces_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Medium_Pieces_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Medium_Pieces.Text))
                {
                    Txt_Medium_Pieces.Text = "0";
                }
                Txt_Total_Productos.Text = (Convert.ToDouble(Txt_Halves.Text) + Convert.ToDouble(Txt_Large_Pieces.Text) + Convert.ToDouble(Txt_Medium_Pieces.Text) + Convert.ToDouble(Txt_Small_Pieces.Text)).ToString();
                Txt_Halves_por.Text = ((Convert.ToDouble(Txt_Halves.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Large_Pieces_por.Text = ((Convert.ToDouble(Txt_Large_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Medium_Pieces_por.Text = ((Convert.ToDouble(Txt_Medium_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Small_Pieces_por.Text = ((Convert.ToDouble(Txt_Small_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Productos_Por.Text = (Convert.ToDouble(Txt_Halves_por.Text) + Convert.ToDouble(Txt_Large_Pieces_por.Text) + Convert.ToDouble(Txt_Medium_Pieces_por.Text) + Convert.ToDouble(Txt_Small_Pieces_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Small_Pieces_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Small_Pieces.Text))
                {
                    Txt_Small_Pieces.Text = "0";
                }
                Txt_Total_Productos.Text = (Convert.ToDouble(Txt_Halves.Text) + Convert.ToDouble(Txt_Large_Pieces.Text) + Convert.ToDouble(Txt_Medium_Pieces.Text) + Convert.ToDouble(Txt_Small_Pieces.Text)).ToString();
                Txt_Halves_por.Text = ((Convert.ToDouble(Txt_Halves.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Large_Pieces_por.Text = ((Convert.ToDouble(Txt_Large_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Medium_Pieces_por.Text = ((Convert.ToDouble(Txt_Medium_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Small_Pieces_por.Text = ((Convert.ToDouble(Txt_Small_Pieces.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Productos_Por.Text = (Convert.ToDouble(Txt_Halves_por.Text) + Convert.ToDouble(Txt_Large_Pieces_por.Text) + Convert.ToDouble(Txt_Medium_Pieces_por.Text) + Convert.ToDouble(Txt_Small_Pieces_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Halves_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Large_Pieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Medium_Pieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Small_Pieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Extra_Light_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Light_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Light_Ambar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void Txt_Ambar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Amarillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Defectos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtReseca_Leve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtReseca_Grave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtDaño_Insecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtMancha_Agua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtHongo_Inactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TxtHongo_Activo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == 46 ? true : e.KeyChar == '\r'))
            {
                MessageBox.Show("Solo se permiten numeros decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void Txt_Extra_Light_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Extra_Light.Text))
                {
                    Txt_Extra_Light.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Light_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Light.Text))
                {
                    Txt_Light.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Light_Ambar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Light_Ambar.Text))
                {
                    Txt_Light_Ambar.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Ambar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Ambar.Text))
                {
                    Txt_Ambar.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Amarillo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Amarillo.Text))
                {
                    Txt_Amarillo.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void Txt_Defectos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Defectos.Text))
                {
                    Txt_Defectos.Text = "0";
                }
                Txt_Total_Color.Text = (Convert.ToDouble(Txt_Extra_Light.Text) + Convert.ToDouble(Txt_Light.Text) + Convert.ToDouble(Txt_Light_Ambar.Text) + Convert.ToDouble(Txt_Ambar.Text) + Convert.ToDouble(Txt_Amarillo.Text) + Convert.ToDouble(Txt_Defectos.Text)).ToString();
                Txt_Extra_Light_por.Text = ((Convert.ToDouble(Txt_Extra_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_por.Text = ((Convert.ToDouble(Txt_Light.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Light_Ambar_por.Text = ((Convert.ToDouble(Txt_Light_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Ambar_por.Text = ((Convert.ToDouble(Txt_Ambar.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Amarillo_por.Text = ((Convert.ToDouble(Txt_Amarillo.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Defectos_por.Text = ((Convert.ToDouble(Txt_Defectos.Text) / Convert.ToDouble(Txt_Pepa.Text)) * 100).ToString();
                Txt_Total_Color_por.Text = (Convert.ToDouble(Txt_Extra_Light_por.Text) + Convert.ToDouble(Txt_Light_por.Text) + Convert.ToDouble(Txt_Light_Ambar_por.Text) + Convert.ToDouble(Txt_Ambar_por.Text) + Convert.ToDouble(Txt_Amarillo_por.Text) + Convert.ToDouble(Txt_Defectos_por.Text)).ToString();
            }
            catch { }
        }

        private void TxtReseca_Leve_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtReseca_Leve.Text))
                {
                    TxtReseca_Leve.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text))+(Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text))*100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text =((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void TxtReseca_Grave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtReseca_Grave.Text))
                {
                    TxtReseca_Grave.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text)) + (Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text = ((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void TxtDaño_Insecto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtDaño_Insecto.Text))
                {
                    TxtDaño_Insecto.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text)) + (Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text = ((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void TxtMancha_Agua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtMancha_Agua.Text))
                {
                    TxtMancha_Agua.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text)) + (Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text = ((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void TxtHongo_Inactivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtHongo_Inactivo.Text))
                {
                    TxtHongo_Inactivo.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text)) + (Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text = ((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void TxtHongo_Activo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtHongo_Activo.Text))
                {
                    TxtHongo_Activo.Text = "0";
                }
                Txt_Total_Defectos.Text = (Convert.ToDouble(TxtReseca_Leve.Text) + (Convert.ToDouble(TxtReseca_Grave.Text)) + (Convert.ToDouble(TxtDaño_Insecto.Text)) + (Convert.ToDouble(TxtMancha_Agua.Text)) + (Convert.ToDouble(TxtHongo_Inactivo.Text)) + (Convert.ToDouble(TxtHongo_Activo.Text))).ToString();
                TxtReseca_Leve_por.Text = ((Convert.ToDouble(TxtReseca_Leve.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtReseca_Grave_por.Text = ((Convert.ToDouble(TxtReseca_Grave.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtDaño_Insecto_por.Text = ((Convert.ToDouble(TxtDaño_Insecto.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtMancha_Agua_por.Text = ((Convert.ToDouble(TxtMancha_Agua.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Inactivo_por.Text = ((Convert.ToDouble(TxtHongo_Inactivo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                TxtHongo_Activo_por.Text = ((Convert.ToDouble(TxtHongo_Activo.Text) / Convert.ToDouble(Txt_Defectos.Text)) * 100).ToString();
                Txt_Total_Defectos_por.Text = (Convert.ToDouble(TxtReseca_Leve_por.Text) + (Convert.ToDouble(TxtReseca_Grave_por.Text)) + (Convert.ToDouble(TxtDaño_Insecto_por.Text)) + (Convert.ToDouble(TxtMancha_Agua_por.Text)) + (Convert.ToDouble(TxtHongo_Inactivo_por.Text)) + (Convert.ToDouble(TxtHongo_Activo_por.Text))).ToString();
            }
            catch { }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar_datos() == true)
                {
                    timer1.Enabled = false;
                    agregar_calidad_preseleccion();
                    MessageBox.Show("Control de calidad guardada correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
            }
            catch { }
            finally
            {
            }
        }
        public void agregar_calidad_preseleccion()
        {

          
                SqlCommand sqlCommand = new SqlCommand("spAgregarCalidad_Preseleccion", this.cn.getConexion())
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@fecha", SqlDbType.Date);
                sqlCommand.Parameters.Add("@tarja", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@bins", SqlDbType.Int);
                sqlCommand.Parameters.Add("@turno", SqlDbType.Char);
                sqlCommand.Parameters.Add("@proceso", SqlDbType.Int);
                sqlCommand.Parameters.Add("@producto_user", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@producto_tarja", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@peso_muestra", SqlDbType.Float);
                sqlCommand.Parameters.Add("@cascara", SqlDbType.Float);
                sqlCommand.Parameters.Add("@septum", SqlDbType.Float);
                sqlCommand.Parameters.Add("@mat_extraña", SqlDbType.Float);
                sqlCommand.Parameters.Add("@halves", SqlDbType.Float);
                sqlCommand.Parameters.Add("@large_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@medium_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@small_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@extra_light", SqlDbType.Float);
                sqlCommand.Parameters.Add("@light", SqlDbType.Float);
                sqlCommand.Parameters.Add("@light_ambar", SqlDbType.Float);
                sqlCommand.Parameters.Add("@ambar", SqlDbType.Float);
                sqlCommand.Parameters.Add("@amarillo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@defectos", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Reseca_Leve", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Reseca_Grave", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Daño_Insecto", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Mancha_Agua", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Hongo_Inactivo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Hongo_Activo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@observacion", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_mat_extraña", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_Cascara", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_Septum", SqlDbType.Text);
                sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);

                char turno = '0';

                if (CmbTurno.Text == "NOCHE")
                {
                    turno = '1';
                }

                sqlCommand.Parameters["@id"].Value = Lbl_Analisis.Text;
                sqlCommand.Parameters["@fecha"].Value = DT_Calidad.Value;
                sqlCommand.Parameters["@tarja"].Value = Txt_Tarja.Text;
                sqlCommand.Parameters["@bins"].Value = Convert.ToInt32(TxtBins.Text);
                sqlCommand.Parameters["@turno"].Value = turno;
                sqlCommand.Parameters["@proceso"].Value = Txt_proceso.Text;
                sqlCommand.Parameters["@producto_user"].Value = Txt_Producto_user.Text;
                sqlCommand.Parameters["@producto_tarja"].Value = Lbl_Producto_Tarja.Text;
                sqlCommand.Parameters["@peso_muestra"].Value = Txt_Peso.Text;
                sqlCommand.Parameters["@cascara"].Value = Txt_Cascara.Text;
                sqlCommand.Parameters["@septum"].Value = Txt_Septum.Text;
                sqlCommand.Parameters["@mat_extraña"].Value = Txt_extraña.Text;
                sqlCommand.Parameters["@halves"].Value = Txt_Halves.Text;
                sqlCommand.Parameters["@large_pieces"].Value = Txt_Large_Pieces.Text;
                sqlCommand.Parameters["@medium_pieces"].Value = Txt_Medium_Pieces.Text;
                sqlCommand.Parameters["@small_pieces"].Value = Txt_Small_Pieces.Text;
                sqlCommand.Parameters["@extra_light"].Value = Txt_Extra_Light.Text;
                sqlCommand.Parameters["@light"].Value = Txt_Light.Text;
                sqlCommand.Parameters["@light_ambar"].Value = Txt_Light_Ambar.Text;
                sqlCommand.Parameters["@ambar"].Value = Txt_Ambar.Text;
                sqlCommand.Parameters["@amarillo"].Value = Txt_Amarillo.Text;
                sqlCommand.Parameters["@defectos"].Value = Txt_Defectos.Text;
                sqlCommand.Parameters["@Reseca_Leve"].Value = TxtReseca_Leve.Text;
                sqlCommand.Parameters["@Reseca_Grave"].Value = TxtReseca_Grave.Text;
                sqlCommand.Parameters["@Daño_Insecto"].Value = TxtDaño_Insecto.Text;
                sqlCommand.Parameters["@Mancha_Agua"].Value = TxtMancha_Agua.Text;
                sqlCommand.Parameters["@Hongo_Inactivo"].Value = TxtHongo_Inactivo.Text;
                sqlCommand.Parameters["@Hongo_Activo"].Value = TxtHongo_Activo.Text;
            string observaciones;
            if (Txt_Observaciones.Text == "Observaciones")
            {
                observaciones = "";
            }
            else
            {
                observaciones = Txt_Observaciones.Text;
            }
            sqlCommand.Parameters["@observacion"].Value = observaciones;
            string observaciones_mat_extraña;
            if (Txt_Observacion_Mat_Extraña.Text == "Observaciones")
            {
                observaciones_mat_extraña = "";
            }
            else
            {
                observaciones_mat_extraña = Txt_Observacion_Mat_Extraña.Text;
            }
            sqlCommand.Parameters["@observacion_mat_extraña"].Value = observaciones_mat_extraña;
            string observaciones_cascara;
            if (Txt_Observacion_Cascara.Text == "Observaciones")
            {
                observaciones_cascara = "";
            }
            else
            {
                observaciones_cascara = Txt_Observacion_Cascara.Text;
            }
            sqlCommand.Parameters["@observacion_Cascara"].Value = observaciones_cascara;
            string observaciones_Septum;
            if (Txt_Observacion_Septum.Text == "Observaciones")
            {
                observaciones_Septum = "";
            }
            else
            {
                observaciones_Septum = Txt_Observacion_Cascara.Text;
            }
            sqlCommand.Parameters["@observacion_Septum"].Value = observaciones_Septum;
            sqlCommand.Parameters["@msg"].Value = 1;
                this.cn.Abrir();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters["@msg"].Value.ToString();
            //}
            //catch (Exception exception1)
            //{
            //    Exception exception = exception1;
            //    MessageBox.Show(string.Concat("Error SQL ", exception), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}

            //finally
            //{
              this.cn.Cerrar();
            //}
}
        public bool validar_datos()
        {
            bool validar = true;
            if (String.IsNullOrEmpty(TxtBins.Text))
            {
                MessageBox.Show("Dato Nº de Bins no puede ser vacio ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }
            else
            if (String.IsNullOrEmpty(Txt_Producto_user.Text))
            {
                MessageBox.Show("Dato Codigo de producto no puede ser vacio ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }
            else
            if (CmbTurno.Text == "--Seleccione Turno--")
            {
                MessageBox.Show("Debe seleccionar dato del turno correspondiente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }
            else
            if ((Txt_Pepa.Text != Txt_Total_Color.Text) || (Txt_Pepa.Text != Txt_Total_Productos.Text)||(Txt_Defectos.Text != Txt_Total_Defectos.Text) || (Txt_Total_Color_por.Text != "100") || (Txt_Total_Productos_Por.Text != "100") || (Txt_Total_Defectos_por.Text != "100"))
            {
                MessageBox.Show("Peso o Porcentaje de muestras deben ser iguales", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }
            else
            if (string.IsNullOrEmpty(Txt_proceso.Text))
            {
                MessageBox.Show("Dato Proceso no puede ser vacio", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
            }


            return validar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            extraerNumANALISIS();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            FormReport_Preseleccion s = new FormReport_Preseleccion(Convert.ToInt32(Lbl_Analisis.Text));
            s.ShowDialog();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar analisis de PMM?", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != System.Windows.Forms.DialogResult.Cancel)
            {
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    this.eliminar_recepcion();
                    base.Close();
                }
            }
        }
        public void eliminar_recepcion()
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("spDeleteCalidad_Preseleccion", this.cn.getConexion())
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add("@Analisis", SqlDbType.Int);
                sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar);
                sqlCommand.Parameters["@Analisis"].Value = Convert.ToInt32(this.Lbl_Analisis.Text);
                sqlCommand.Parameters["@msg"].Value = 1;
                this.cn.Abrir();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters["@msg"].Value.ToString();
                MessageBox.Show("Nº Analisis eliminado correctamente ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                MessageBox.Show(string.Concat("Error SQL ", exception), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            finally
            {
                this.cn.Cerrar();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar_datos() == true)
                {
                    update_calidad_Preseleccion();
                    // timer1.Enabled = false;
                    MessageBox.Show("Control de calidad modificado correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
            finally
            {

            }
        }
        public void update_calidad_Preseleccion()
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("spUpdateCalidad_Preseleccion", this.cn.getConexion())
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@fecha", SqlDbType.Date);
                sqlCommand.Parameters.Add("@tarja", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@bins", SqlDbType.Int);
                sqlCommand.Parameters.Add("@turno", SqlDbType.Char);
                sqlCommand.Parameters.Add("@proceso", SqlDbType.Int);
                sqlCommand.Parameters.Add("@producto_user", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@producto_tarja", SqlDbType.Char, 10);
                sqlCommand.Parameters.Add("@peso_muestra", SqlDbType.Float);
                sqlCommand.Parameters.Add("@cascara", SqlDbType.Float);
                sqlCommand.Parameters.Add("@septum", SqlDbType.Float);
                sqlCommand.Parameters.Add("@mat_extraña", SqlDbType.Float);
                sqlCommand.Parameters.Add("@halves", SqlDbType.Float);
                sqlCommand.Parameters.Add("@large_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@medium_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@small_pieces", SqlDbType.Float);
                sqlCommand.Parameters.Add("@extra_light", SqlDbType.Float);
                sqlCommand.Parameters.Add("@light", SqlDbType.Float);
                sqlCommand.Parameters.Add("@light_ambar", SqlDbType.Float);
                sqlCommand.Parameters.Add("@ambar", SqlDbType.Float);
                sqlCommand.Parameters.Add("@amarillo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@defectos", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Reseca_Leve", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Reseca_Grave", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Daño_Insecto", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Mancha_Agua", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Hongo_Inactivo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@Hongo_Activo", SqlDbType.Float);
                sqlCommand.Parameters.Add("@observacion", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_mat_extraña", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_Cascara", SqlDbType.Text);
                sqlCommand.Parameters.Add("@observacion_Septum", SqlDbType.Text);
                sqlCommand.Parameters.Add("@msg", SqlDbType.VarChar, 100);

                char turno = '0';

                if (CmbTurno.Text == "NOCHE")
                {
                    turno = '1';
                }

                sqlCommand.Parameters["@id"].Value = Lbl_Analisis.Text;
                sqlCommand.Parameters["@fecha"].Value = DT_Calidad.Value;
                sqlCommand.Parameters["@tarja"].Value = Txt_Tarja.Text;
                sqlCommand.Parameters["@bins"].Value = Convert.ToInt32(TxtBins.Text);
                sqlCommand.Parameters["@turno"].Value = turno;
                sqlCommand.Parameters["@proceso"].Value = Txt_proceso.Text;
                sqlCommand.Parameters["@producto_user"].Value = Txt_Producto_user.Text;
                sqlCommand.Parameters["@producto_tarja"].Value = Lbl_Producto_Tarja.Text;
                sqlCommand.Parameters["@peso_muestra"].Value = Txt_Peso.Text;
                sqlCommand.Parameters["@cascara"].Value = Txt_Cascara.Text;
                sqlCommand.Parameters["@septum"].Value = Txt_Septum.Text;
                sqlCommand.Parameters["@mat_extraña"].Value = Txt_extraña.Text;
                sqlCommand.Parameters["@halves"].Value = Txt_Halves.Text;
                sqlCommand.Parameters["@large_pieces"].Value = Txt_Large_Pieces.Text;
                sqlCommand.Parameters["@medium_pieces"].Value = Txt_Medium_Pieces.Text;
                sqlCommand.Parameters["@small_pieces"].Value = Txt_Small_Pieces.Text;
                sqlCommand.Parameters["@extra_light"].Value = Txt_Extra_Light.Text;
                sqlCommand.Parameters["@light"].Value = Txt_Light.Text;
                sqlCommand.Parameters["@light_ambar"].Value = Txt_Light_Ambar.Text;
                sqlCommand.Parameters["@ambar"].Value = Txt_Ambar.Text;
                sqlCommand.Parameters["@amarillo"].Value = Txt_Amarillo.Text;
                sqlCommand.Parameters["@defectos"].Value = Txt_Defectos.Text;
                sqlCommand.Parameters["@Reseca_Leve"].Value = TxtReseca_Leve.Text;
                sqlCommand.Parameters["@Reseca_Grave"].Value = TxtReseca_Grave.Text;
                sqlCommand.Parameters["@Daño_Insecto"].Value = TxtDaño_Insecto.Text;
                sqlCommand.Parameters["@Mancha_Agua"].Value = TxtMancha_Agua.Text;
                sqlCommand.Parameters["@Hongo_Inactivo"].Value = TxtHongo_Inactivo.Text;
                sqlCommand.Parameters["@Hongo_Activo"].Value = TxtHongo_Activo.Text;
                string observaciones;
                if (Txt_Observaciones.Text == "Observaciones")
                {
                    observaciones = "";
                }
                else
                {
                    observaciones = Txt_Observaciones.Text;
                }
                sqlCommand.Parameters["@observacion"].Value = observaciones;
                string observaciones_mat_extraña;
                if (Txt_Observacion_Mat_Extraña.Text == "Observaciones")
                {
                    observaciones_mat_extraña = "";
                }
                else
                {
                    observaciones_mat_extraña = Txt_Observacion_Mat_Extraña.Text;
                }
                sqlCommand.Parameters["@observacion_mat_extraña"].Value = observaciones_mat_extraña;
                string observaciones_cascara;
                if (Txt_Observacion_Cascara.Text == "Observaciones")
                {
                    observaciones_cascara = "";
                }
                else
                {
                    observaciones_cascara = Txt_Observacion_Cascara.Text;
                }
                sqlCommand.Parameters["@observacion_Cascara"].Value = observaciones_cascara;
                string observaciones_Septum;
                if (Txt_Observacion_Septum.Text == "Observaciones")
                {
                    observaciones_Septum = "";
                }
                else
                {
                    observaciones_Septum = Txt_Observacion_Cascara.Text;
                }
                sqlCommand.Parameters["@observacion_Septum"].Value = observaciones_Septum;
                sqlCommand.Parameters["@msg"].Value = 1;
                this.cn.Abrir();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters["@msg"].Value.ToString();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                MessageBox.Show(string.Concat("Error SQL ", exception), "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            finally
            {
                this.cn.Cerrar();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_proceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtBins.Focus();
            }
        }

        private void TxtBins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Txt_Tarja.Focus();
            }
        }

        private void Txt_Tarja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
              traer_tarja();            
            }
           
        }
    }
}
