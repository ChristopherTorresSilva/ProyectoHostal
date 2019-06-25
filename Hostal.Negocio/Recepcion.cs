using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostal.Negocio
{
    public class Recepcion
    {
        OracleConnection OracleCon = new OracleConnection();
        public Recepcion()
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

        public Recepcion(string sqlcon)
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

        public bool CreateRecepcionProducto(long newCodigo, string newNombre, int newPrecio, int newTipoProductoId, int newFamilia, string newDescripcion, int newStock, int newStockCritico)
        {
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_PRODUCTO";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("newCodigo", OracleDbType.Long).Value = newCodigo;
                _OracleCommand.Parameters.Add("newNombre", OracleDbType.Varchar2).Value = newNombre;
                _OracleCommand.Parameters.Add("newPrecio", OracleDbType.Int32).Value = newPrecio;
                _OracleCommand.Parameters.Add("newTipoProductoId", OracleDbType.Int32).Value = newTipoProductoId;
                _OracleCommand.Parameters.Add("newFamilia", OracleDbType.Int32).Value = newFamilia;
                _OracleCommand.Parameters.Add("newDescripcion", OracleDbType.Varchar2).Value = newDescripcion;
                _OracleCommand.Parameters.Add("newStock", OracleDbType.Int32).Value = newStock;
                _OracleCommand.Parameters.Add("newStockCritico", OracleDbType.Int32).Value = newStockCritico;

                OracleCon.Open();
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                _OracleDataAdapter.Fill(dt);
                System.Diagnostics.Debug.WriteLine(dt.Rows.Count);
                OracleCon.Close();


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
