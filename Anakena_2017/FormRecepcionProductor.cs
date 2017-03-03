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
    public partial class FormRecepcionProductor : Form
    {
        string ultimo = "";
        conexion cn = new conexion();
        public FormRecepcionProductor()
        {
            InitializeComponent();
        }

        private void FormRecepcionProductor_Load(object sender, EventArgs e)
        {
            this.traerLote(Convert.ToInt32(this.Txt_Lote.Text));
        }
        public void traerLote(int lote)
        {
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraerEncabezado", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Lote", lote);
            sqlDataAdapter.Fill(new DataSet(), "Encabezado");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    cmbVariedad.Text = sqlDataReader[2].ToString();
                    ultimo = sqlDataReader[0].ToString();
                    this.CmbRecepcion.Text = sqlDataReader[1].ToString();
                    this.Txt_Productor.Text = sqlDataReader[3].ToString();
                    this.CmbPatio.Text = sqlDataReader[4].ToString();
                    this.DT_Recepcion.Text = sqlDataReader[5].ToString();
                    this.DT_Analisis.Text = sqlDataReader[6].ToString();
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            if (this.ultimo != "")
            {
                this.Lbl_Analisis.Text = this.ultimo;
            }
            this.cn.Cerrar();
            this.extraerProductores(this.Txt_Productor.Text);
        }
        public void extraerProductores(string productor)
        {
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spDistintosProductores_cod", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@productor", productor);
            sqlDataAdapter.Fill(new DataSet(), "producto");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    this.Txt_ProductorName.Text = sqlDataReader[1].ToString();
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            this.cn.Cerrar();
        }
        public void TraerImpurezas(int analisis)
        {
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraerImpurezas", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
            sqlDataAdapter.Fill(new DataSet(), "Impurezas");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    this.Txt_Piedras.Text = sqlDataReader[0].ToString();
                    this.Txt_Palos.Text = sqlDataReader[1].ToString();
                    this.Txt_Pelon.Text = sqlDataReader[2].ToString();
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            this.cn.Cerrar();
        }
        public void TraerAnalisisExterno(int analisis)
        {
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraerAnalisisExterno", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
            sqlDataAdapter.Fill(new DataSet(), "AnalisisExterno");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    
                    this.Txt_Nuez.Text = (Convert.ToInt32(sqlDataReader[0].ToString()) + Convert.ToInt32(sqlDataReader[1].ToString())).ToString() ;
                    this.Txt_Resquebrajado.Text = sqlDataReader[2].ToString();
                    this.Txt_Cerrado.Text = sqlDataReader[3].ToString();
                    this.Txt_Negras.Text = sqlDataReader[4].ToString();
                    this.Txt_Adherido.Text = sqlDataReader[5].ToString();
                    this.Lbl_Pelon.Text = string.Concat(sqlDataReader[5].ToString(), "%");
                    this.TxtTotalExterno.Text = "100";
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            this.cn.Cerrar();
        }
        public void TraerAnalisisInterno(int analisis)
		{
			this.cn.Abrir();
			SqlCommand sqlCommand = new SqlCommand("spTraerAnalisisInterno", this.cn.getConexion());
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
			sqlDataAdapter.Fill(new DataSet(), "AnalisisInterno");
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			try
			{
				while (sqlDataReader.Read())
				{
				
					this.Txt_Observaciones.Text = sqlDataReader[8].ToString();             
					this.Txt_Observaciones.ReadOnly = true;
				}
			}
			finally
			{
				if (sqlDataReader != null)
				{
					((IDisposable)sqlDataReader).Dispose();
				}
			}
			this.cn.Cerrar();
		}
        public void TraerEnvases(int analisis)
        {
        
        
            this.cn.Abrir();
            SqlCommand sqlCommand = new SqlCommand("spTraerEnvases", this.cn.getConexion());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Num_Analisis", analisis);
            sqlDataAdapter.Fill(new DataSet(), "Envases");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                 
                    this.lbl_condiciones.Text = sqlDataReader[5].ToString();
                    if (this.lbl_condiciones.Text == "ROJO")
                    {
                        this.lbl_condiciones.ForeColor = Color.Red;
                    }
                    else if (this.lbl_condiciones.Text == "AMARILLO")
                    {
                        this.lbl_condiciones.ForeColor = Color.Yellow;
                    }
                    else if (this.lbl_condiciones.Text == "VERDE")
                    {
                        this.lbl_condiciones.ForeColor = Color.Green;
                    }
                
                }
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            this.cn.Cerrar();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            FormReporte_Analisis_Productor s = new FormReporte_Analisis_Productor(Convert.ToInt32(Lbl_Analisis.Text), lbl_condiciones.Text);
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
