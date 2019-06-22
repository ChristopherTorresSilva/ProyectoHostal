using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Negocio
    
{
    public class Perfiles
    {
        OracleConnection OracleCon = new OracleConnection();
        public Perfiles()
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

        public Perfiles(string sqlcon)
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



        public DataTable ListaPerfiles()
        {
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {
                 OracleCon.Open();
                OracleCommand _OracleCommand = new OracleCommand("SELECT * FROM PERFIL", OracleCon);
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);
                _OracleDataAdapter.Fill(dt);
                OracleCon.Close();
                return dt;
            }
            catch (Exception)
            {
                //System.Diagnostics.Debug.WriteLine(userN);
                return dt;
            }
        }
    }
}
