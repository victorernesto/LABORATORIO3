using PROYECTOF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOF.service
{
    interface IMotos
    {
        void Compra(MOTOS moto);

        void Agregar(MOTOS mot);

        List<MOTOS> ListOfDataOfTableMotos();
    }
}
