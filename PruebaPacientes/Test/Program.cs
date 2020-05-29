using Data;
using Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Service;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de Carga de Formulario...");

            DataContext dataContext = new DataContext();
            //ProvinciaService provinciaService = new ProvinciaService(dataContext);
            try
            {
                //localidadService.CargarLocalidades();

                AntEmp1Service antEmp1Service1 = new AntEmp1Service(dataContext);
                AntEmp2Service antEmp1Service2 = new AntEmp2Service(dataContext);
                EPCService ePCService = new EPCService(dataContext);
                SignosYsintomasService signosYsintomasService = new SignosYsintomasService(dataContext);
                PacienteService pacienteService = new PacienteService(dataContext);
                FormuarioParaAnalisisService formuario = new FormuarioParaAnalisisService(dataContext);
                ProvinciaService provinciaService = new ProvinciaService(dataContext);
                LocalidadService localidadService = new LocalidadService(dataContext);

                List<AntecedenteEpidemiologicos1> ant1 = antEmp1Service1.GetAntEmp1();
                List<AntecedenteEpidemiologicos2> ant2 = antEmp1Service2.GetAntEmp2();
                List<EnfermedadesPreviasComorbilidades> epc = ePCService.GetEPC();
                List<SignosYSintomas> sys = signosYsintomasService.GetSignosYsintomas();
                List<Paciente> pacientes = pacienteService.GetPacientes();
                var p = pacienteService.GetPacientes();
                //var Lista = provinciaService.GetProvincias();
                var Lista = localidadService.GetLocalidades();
               
                //for (int i = 0; i < 100; i++)
                //{
                //    CargarFormulario();
                //}
                //int x = ant1.Count;
                // int xx = ant2.Count;
                //int xxx = epc.Count;
                // int xxxx = sys.Count;
                // int xxxxx = pacientes.Count;

                // Console.WriteLine(x.ToString());
                // Console.WriteLine(xx.ToString());
                // Console.WriteLine(xxx.ToString());
                // Console.WriteLine(xxxx.ToString());
                // Console.WriteLine(xxxxx.ToString());
                //FormularioParaAnalisis f = formuario.SendFormulario();
                //formuario.CargarFormularios();
                // CargarFormulario();
                //Console.WriteLine("Termino la carga");

                for (int i = 0; i < 6; i++)
                {
                    SetearComoEnviado(i);
                }                
                Console.WriteLine("Fin de Cargar");
            }
            catch (Exception ex)
            {

                Console.WriteLine(Tools.Tools.ExceptionMessage(ex));
            }

            //List<Domicilio> ListaDomicilio = new List<Domicilio>();

            //Domicilio domicilio = new Domicilio();
            //domicilio.Calle = "French";
            //domicilio.NroDeCalle = "414";
            //domicilio.NroDeDpto = "";
            //domicilio.Piso = "";
            //domicilio.Dpto = "";
            //domicilio.LocalidadId = 1;
            //ListaDomicilio.Add(domicilio);


            static void CargarFormulario()
            {
                try
                {
                    DataContext dataContext = new DataContext();
                    FormuarioParaAnalisisService formuario = new FormuarioParaAnalisisService(dataContext);
                    //string Uri = "http://localhost:5000";
                    string Uri = "http://40.118.242.96:12600";
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);

                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza Add()");

                    string dtojson = JsonConvert.SerializeObject(formuario.SendFormulario()); // aca va el DTO de formulario 
                    HttpContent content2 = new StringContent(dtojson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = httpClient.PostAsync("/api/FormularioParaAnalisis/Add", content2).Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin Add() Formulario");
                    }
                    else
                    {
                        Console.WriteLine(response2.ReasonPhrase);
                        Console.WriteLine("Error Add()");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                //}
            }

            static void CargarFormularioParaAnalisis(FormularioParaAnalisis formulario)
            {
                try
                {

                    DataContext dataContext = new DataContext();
                    FormuarioParaAnalisisService formuario = new FormuarioParaAnalisisService(dataContext);
                    string Uri = "http://40.118.242.96:12600";
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);

                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza Add()");

                    string dtojson = JsonConvert.SerializeObject(formuario); // aca va el DTO de formulario 
                    HttpContent content2 = new StringContent(dtojson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = httpClient.PostAsync("/api/FormularioParaAnalisis/Add", content2).Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin Add() Formulario");
                    }
                    else
                    {
                        Console.WriteLine(response2.ReasonPhrase);
                        Console.WriteLine("Error Add()");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                //}
            }


            static void CargarProvincias(Provincia provincia)
            {
                try
                {
                    DataContext dataContext = new DataContext();
                    ProvinciaService provinciaService = new ProvinciaService(dataContext);
                    //string Uri = "http://localhost:5000";
                    string Uri = "http://40.118.242.96:12600";
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);

                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza Add()");

                    string dtojson = JsonConvert.SerializeObject(provincia); 
                    HttpContent content2 = new StringContent(dtojson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = httpClient.PostAsync("/api/Provincia/Add", content2).Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin Add() Provincia");
                    }
                    else
                    {
                        Console.WriteLine(response2.ReasonPhrase);
                        Console.WriteLine("Error Add()");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                //}
            }

            static void CargarLocalidades(Localidad localidad)
            {
                try
                {
                    DataContext dataContext = new DataContext();
                    LocalidadService localidadService = new LocalidadService(dataContext);
                    //string Uri = "http://localhost:5000";
                    string Uri = "http://40.118.242.96:12600";
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);

                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza Add()");

                    string dtojson = JsonConvert.SerializeObject(localidad);
                    HttpContent content2 = new StringContent(dtojson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = httpClient.PostAsync("/api/Localidad/Add", content2).Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin Add() Localidad");
                    }
                    else
                    {
                        Console.WriteLine(response2.ReasonPhrase);
                        Console.WriteLine("Error Add()");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                //}
            }

            static void SetearComoEnviado(int FormularioId)
            {
                try
                {
                    DataContext dataContext = new DataContext();
                    LocalidadService localidadService = new LocalidadService(dataContext);
                    //string Uri = "http://localhost:5000";
                    string Uri = "http://40.118.242.96:12600";
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);

                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza SetRecibido()");

                    HttpResponseMessage response2 = httpClient.GetAsync($"/api/FormularioParaAnalisis/SetRecibido/{FormularioId.ToString()}").Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin SetRecibido() Formulario");
                    }
                    else
                    {
                        Console.WriteLine(response2.ReasonPhrase);
                        Console.WriteLine("Error Formulario()");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            // Yo las consulta que creo que tienen que estar es 1 la de guardar el formulario esa es obvio
            // Y después cuando consulta con el dni.Tiene que sabes si esa persona 
            // 1 relleno el formulario
            // 2 si se está evaluando ósea envío pero no tenemos respuesta
            // 3 decir que si se tiene que acercar a tal hospital a tal horario
            // 4 que no es necesario que se acerque
            // 5 que si hizo el análisis médico pero no está el resultado
            // Y bueno el último
            // Si es positivo
            // O negativo
            // Eso creo que es todo

        }


    }

   

}
