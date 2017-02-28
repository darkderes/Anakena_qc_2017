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
    public partial class FormBuscarTarja : Form
    {
        conexion cn = new conexion();
        string proceso = "";
        public string tarja = "";
        public FormBuscarTarja(string x)
        {
            InitializeComponent();
            proceso = x;
        }

        private void FormBuscarTarja_Load(object sender, EventArgs e)
        {

        }
        public void Busqueda_Tarjas()
        {
            try
            {
                this.cn.Abrir();
                SqlCommand sqlCommand = new SqlCommand("spTraer_Busqueda_Tarja", this.cn.getConexion());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@proceso", proceso);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "tarja");
                data_tarjas.DataSource = dataSet.Tables[0];

            }
            catch
            {
                MessageBox.Show("Ocurrio un problema al cargar Tarjas", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            finally
            {
                this.cn.Cerrar();
            }
        }

        private void data_tarjas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tarja = data_tarjas.Rows[e.RowIndex].Cells["tarja"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
