using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace Hostal.Negocio
{
    public class OrdenPedido  
    {
        OracleConnection OracleCon = new OracleConnection();
        public OrdenPedido()
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

        public OrdenPedido(string sqlcon)
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

        public bool CreateOrdenPedido(int newCantidad, int newEmpleadoId, int newProveedorId, string newProducto)
        {
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {
                //PRUEBA PARA OBTENER PRECIO
                //OracleCon.Open();
                //OracleCommand prueba = new OracleCommand("SELECT PRECIO FROM PRODUCTO WHERE ID = :ID", OracleCon);

                //
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_ORDEN_PEDIDO";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;

                //OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_EMPLEADO", OracleCon);
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("newCantidad", OracleDbType.Int32).Value = newCantidad;
                _OracleCommand.Parameters.Add("newEmpleadoId", OracleDbType.Int32).Value = newEmpleadoId;
                _OracleCommand.Parameters.Add("newProveedorId", OracleDbType.Int32).Value = newProveedorId;
                _OracleCommand.Parameters.Add("newProducto", OracleDbType.Varchar2).Value = newProducto;



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

        public DataTable ListaOrdenPedido()
        {

            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {

                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter();
                OracleCommand _OracleCommand = new OracleCommand();

                _OracleCommand.CommandText = "seleccionaOrdenPedido";
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





    }
}
