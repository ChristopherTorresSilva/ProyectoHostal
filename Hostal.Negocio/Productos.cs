using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Negocio

{
    public class Productos
    {
        OracleConnection OracleCon = new OracleConnection();
        public Productos()
        {
            try
            {
                Conexion con = new Conexion();

                OracleCon = con.Get_Connecion();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        public Productos(string sqlcon)
        {
            try
            {
                OracleCon = new OracleConnection(sqlcon);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }



        public DataTable ListaProductos()
        {
           
            DataTable dt = new DataTable();
            try
            { System.Diagnostics.Debug.WriteLine("yes");
                OracleCon.Open();
                OracleCommand _OracleCommand = new OracleCommand("SELECT * FROM PRODUCTO", OracleCon);
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                _OracleDataAdapter.Fill(dt);
                OracleCon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
