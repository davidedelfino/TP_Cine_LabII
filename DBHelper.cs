using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DBHelper
    {
        private SqlConnection conn;
        private string CadenaConexion = @"Data Source=HP;Initial Catalog=Cine;Integrated Security=True";
        private static DBHelper instancia;

        public DBHelper()
        {
            conn = new SqlConnection(CadenaConexion);
        }

        public static DBHelper ObtenerInstancia()
        {
            if(instancia==null)
                instancia = new DBHelper();
            return instancia;
        }
        public DataTable ConsultarDB(string NomProc)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = NomProc;
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            conn.Close();
            return tabla;
        }
        public DataTable ConsultarDB(string NomProc, DateTime parametro1, DateTime parametro2)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NomProc;
            SqlParameter param1= new SqlParameter();
            param1.ParameterName = "fecha1";
            param1.Value = parametro1;
            param1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param1);
            SqlParameter param2= new SqlParameter();
            param2.ParameterName = "fecha2";
            param2.Value = parametro2;
            param2.Direction= ParameterDirection.Input;
            cmd.Parameters.Add(param2);
            tabla.Load(cmd.ExecuteReader());
            conn.Close();
            return tabla;

        }
    }
}
