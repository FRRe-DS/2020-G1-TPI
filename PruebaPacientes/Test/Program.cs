using Data;
using Modelo;
using Service;
using Service.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de Carga...");

            DataContext dataContext = new DataContext();
            //ProvinciaService provinciaService = new ProvinciaService(dataContext);
            LocalidadService localidadService = new LocalidadService(dataContext);
            try
            {
                //localidadService.CargarLocalidades();

                AntEmp1Service antEmp1Service1 = new AntEmp1Service(dataContext);
                AntEmp2Service antEmp1Service2 = new AntEmp2Service(dataContext);
                EPCService ePCService = new EPCService(dataContext);
                SignosYsintomasService signosYsintomasService = new SignosYsintomasService(dataContext);
                PacienteService pacienteService = new PacienteService(dataContext);
                FormuarioParaAnalisisService formuario = new FormuarioParaAnalisisService(dataContext);

                List<AntecedenteEpidemiologicos1> ant1 = antEmp1Service1.GetAntEmp1();
                List<AntecedenteEpidemiologicos2> ant2 = antEmp1Service2.GetAntEmp2();
                List<EnfermedadesPreviasComorbilidades> epc = ePCService.GetEPC();
                List<SignosYSintomas> sys = signosYsintomasService.GetSignosYsintomas();
                List<Paciente> pacientes = pacienteService.GetPacientes();

                int x = ant1.Count;
                int xx = ant2.Count;
                int xxx = epc.Count;
                int xxxx = sys.Count;
                int xxxxx = pacientes.Count;

                Console.WriteLine(x.ToString());
                Console.WriteLine(xx.ToString());
                Console.WriteLine(xxx.ToString());
                Console.WriteLine(xxxx.ToString());
                Console.WriteLine(xxxxx.ToString());

                formuario.CargarFormularios();

                //Console.WriteLine("Termino la carga");
                Console.WriteLine("Fin");
            }
            catch (Exception ex)
            {

                Console.WriteLine(Tools.Tools.ExceptionMessage(ex));
            }

            List<Domicilio> ListaDomicilio = new List<Domicilio>();

            Domicilio domicilio = new Domicilio();
            domicilio.Calle = "French";
            domicilio.NroDeCalle = "414";
            domicilio.NroDeDpto = "";
            domicilio.Piso = "";
            domicilio.Dpto = "";
            domicilio.LocalidadId = 1;
            ListaDomicilio.Add(domicilio);




        }



    }
}
