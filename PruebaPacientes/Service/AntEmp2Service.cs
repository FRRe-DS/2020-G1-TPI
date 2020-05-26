using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AntEmp2Service
    {

        DataContext dataContext;

        public AntEmp2Service(DataContext context)
        {
            dataContext = context;
        }

        public List<AntecedenteEpidemiologicos2> GetAntEmp2()
        {
            List<AntecedenteEpidemiologicos2> ListaAntecedente = new List<AntecedenteEpidemiologicos2>();

            AntecedenteEpidemiologicos2 AntEmp1 = new AntecedenteEpidemiologicos2();
            AntEmp1.ApellidoDelCaso = "Medina";
            AntEmp1.NombreDelCaso = "Roberto";
            AntEmp1.AreaDelCaso = "Centro";
            AntEmp1.CiudadDelCentroVisitado = "Resistencia";
            AntEmp1.ContactoConAnimalesPrevioASintomas = true;
            AntEmp1.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp1.ContactoConPersonasConIRPrevioASintomas = false;
            AntEmp1.DNIDelCaso = "31321634";
            AntEmp1.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp1.NombreDelCentroVisitado = "Santa Rita";
            AntEmp1.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.AVES;
            AntEmp1.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.OTROS;
            AntEmp1.OtroTipoDeContactoConAnimales = "";
            AntEmp1.OtroTipoDeEntornoDeContacto = "";
            AntEmp1.VisitoCentroConCasosPositivosPrevioASintomas = false;
            AntEmp1.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp1);

            AntecedenteEpidemiologicos2 AntEmp2 = new AntecedenteEpidemiologicos2();
            AntEmp2.ApellidoDelCaso = "Jhonson";
            AntEmp2.NombreDelCaso = "Maria";
            AntEmp2.AreaDelCaso = "Sur";
            AntEmp2.CiudadDelCentroVisitado = "Puerto Madryn";
            AntEmp2.ContactoConAnimalesPrevioASintomas = true;
            AntEmp2.ContactoConCasosProbablesOConfirmadosPrevioASintomas = false;
            AntEmp2.ContactoConPersonasConIRPrevioASintomas = false;
            AntEmp2.DNIDelCaso = "29132632";
            AntEmp2.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp2.NombreDelCentroVisitado = "12 de octubre";
            AntEmp2.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CAMELIDOS;
            AntEmp2.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_ASISTENCIAL;
            AntEmp2.OtroTipoDeContactoConAnimales = "";
            AntEmp2.OtroTipoDeEntornoDeContacto = "";
            AntEmp2.VisitoCentroConCasosPositivosPrevioASintomas = false;
            AntEmp2.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp2);

            AntecedenteEpidemiologicos2 AntEmp3 = new AntecedenteEpidemiologicos2();
            AntEmp3.ApellidoDelCaso = "Rodriguez";
            AntEmp3.NombreDelCaso = "Maximiliano";
            AntEmp3.AreaDelCaso = "Norte";
            AntEmp3.CiudadDelCentroVisitado = "Puerto Vilelas";
            AntEmp3.ContactoConAnimalesPrevioASintomas = true;
            AntEmp3.ContactoConCasosProbablesOConfirmadosPrevioASintomas = false;
            AntEmp3.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp3.DNIDelCaso = "21724622";
            AntEmp3.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp3.NombreDelCentroVisitado = "Santa Teresita";
            AntEmp3.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.OTROS;
            AntEmp3.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_FAMILIAR;
            AntEmp3.OtroTipoDeContactoConAnimales = "";
            AntEmp3.OtroTipoDeEntornoDeContacto = "";
            AntEmp3.VisitoCentroConCasosPositivosPrevioASintomas = true;
            AntEmp3.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp3);

            AntecedenteEpidemiologicos2 AntEmp4 = new AntecedenteEpidemiologicos2();
            AntEmp4.ApellidoDelCaso = "Encinas";
            AntEmp4.NombreDelCaso = "Katherine";
            AntEmp4.AreaDelCaso = "Norte";
            AntEmp4.CiudadDelCentroVisitado = "Fontana";
            AntEmp4.ContactoConAnimalesPrevioASintomas = true;
            AntEmp4.ContactoConCasosProbablesOConfirmadosPrevioASintomas = false;
            AntEmp4.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp4.DNIDelCaso = "31322696";
            AntEmp4.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp4.NombreDelCentroVisitado = "Villa libertad";
            AntEmp4.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CAMELIDOS;
            AntEmp4.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_ASISTENCIAL;
            AntEmp4.OtroTipoDeContactoConAnimales = "";
            AntEmp4.OtroTipoDeEntornoDeContacto = "";
            AntEmp4.VisitoCentroConCasosPositivosPrevioASintomas = false;
            AntEmp4.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp4);

            AntecedenteEpidemiologicos2 AntEmp5 = new AntecedenteEpidemiologicos2();
            AntEmp5.ApellidoDelCaso = "Bueno";
            AntEmp5.NombreDelCaso = "Carlos";
            AntEmp5.AreaDelCaso = "Centro";
            AntEmp5.CiudadDelCentroVisitado = "La Plata";
            AntEmp5.ContactoConAnimalesPrevioASintomas = true;
            AntEmp5.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp5.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp5.DNIDelCaso = "33124311";
            AntEmp5.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp5.NombreDelCentroVisitado = "Dr Richiardi";
            AntEmp5.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.AVES;
            AntEmp5.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_FAMILIAR;
            AntEmp5.OtroTipoDeContactoConAnimales = "";
            AntEmp5.OtroTipoDeEntornoDeContacto = "";
            AntEmp5.VisitoCentroConCasosPositivosPrevioASintomas = false;
            AntEmp5.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp5);

            AntecedenteEpidemiologicos2 AntEmp6 = new AntecedenteEpidemiologicos2();
            AntEmp6.ApellidoDelCaso = "Urribarri";
            AntEmp6.NombreDelCaso = "Micaela";
            AntEmp6.AreaDelCaso = "Centro";
            AntEmp6.CiudadDelCentroVisitado = "Liniers";
            AntEmp6.ContactoConAnimalesPrevioASintomas = true;
            AntEmp6.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp6.ContactoConPersonasConIRPrevioASintomas = false;
            AntEmp6.DNIDelCaso = "29114637";
            AntEmp6.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp6.NombreDelCentroVisitado = "Perrando";
            AntEmp6.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.MERCADO_DE_ANIMALES_VIVOS;
            AntEmp6.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_LABORAL;
            AntEmp6.OtroTipoDeContactoConAnimales = "";
            AntEmp6.OtroTipoDeEntornoDeContacto = "";
            AntEmp6.VisitoCentroConCasosPositivosPrevioASintomas = true;
            AntEmp6.PaisDelCaso = "Argentina";

            ListaAntecedente.Add(AntEmp6);

            AntecedenteEpidemiologicos2 AntEmp7 = new AntecedenteEpidemiologicos2();
            AntEmp7.ApellidoDelCaso = "Perez";
            AntEmp7.NombreDelCaso = "Martin";
            AntEmp7.AreaDelCaso = "Norte";
            AntEmp7.CiudadDelCentroVisitado = "Barranqueras";
            AntEmp7.ContactoConAnimalesPrevioASintomas = true;
            AntEmp7.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp7.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp7.DNIDelCaso = "41744665";
            AntEmp7.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp7.NombreDelCentroVisitado = "Don Orione";
            AntEmp7.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CERDOS;
            AntEmp7.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_LABORAL;
            AntEmp7.OtroTipoDeContactoConAnimales = "";
            AntEmp7.OtroTipoDeEntornoDeContacto = "";
            AntEmp7.VisitoCentroConCasosPositivosPrevioASintomas = true;
            AntEmp7.PaisDelCaso = "Argentina";
            ListaAntecedente.Add(AntEmp7);


            AntecedenteEpidemiologicos2 AntEmp8 = new AntecedenteEpidemiologicos2();
            AntEmp8.ApellidoDelCaso = "Diaz";
            AntEmp8.NombreDelCaso = "Martin";
            AntEmp8.AreaDelCaso = "centro";
            AntEmp8.CiudadDelCentroVisitado = "Barranqueras";
            AntEmp8.ContactoConAnimalesPrevioASintomas = true;
            AntEmp8.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp8.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp8.DNIDelCaso = "41784239";
            AntEmp8.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp8.NombreDelCentroVisitado = "Don Orione";
            AntEmp8.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CERDOS;
            AntEmp8.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_LABORAL;
            AntEmp8.OtroTipoDeContactoConAnimales = "";
            AntEmp8.OtroTipoDeEntornoDeContacto = "";
            AntEmp8.VisitoCentroConCasosPositivosPrevioASintomas = false;
            AntEmp8.PaisDelCaso = "Argentina";
            ListaAntecedente.Add(AntEmp8);

            AntecedenteEpidemiologicos2 AntEmp9 = new AntecedenteEpidemiologicos2();
            AntEmp9.ApellidoDelCaso = "Fiant";
            AntEmp9.NombreDelCaso = "Carlos";
            AntEmp9.AreaDelCaso = "Norte";
            AntEmp9.CiudadDelCentroVisitado = "Resistencia";
            AntEmp9.ContactoConAnimalesPrevioASintomas = true;
            AntEmp9.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp9.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp9.DNIDelCaso = "37028302";
            AntEmp9.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp9.NombreDelCentroVisitado = "Don Orione";
            AntEmp9.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CERDOS;
            AntEmp9.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_LABORAL;
            AntEmp9.OtroTipoDeContactoConAnimales = "";
            AntEmp9.OtroTipoDeEntornoDeContacto = "";
            AntEmp9.VisitoCentroConCasosPositivosPrevioASintomas = true;
            AntEmp9.PaisDelCaso = "Argentina";
            ListaAntecedente.Add(AntEmp9);

            AntecedenteEpidemiologicos2 AntEmp10 = new AntecedenteEpidemiologicos2();
            AntEmp10.ApellidoDelCaso = "Maradona";
            AntEmp10.NombreDelCaso = "Diego Armando";
            AntEmp10.AreaDelCaso = "Este";
            AntEmp10.CiudadDelCentroVisitado = "Corrientes";
            AntEmp10.ContactoConAnimalesPrevioASintomas = false;
            AntEmp10.ContactoConCasosProbablesOConfirmadosPrevioASintomas = true;
            AntEmp10.ContactoConPersonasConIRPrevioASintomas = true;
            AntEmp10.DNIDelCaso = "41000324";
            AntEmp10.FechaDeLaVisitaAlCentro = DateTime.Now; // este dejenlo asi
            AntEmp10.NombreDelCentroVisitado = "Don Orione";
            AntEmp10.TipoDeAnimalesConContacto = TipoDeAnimalesConContacto.CERDOS;
            AntEmp10.TipoDeEntornoDeContacto = TipoDeEntornoDeContacto.ENTORNO_LABORAL;
            AntEmp10.OtroTipoDeContactoConAnimales = "";
            AntEmp10.OtroTipoDeEntornoDeContacto = "";
            AntEmp10.VisitoCentroConCasosPositivosPrevioASintomas = true;
            AntEmp10.PaisDelCaso = "Argentina";
            ListaAntecedente.Add(AntEmp10);

            return ListaAntecedente;
        }


    }
}
