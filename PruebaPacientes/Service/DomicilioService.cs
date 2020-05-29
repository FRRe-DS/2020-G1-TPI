using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class DomicilioService
    {
        DataContext dataContext;

        public DomicilioService(DataContext context)
        {
            dataContext = context;
        }

        public List<Domicilio> GetDomicilios()
        {
            List<Domicilio> ListaDomicilio = new List<Domicilio>();

            Domicilio domicilio = new Domicilio();
            domicilio.Calle = "French";
            domicilio.NroDeCalle = "414";
            domicilio.NroDeDpto = "";
            domicilio.Piso = "";
            domicilio.Dpto = "";
            domicilio.LocalidadId = 11;
            ListaDomicilio.Add(domicilio);

            Domicilio domicilio1 = new Domicilio();
            domicilio1.Calle = "Jose Hernandes";
            domicilio1.NroDeCalle = "465";
            domicilio1.NroDeDpto = "3";
            domicilio1.Piso = "2";
            domicilio1.Dpto = "";
            domicilio1.LocalidadId = 17;
            ListaDomicilio.Add(domicilio1);

            Domicilio domicilio2 = new Domicilio();
            domicilio2.Calle = "9 de Julio";
            domicilio2.NroDeCalle = "4141";
            domicilio2.NroDeDpto = "";
            domicilio2.Piso = "";
            domicilio2.Dpto = "";
            domicilio2.LocalidadId = 12;
            ListaDomicilio.Add(domicilio2);

            Domicilio domicilio3 = new Domicilio();
            domicilio3.Calle = "25 de Mayo";
            domicilio3.NroDeCalle = "1902";
            domicilio3.NroDeDpto = "";
            domicilio3.Piso = "";
            domicilio3.Dpto = "";
            domicilio3.LocalidadId = 18;
            ListaDomicilio.Add(domicilio3);

            Domicilio domicilio4 = new Domicilio();
            domicilio4.Calle = "Mitre";
            domicilio4.NroDeCalle = "14";
            domicilio4.NroDeDpto = "";
            domicilio4.Piso = "";
            domicilio4.Dpto = "";
            domicilio4.LocalidadId = 21;
            ListaDomicilio.Add(domicilio4);

            Domicilio domicilio5 = new Domicilio();
            domicilio5.Calle = "Corriente";
            domicilio5.NroDeCalle = "234";
            domicilio5.NroDeDpto = "";
            domicilio5.Piso = "";
            domicilio5.Dpto = "";
            domicilio5.LocalidadId = 21;
            ListaDomicilio.Add(domicilio5);

            Domicilio domicilio6 = new Domicilio();
            domicilio6.Calle = "Calle 5";
            domicilio6.NroDeCalle = "414";
            domicilio6.NroDeDpto = "";
            domicilio6.Piso = "";
            domicilio6.Dpto = "";
            domicilio6.LocalidadId = 31;
            ListaDomicilio.Add(domicilio6);

            Domicilio domicilio7 = new Domicilio();
            domicilio7.Calle = "Calle 11";
            domicilio7.NroDeCalle = "8493";
            domicilio7.NroDeDpto = "";
            domicilio7.Piso = "";
            domicilio7.Dpto = "";
            domicilio7.LocalidadId = 41;
            ListaDomicilio.Add(domicilio7);

            Domicilio domicilio8 = new Domicilio();
            domicilio8.Calle = "Sarmiento";
            domicilio8.NroDeCalle = "64";
            domicilio8.NroDeDpto = "";
            domicilio8.Piso = "";
            domicilio8.Dpto = "";
            domicilio8.LocalidadId = 5;
            ListaDomicilio.Add(domicilio8);

            Domicilio domicilio9 = new Domicilio();
            domicilio9.Calle = "Batman";
            domicilio9.NroDeCalle = "666";
            domicilio9.NroDeDpto = "";
            domicilio9.Piso = "";
            domicilio9.Dpto = "";
            domicilio9.LocalidadId = 32;
            ListaDomicilio.Add(domicilio9);

            return ListaDomicilio;
        }
    }
}
