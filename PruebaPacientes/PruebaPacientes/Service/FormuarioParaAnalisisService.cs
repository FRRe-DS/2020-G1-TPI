using Data;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class FormuarioParaAnalisisService
    {

        DataContext dataContext;

        public FormuarioParaAnalisisService(DataContext context)
        {
            dataContext = context;
        }

        public List<FormularioParaAnalisis> GetAll()
        {
            return dataContext.ListaFormularioParaAnalisis
                .Include("AntecedenteEpidemiologicos1")
                .Include("AntecedenteEpidemiologicos2")
                .Include("Paciente")
                .Include("SignosYSintomas")
                .Include("EnfermedadesPreviasComorbilidades")
                .ToList();
        }

        public void Update(FormularioParaAnalisis FPA)
        {
            dataContext.ListaFormularioParaAnalisis.Update(FPA);
            dataContext.SaveChanges();
        }

        public void Add(FormularioParaAnalisis FPA)
        {
            dataContext.ListaFormularioParaAnalisis.Add(FPA);
            dataContext.SaveChanges();
        }

        public void Delete(FormularioParaAnalisis FPA)
        {
            dataContext.ListaFormularioParaAnalisis.Remove(FPA);
            dataContext.SaveChanges();
        }

        public void CargarFormularios()
        {
            List<FormularioParaAnalisis> ListaFPA = new List<FormularioParaAnalisis>();

            AntEmp1Service antEmp1Service1 = new AntEmp1Service(dataContext);
            AntEmp2Service antEmp1Service2 = new AntEmp2Service(dataContext);
            EPCService ePCService = new EPCService(dataContext);
            SignosYsintomasService signosYsintomasService = new SignosYsintomasService(dataContext);
            PacienteService pacienteService = new PacienteService(dataContext);
            DomicilioService domicilioService = new DomicilioService(dataContext);

            List<AntecedenteEpidemiologicos1> ant1 = antEmp1Service1.GetAntEmp1();
            List<AntecedenteEpidemiologicos2> ant2 = antEmp1Service2.GetAntEmp2();
            List<EnfermedadesPreviasComorbilidades> epc = ePCService.GetEPC();
            List<SignosYSintomas> sys = signosYsintomasService.GetSignosYsintomas();
            List<Paciente> pacientes = pacienteService.GetPacientes();
            List<Domicilio> domicilios = domicilioService.GetDomicilios();


            for (int i = 0; i < 10; i++)
            {
                FormularioParaAnalisis FPA = new FormularioParaAnalisis();

                FPA.AntecedenteEpidemiologicos1 = ant1[i];
                FPA.AntecedenteEpidemiologicos2 = ant2[i];
                FPA.SignosYSintomas = sys[i];
                FPA.EnfermedadesPreviasComorbilidades = epc[i];
                FPA.Paciente = pacientes[i];
                FPA.FechaDeCreacion = DateTime.Parse($"2/{(i + 1).ToString()}/2020", System.Globalization.CultureInfo.InvariantCulture);
                FPA.EstadoDelFormulario = EstadoDelFormulario.GENERADOS;

                ListaFPA.Add(FPA);

            }

            dataContext.ListaFormularioParaAnalisis.AddRange(ListaFPA);
            dataContext.SaveChanges();

        }

        public FormularioParaAnalisis SendFormulario()
        {
            FormularioParaAnalisis FPA = new FormularioParaAnalisis();

            AntEmp1Service antEmp1Service1 = new AntEmp1Service(dataContext);
            AntEmp2Service antEmp1Service2 = new AntEmp2Service(dataContext);
            EPCService ePCService = new EPCService(dataContext);
            SignosYsintomasService signosYsintomasService = new SignosYsintomasService(dataContext);
            PacienteService pacienteService = new PacienteService(dataContext);
            DomicilioService domicilioService = new DomicilioService(dataContext);

            List<AntecedenteEpidemiologicos1> ant1 = antEmp1Service1.GetAntEmp1();
            List<AntecedenteEpidemiologicos2> ant2 = antEmp1Service2.GetAntEmp2();
            List<EnfermedadesPreviasComorbilidades> epc = ePCService.GetEPC();
            List<SignosYSintomas> sys = signosYsintomasService.GetSignosYsintomas();
            List<Paciente> pacientes = pacienteService.GetPacientes();
            List<Domicilio> domicilios = domicilioService.GetDomicilios();


            var seed = Environment.TickCount;
            var random = new Random(seed);
            var i = random.Next(0, 9);
            FPA.AntecedenteEpidemiologicos1 = ant1[i];
            
            var seed1 = Environment.TickCount;
            var random1 = new Random(seed1);
            var v = random.Next(0, 9);
            FPA.AntecedenteEpidemiologicos2 = ant2[v];
            
            var seed2 = Environment.TickCount;
            var random2 = new Random(seed2);
            var c = random.Next(0, 9);
            FPA.SignosYSintomas = sys[c];
            
            var seed3 = Environment.TickCount;
            var random3 = new Random(seed3);
            var x = random.Next(0, 9);
            FPA.EnfermedadesPreviasComorbilidades = epc[x];
            
            var seed5 = Environment.TickCount;
            var random5 = new Random(seed5);
            var e = random.Next(0, 9);
            pacientes[e].NroDeDocumento = (e * 15251).ToString();
            FPA.Paciente = pacientes[e];
            
            var seed4 = Environment.TickCount;
            var random4 = new Random(seed4);
            var z = random.Next(0, 9);
            FPA.FechaDeCreacion = DateTime.Parse($"2/{(z + 1).ToString()}/2020", System.Globalization.CultureInfo.InvariantCulture);
            FPA.EstadoDelFormulario = EstadoDelFormulario.GENERADOS;

            return FPA;


        }
    }
}
