using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaDeMotos.Models;
using VentaDeMotos.Service;

namespace VentaDeMotos.Repository
{
    public class ClsMotos : Imotos
    {
        public void Clientes(CLIENTES clientes)
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                CLIENTES cliente = new CLIENTES();
                cliente.NOMBRE = clientes.NOMBRE;
                cliente.APELLIDO = clientes.APELLIDO;
                bdmotos.CLIENTES.Add(cliente);
                bdmotos.SaveChanges();
            }
        }

    

        public void Comprar(MOTO Moto)
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                Moto = bdmotos.MOTO.Find(Moto.ID_MOTO);
                bdmotos.MOTO.Remove(Moto);
                bdmotos.SaveChanges();

            }
        }

  

        public void Datos(DATOS datos)
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                DATOS dt = new DATOS();
                dt.TELEFONO = datos.TELEFONO;
                dt.DEPARTAMENTO = datos.DEPARTAMENTO;
                dt.MUNICIPIO = datos.MUNICIPIO;
                dt.EDAD = datos.EDAD;
                dt.AREA = datos.AREA;
                dt.DUI = datos.DUI;
                bdmotos.DATOS.Add(dt);
                bdmotos.SaveChanges();


            }
        }

        

        public void Empleados(EMPLEADO empleado)
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                EMPLEADO empleados = new EMPLEADO();
                empleados.NOMBRE = empleado.NOMBRE;
                empleados.APELLIDO = empleado.APELLIDO;
                bdmotos.EMPLEADO.Add(empleados);
                bdmotos.SaveChanges();
            }
        }

        public List<MOTO> Listamoto()
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                List<MOTO> listamoto = bdmotos.MOTO.ToList();

                return listamoto;


            }
        }

        public List<DATOSMOTOS> Listdatos()
        {
            using (VENTA_MOTOEntities bdmotos = new VENTA_MOTOEntities())
            {
                List < DATOSMOTOS > dlist = bdmotos.DATOSMOTOS.ToList();

                return dlist;

            }
                
        }
    }
}