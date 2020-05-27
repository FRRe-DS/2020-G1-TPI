using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AntEmp1Service
    {
        DataContext dataContext;

        public AntEmp1Service(DataContext context)
        {
            dataContext = context;
        }

        public List<AntecedenteEpidemiologicos1> GetAntEmp1()
        {
            List<AntecedenteEpidemiologicos1> ListaAntecedentes = new List<AntecedenteEpidemiologicos1>();

            AntecedenteEpidemiologicos1 AntEmp1 = new AntecedenteEpidemiologicos1();
            AntEmp1.CiudadDelPaisEnQueEstuvo = "Roma";
            AntEmp1.CompañiaDeTransporte = "American Air Lines";
            AntEmp1.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp1.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.FechaDeIngresoAlPais = DateTime.Parse("2/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("9/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.FechaDeVacunacion = DateTime.Parse("12/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.FechaDeVencimientoDeLaVacuna = DateTime.Parse("12/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp1.OtroTipoDeOcupacion = "";
            AntEmp1.PaisEnQueEstuvo = "Italia";
            AntEmp1.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp1.TieneVacunaAntiGripal = false;
            AntEmp1.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_ANIMALES;
            AntEmp1.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp1);

            AntecedenteEpidemiologicos1 AntEmp2 = new AntecedenteEpidemiologicos1();
            AntEmp2.CiudadDelPaisEnQueEstuvo = "Valencia";
            AntEmp2.CompañiaDeTransporte = "American Air Lines";
            AntEmp2.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp2.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("10/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.FechaDeIngresoAlPais = DateTime.Parse("11/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("12/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("10/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.FechaDeVacunacion = DateTime.Parse("11/6/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.FechaDeVencimientoDeLaVacuna = DateTime.Parse("12/6/2021", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp2.OtroTipoDeOcupacion = "";
            AntEmp2.PaisEnQueEstuvo = "España";
            AntEmp2.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = false;
            AntEmp2.TieneVacunaAntiGripal = false;
            AntEmp2.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_ANIMALES;
            AntEmp2.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp2);

            AntecedenteEpidemiologicos1 AntEmp3 = new AntecedenteEpidemiologicos1();
            AntEmp3.CiudadDelPaisEnQueEstuvo = "Rio";
            AntEmp3.CompañiaDeTransporte = "Aerolineas Argentinas";
            AntEmp3.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp3.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("11/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.FechaDeIngresoAlPais = DateTime.Parse("12/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("10/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("11/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.FechaDeVacunacion = DateTime.Parse("7/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.FechaDeVencimientoDeLaVacuna = DateTime.Parse("11/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp3.OtroTipoDeOcupacion = "Programador";
            AntEmp3.PaisEnQueEstuvo = "Brasil";
            AntEmp3.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp3.TieneVacunaAntiGripal = true;
            AntEmp3.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.OTROS;
            AntEmp3.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp3);

            AntecedenteEpidemiologicos1 AntEmp4 = new AntecedenteEpidemiologicos1();
            AntEmp4.CiudadDelPaisEnQueEstuvo = "Montevideo";
            AntEmp4.CompañiaDeTransporte = "Concordia";
            AntEmp4.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = false;
            AntEmp4.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.FechaDeIngresoAlPais = DateTime.Parse("2/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("9/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.FechaDeVacunacion = DateTime.Parse("7/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.FechaDeVencimientoDeLaVacuna = DateTime.Parse("10/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp4.OtroTipoDeOcupacion = "";
            AntEmp4.PaisEnQueEstuvo = "Uruguay";
            AntEmp4.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = false;
            AntEmp4.TieneVacunaAntiGripal = false;
            AntEmp4.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_ANIMALES;
            AntEmp4.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.BARCO;

            ListaAntecedentes.Add(AntEmp4);

            AntecedenteEpidemiologicos1 AntEmp5 = new AntecedenteEpidemiologicos1();
            AntEmp5.CiudadDelPaisEnQueEstuvo = "Sao Pablo";
            AntEmp5.CompañiaDeTransporte = "Bus de Brasil";
            AntEmp5.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp5.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.FechaDeIngresoAlPais = DateTime.Parse("2/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("5/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.FechaDeVacunacion = DateTime.Parse("12/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.FechaDeVencimientoDeLaVacuna = DateTime.Parse("8/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp5.OtroTipoDeOcupacion = "";
            AntEmp5.PaisEnQueEstuvo = "Brasil";
            AntEmp5.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp5.TieneVacunaAntiGripal = true;
            AntEmp5.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_LABORATORIOS;
            AntEmp5.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.OMNIUS;

            ListaAntecedentes.Add(AntEmp5);

            AntecedenteEpidemiologicos1 AntEmp6 = new AntecedenteEpidemiologicos1();
            AntEmp6.CiudadDelPaisEnQueEstuvo = "Roma";
            AntEmp6.CompañiaDeTransporte = "American Air Lines";
            AntEmp6.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp6.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.FechaDeIngresoAlPais = DateTime.Parse("2/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("10/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.FechaDeVacunacion = DateTime.Parse("11/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.FechaDeVencimientoDeLaVacuna = DateTime.Parse("11/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp6.OtroTipoDeOcupacion = "Asafata";
            AntEmp6.PaisEnQueEstuvo = "Italia";
            AntEmp6.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp6.TieneVacunaAntiGripal = true;
            AntEmp6.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.OTROS;
            AntEmp6.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp6);

            AntecedenteEpidemiologicos1 AntEmp7 = new AntecedenteEpidemiologicos1();
            AntEmp7.CiudadDelPaisEnQueEstuvo = "Roma";
            AntEmp7.CompañiaDeTransporte = "American Air Lines";
            AntEmp7.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp7.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.FechaDeIngresoAlPais = DateTime.Parse("2/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("9/2/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.FechaDeVacunacion = DateTime.Parse("5/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.FechaDeVencimientoDeLaVacuna = DateTime.Parse("12/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp7.OtroTipoDeOcupacion = "Piloto";
            AntEmp7.PaisEnQueEstuvo = "Italia";
            AntEmp7.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = false;
            AntEmp7.TieneVacunaAntiGripal = false;
            AntEmp7.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.OTROS;
            AntEmp7.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp7);

            AntecedenteEpidemiologicos1 AntEmp8 = new AntecedenteEpidemiologicos1();
            AntEmp8.CiudadDelPaisEnQueEstuvo = "Lima";
            AntEmp8.CompañiaDeTransporte = "Latam";
            AntEmp8.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp8.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.FechaDeIngresoAlPais = DateTime.Parse("2/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("4/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.FechaDeVacunacion = DateTime.Parse("6/5/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.FechaDeVencimientoDeLaVacuna = DateTime.Parse("4/8/2029", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp8.OtroTipoDeOcupacion = "";
            AntEmp8.PaisEnQueEstuvo = "Peru";
            AntEmp8.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp8.TieneVacunaAntiGripal = true;
            AntEmp8.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_ANIMALES;
            AntEmp8.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp8);

            AntecedenteEpidemiologicos1 AntEmp9 = new AntecedenteEpidemiologicos1();
            AntEmp9.CiudadDelPaisEnQueEstuvo = "Miami";
            AntEmp9.CompañiaDeTransporte = "American Yanke EEUU";
            AntEmp9.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp9.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/12/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.FechaDeIngresoAlPais = DateTime.Parse("2/12/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/12/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("8/12/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.FechaDeVacunacion = DateTime.Parse("3/8/2018", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.FechaDeVencimientoDeLaVacuna = DateTime.Parse("3/8/2019", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp9.OtroTipoDeOcupacion = "";
            AntEmp9.PaisEnQueEstuvo = "EEUU";
            AntEmp9.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = true;
            AntEmp9.TieneVacunaAntiGripal = true;
            AntEmp9.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.TRABAJA_EN_LABORATORIOS;
            AntEmp9.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;

            ListaAntecedentes.Add(AntEmp9);

            AntecedenteEpidemiologicos1 AntEmp10 = new AntecedenteEpidemiologicos1();
            AntEmp10.CiudadDelPaisEnQueEstuvo = "Roma";
            AntEmp10.CompañiaDeTransporte = "American Eusropea";
            AntEmp10.EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = true;
            AntEmp10.FechaDeLlegadaAlPaisEnQueEstuvo = DateTime.Parse("1/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.FechaDeIngresoAlPais = DateTime.Parse("2/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.FechaDeLlegadaADomicilioAjeno = DateTime.Parse("8/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.FechaDeSalidaDelDomicilioAjeno = DateTime.Parse("6/1/2020", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.FechaDeVacunacion = DateTime.Parse("4/5/2016", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.FechaDeVencimientoDeLaVacuna = DateTime.Parse("7/8/2025", System.Globalization.CultureInfo.InvariantCulture);
            AntEmp10.OtroTipoDeOcupacion = "Desocupado";
            AntEmp10.PaisEnQueEstuvo = "España";
            AntEmp10.ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = false;
            AntEmp10.TieneVacunaAntiGripal = false;
            AntEmp10.TipoDeOcupacionDelPaciente = TipoDeOcupacionDelPaciente.OTROS;
            AntEmp10.TipoDeTransporteUtilizado = TipoDeTransporteUtilizado.AVION;
            ListaAntecedentes.Add(AntEmp10);

            return ListaAntecedentes;
        }
    }
}
