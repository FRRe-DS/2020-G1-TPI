using Data;
using Modelo;
using System;
using System.Collections.Generic;
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

                FPA.AntecedenteEpidemiologicos1       = ant1[i];
                FPA.AntecedenteEpidemiologicos2         = ant2[i];
                FPA.SignosYSintomas                     = sys[i];
                FPA.EnfermedadesPreviasComorbilidades   = epc[i];
                FPA.Paciente                           = pacientes[i];              
                FPA.FechaDeCreacion = DateTime.Parse($"2/{(i+1).ToString()}/2020", System.Globalization.CultureInfo.InvariantCulture);
                FPA.EstadoDelFormulario = EstadoDelFormulario.GENERADOS;
                
                ListaFPA.Add(FPA);

            }

            dataContext.ListaFormularioParaAnalisis.AddRange(ListaFPA);
            dataContext.SaveChanges();
            
        }
    }
}
