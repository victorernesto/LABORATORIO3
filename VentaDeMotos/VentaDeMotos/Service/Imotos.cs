using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMotos.Models;

namespace VentaDeMotos.Service
{
    interface Imotos
    {
        List<DATOSMOTOS> Listdatos();

        void Datos(DATOS datos);

        void Clientes(CLIENTES clientes);

        void Empleados(EMPLEADO empleado);

        void Comprar(MOTO Moto);

        List<MOTO> Listamoto();
    }
}
