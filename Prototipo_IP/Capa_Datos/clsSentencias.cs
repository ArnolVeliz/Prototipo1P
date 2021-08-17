using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class clsSentencias
    {
        clsConexion cn = new clsConexion(); //crear objeto
        OdbcCommand com; //variable para querys

        public OdbcDataReader consulta(string tabla)
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT * FROM " + tabla + ";";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_bodegas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO bodegas  Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_lineas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO lineas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_marcas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO marcas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] +  "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_productos(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO productos Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_existencias(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO existencias Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] +  "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_vendedores(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO vendedores Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_clientes(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO clientes Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_proveedores(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO proveedores Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_compras_encabezado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO compras_encabezado Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_compras_detalle(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO compras_detalle Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_ventas_encabezado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO ventas_encabezado Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_ventas_detalle(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO ventas_detalle Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //MODIFICACION
        public OdbcDataReader modificar_bodegas(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE bodegas SET nombre_bodega  = '" + datos[1] + "', estatus_bodega  = '" + datos[2] + "'  WHERE codigo_bodega ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_lineas(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE lineas SET nombre_linea  = '" + datos[1] + "', estatus_linea  = '" + datos[2] + "'  WHERE codigo_linea ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_marcas(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE marcas SET nombre_marca  = '" + datos[1] + "', estatus_marca  = '" + datos[2] + "'  WHERE codigo_marca ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_productos(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE productos SET nombre_producto  = '" + datos[1] + "', codigo_linea  = '" + datos[2] + "', codigo_marca  = '" + datos[3] + "', existencia_producto   = '" + datos[4] + "', estatus_producto   = '" + datos[5] + "'  WHERE codigo_producto ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        public OdbcDataReader modificar_existencias(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE existencias SET codigo_producto  = '" + datos[1] + "', saldo_existencia  = '" + datos[2] + "'  WHERE codigo_bodega ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificar_vendedores(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE vendedores SET nombre_vendedor   = '" + datos[1] + "', direccion_vendedor   = '" + datos[2] + "', telefono_vendedor   = '" + datos[3] + "', nit_vendedor    = '" + datos[4] + "', estatus_vendedor    = '" + datos[5] + "'  WHERE codigo_vendedor  ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_clientes(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE clientes SET nombre_cliente    = '" + datos[1] + "', direccion_cliente    = '" + datos[2] + "', nit_cliente    = '" + datos[3] + "', telefono_cliente     = '" + datos[4] + "', codigo_vendedor     = '" + datos[5] + "', estatus_cliente = '" + datos[6] + "'  WHERE codigo_cliente   ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_proveedores(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE proveedores SET nombre_proveedor    = '" + datos[1] + "', direccion_proveedor  = '" + datos[2] + "', telefono_proveedor   = '" + datos[3] + "', nit_proveedor  = '" + datos[4] + "', estatus_proveedor   = '" + datos[5] + "'  WHERE codigo_proveedor  ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_compras_encabezado(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE compras_encabezado SET codigo_proveedor     = '" + datos[1] + "', fecha_compraenca   = '" + datos[2] + "', total_compraenca    = '" + datos[3] + "', estatus_compraenca   = '" + datos[4] + "'  WHERE documento_compraenca   ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_compras_detalle(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE compras_detalle SET codigo_producto  = '" + datos[1] + "', cantidad_compradet    = '" + datos[2] + "', costo_compradet  = '" + datos[3] + "', codigo_bodega    = '" + datos[4] + "'  WHERE documento_compraenca    ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_ventas_encabezado(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE ventas_encabezado SET codigo_cliente   = '" + datos[1] + "', fecha_ventaenca     = '" + datos[2] + "', total_ventaenca   = '" + datos[3] + "', estatus_ventaenca     = '" + datos[4] + "'  WHERE documento_ventaenca     ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modificar_ventas_detalle(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE ventas_detalle SET codigo_producto    = '" + datos[1] + "', cantidad_ventadet    = '" + datos[2] + "', costo_ventadet    = '" + datos[3] + "', precio_ventadet     = '" + datos[4] + "', codigo_bodega     = '" + datos[5] + "'  WHERE documento_ventaenca   ='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

    }

}
