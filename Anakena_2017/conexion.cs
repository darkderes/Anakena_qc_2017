using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Anakena_2017
{
	internal class conexion
	{
		private SqlConnection Con = new SqlConnection("Data Source=SERVIDORERP;Initial Catalog=prueba_2018;User id=sa;Password=Pall2015;Integrated Security = False");

		public conexion()
		{
		}

		public void Abrir()
		{
			try
			{
				this.Con.Open();
			}
			catch
			{
				MessageBox.Show("No se pudo conectar al servidor aplicacion se cerrar", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public void Cerrar()
		{
			this.Con.Close();
		}

		public SqlConnection getConexion()
		{
			return this.Con;
		}
	}
}