using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Negocio
{
    public class EMPRESA
    {
        OracleConnection OracleCon = new OracleConnection();
        public EMPRESA()
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
        public EMPRESA(string sqlcon)
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



        public bool CreateEmpresa(string userN,
            int perfil,
            string rut,
            string nombre,
            string correo)
        {
            
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {

                //
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_USUARIO_EMPRESA";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;

                //OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_EMPLEADO", OracleCon);
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("userN", OracleDbType.Varchar2).Value = userN;
                _OracleCommand.Parameters.Add("perfil", OracleDbType.Int32).Value = perfil;
                _OracleCommand.Parameters.Add("rut", OracleDbType.Varchar2).Value = rut;
                _OracleCommand.Parameters.Add("nom", OracleDbType.Varchar2).Value = nombre;
                _OracleCommand.Parameters.Add("correo", OracleDbType.Varchar2).Value = correo;



                //_OracleCommand.ExecuteNonQuery();
                OracleCon.Open();
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                //_OracleDataAdapter.SelectCommand = _OracleCommand;
                _OracleDataAdapter.Fill(dt);
                System.Diagnostics.Debug.WriteLine(dt.Rows.Count);
                OracleCon.Close();


                
               
               


                return true;
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(userN);
                return false;
            }
        }
    }
}
