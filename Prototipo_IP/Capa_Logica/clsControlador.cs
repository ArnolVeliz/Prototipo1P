using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;


namespace Capa_Logica
{
   public  class clsControlador
    {
        clsSentencias sn = new clsSentencias();
        public OdbcDataReader consultar(string tabla)
        {
            return sn.consulta(tabla);
        }

        public OdbcDataReader insertar_bodegas(string[] dato)
        {
            return sn.insertar_bodegas(dato);
        }
        public OdbcDataReader insertar_lineas(string[] dato)
        {
            return sn.insertar_lineas(dato);
        }
        public OdbcDataReader insertar_marcas(string[] dato)
        {
            return sn.insertar_marcas(dato);
        }
        public OdbcDataReader insertar_productos(string[] dato)
        {
            return sn.insertar_productos(dato);
        }
        public OdbcDataReader insertar_existencias(string[] dato)
        {
            return sn.insertar_existencias(dato);
        }
        public OdbcDataReader insertar_vendedores(string[] dato)
        {
            return sn.insertar_vendedores(dato);
        }
        public OdbcDataReader insertar_clientes(string[] dato)
        {
            return sn.insertar_clientes(dato);
        }
        public OdbcDataReader insertar_proveedores(string[] dato)
        {
            return sn.insertar_proveedores(dato);
        }
        public OdbcDataReader insertar_compras_encabezado(string[] dato)
        {
            return sn.insertar_compras_encabezado(dato);
        }
        public OdbcDataReader insertar_compras_detalle(string[] dato)
        {
            return sn.insertar_compras_detalle(dato);
        }
        public OdbcDataReader insertar_ventas_encabezado(string[] dato)
        {
            return sn.insertar_ventas_encabezado(dato);
        }
        public OdbcDataReader insertar_ventas_detalle(string[] dato)
        {
            return sn.insertar_ventas_detalle(dato);
        }

        public OdbcDataReader modificar_bodegas(string[] dato)
        {
            return sn.modificar_bodegas(dato);
        }
        public OdbcDataReader modificar_lineas(string[] dato)
        {
            return sn.modificar_lineas(dato);
        }
        public OdbcDataReader modificar_marcas(string[] dato)
        {
            return sn.modificar_marcas(dato);
        }
        public OdbcDataReader modificar_productos(string[] dato)
        {
            return sn.modificar_productos(dato);
        }
        public OdbcDataReader modificar_existencias(string[] dato)
        {
            return sn.modificar_existencias(dato);
        }
        public OdbcDataReader modificar_vendedores(string[] dato)
        {
            return sn.modificar_vendedores(dato);
        }
        public OdbcDataReader modificar_clientes(string[] dato)
        {
            return sn.modificar_clientes(dato);
        }
        public OdbcDataReader modificar_proveedores(string[] dato)
        {
            return sn.modificar_proveedores(dato);
        }
        public OdbcDataReader modificar_compras_encabezado(string[] dato)
        {
            return sn.modificar_compras_encabezado(dato);
        }
        public OdbcDataReader modificar_compras_detalle(string[] dato)
        {
            return sn.modificar_compras_detalle(dato);
        }
        public OdbcDataReader modificar_ventas_encabezado(string[] dato)
        {
            return sn.modificar_ventas_encabezado(dato);
        }
        public OdbcDataReader modificar_ventas_detalle(string[] dato)
        {
            return sn.modificar_ventas_detalle(dato);
        }
    }

}
