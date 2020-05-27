using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ProvinciaService
    {
        DataContext dataContext;

        public ProvinciaService(DataContext context)
        {
            dataContext = context;
        }

        public List<Provincia> GetAll()
        {
            return dataContext.ListaProvincias.ToList();
        }

        public void Update(Provincia provincia)
        {
            dataContext.ListaProvincias.Update(provincia);
            dataContext.SaveChanges();
        }

        public void Add(Provincia provincia)
        {
            dataContext.ListaProvincias.Add(provincia);
            dataContext.SaveChanges();
        }

        public void Delete(Provincia provincia)
        {
            dataContext.ListaProvincias.Remove(provincia);
            dataContext.SaveChanges();
        }

        public void CargarProvincia()
        {

            try
            {
                Provincia provincia1 = new Provincia();
                provincia1.Nombre = "Corrientes";
                Add(provincia1);

                Provincia provincia2 = new Provincia();
                provincia2.Nombre = "Chaco";
                Add(provincia2);

                Provincia provincia3 = new Provincia();
                provincia3.Nombre = "Cordoba";
                Add(provincia3);

                Provincia provincia4 = new Provincia();
                provincia4.Nombre = "Buenos Aires";
                Add(provincia4);

                Provincia provincia5 = new Provincia();
                provincia5.Nombre = "Catamarca";
                Add(provincia5);

                Provincia provincia6 = new Provincia();
                provincia6.Nombre = "Chubut";
                Add(provincia6);

                Provincia provincia7 = new Provincia();
                provincia7.Nombre = "Entre Rios";
                Add(provincia7);

                Provincia provincia8 = new Provincia();
                provincia8.Nombre = "Formosa";
                Add(provincia8);

                Provincia provincia9 = new Provincia();
                provincia9.Nombre = "Jujuy";
                Add(provincia9);

                Provincia provincia10 = new Provincia();
                provincia10.Nombre = "La Pampa";
                Add(provincia10);


                Provincia provincia11 = new Provincia();
                provincia11.Nombre = "La Rioja";
                Add(provincia11);

                Provincia provincia12 = new Provincia();
                provincia12.Nombre = "Mendoza";
                Add(provincia12);

                Provincia provincia13 = new Provincia();
                provincia13.Nombre = "Misiones";
                Add(provincia13);

                Provincia provincia14 = new Provincia();
                provincia14.Nombre = "Neuquen";
                Add(provincia14);

                Provincia provincia15 = new Provincia();
                provincia15.Nombre = "Rio Negro";
                Add(provincia15);

                Provincia provincia16 = new Provincia();
                provincia16.Nombre = "Salta";
                Add(provincia16);

                Provincia provincia17 = new Provincia();
                provincia17.Nombre = "San Juan";
                Add(provincia17);

                Provincia provincia18 = new Provincia();
                provincia18.Nombre = "San Luis";
                Add(provincia18);

                Provincia provincia19 = new Provincia();
                provincia19.Nombre = "Santa Cruz";
                Add(provincia19);

                Provincia provincia20 = new Provincia();
                provincia20.Nombre = "Santa Fe";
                Add(provincia20);

                Provincia provincia21 = new Provincia();
                provincia21.Nombre = "Santiago del Estero";
                Add(provincia21);

                Provincia provincia22 = new Provincia();
                provincia22.Nombre = "Tierra del Fuego";
                Add(provincia22);

                Provincia provincia23 = new Provincia();
                provincia23.Nombre = "Tucuman";
                Add(provincia23);
            }
            catch (Exception ex)
            {

                throw new Exception(Tools.Tools.ExceptionMessage(ex));
            }
        }

    }
}
