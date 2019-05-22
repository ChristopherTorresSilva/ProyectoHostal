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
            catch (Exception)
            {
                //System.Diagnostics.Debug.WriteLine(userN);
                return dt;
            }
        }

        public bool login(string user, string pass)
        {
            OracleCon.Open();
            OracleCommand _OracleCommand = new OracleCommand("SELECT * FROM USUARIO WHERE USERNAME = :usuario and PASSWORD = :password", OracleCon);
            
            _OracleCommand.Parameters.Add(":usuario", OracleDbType.Varchar2).Value = user;
            _OracleCommand.Parameters.Add(":password", OracleDbType.Varchar2).Value = pass;

            OracleDataReader lector = _OracleCommand.ExecuteReader();
            var login = lector.Read();
            
            OracleCon.Close();
            if (login)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
