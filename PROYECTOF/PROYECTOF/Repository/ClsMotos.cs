using PROYECTOF.Models;
using PROYECTOF.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PROYECTOF.Repository
{
    public class ClsMotos : IMotos
    {
        public void Agregar(MOTOS moto)
        {
            using (MOTOSEntities motobd = new MOTOSEntities())
            {
                MOTOS mot = motobd.MOTOS.Find(moto.ID);
                mot.MARCA = moto.MARCA;
                mot.MOTOR = moto.MOTOR;
                mot.MODELO = moto.MODELO;
                mot.AÑO = moto.AÑO;
                mot.N_FABRICA = moto.N_FABRICA;
                motobd.SaveChanges();
            }
        }

        public void Compra(MOTOS moto)
        {
            using (MOTOSEntities motos = new MOTOSEntities())
            {

                moto = motos.MOTOS.Find(moto.ID);
                motos.MOTOS.Remove(moto);
                motos.SaveChanges();
            }
            
        }

        public List<MOTOS> ListOfDataOfTableMotos()
        {
            using(MOTOSEntities motosDatos = new MOTOSEntities())
            {
                List<MOTOS> listmotos = motosDatos.PROVEDOR.ToList()
                   return (listmotos);
            }
   
        }
    }
}

