using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Negocio
{
    public class USUARIO
    {
        OracleConnection OracleCon = new OracleConnection();
        public USUARIO()
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
        public USUARIO(string sqlcon)
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



        public DataTable ListaUsuarios()
        {
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {

                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter();
                OracleCommand _OracleCommand = new OracleCommand();

                _OracleCommand.CommandText = "seleccionaUsuarios";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;


                _OracleCommand.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                OracleCon.Open();
                _OracleDataAdapter.SelectCommand = _OracleCommand;
                _OracleDataAdapter.Fill(dt);
                OracleCon.Close();




                return dt;
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(userN);
                return dt;
            }
        }
    }
}
