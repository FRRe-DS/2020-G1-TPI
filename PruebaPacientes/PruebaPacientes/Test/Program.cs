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
                CargarFormulario();
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


            static void CargarFormulario()
            {
                try
                {
                    DataContext dataContext = new DataContext();
                    FormuarioParaAnalisisService formuario = new FormuarioParaAnalisisService(dataContext);
                    string Uri = "http://localhost:5000";
                    //bool correcto = false;
                    Console.WriteLine("Autenticando ...");
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(Uri);
                    //httpClient.DefaultRequestHeaders.Accept.Clear();
                    // httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ///var userDTO = new { username = "WebApp", password = "Aa123456#!" };

                    //string userjson = JsonConvert.SerializeObject(userDTO);
                    //HttpContent content = new StringContent(userjson, Encoding.UTF8, "application/json");

                    //string token = null;
                    //string jsontoken = null;
                    //DateTime expiration;

                    //HttpResponseMessage response = httpClient.PostAsJsonAsync("api/account/login", userDTO).Result;
                    /// Console.WriteLine("Autenticacion: " + response.StatusCode);
                    //if (response.StatusCode == HttpStatusCode.OK)
                    //{
                    //jsontoken = response.Content.ReadAsStringAsync().Result;
                    //JObject jsonresult = JObject.Parse(jsontoken);
                    //token = jsonresult.SelectToken("token").ToObject<string>();
                    //expiration = jsonresult.SelectToken("expiration").ToObject<DateTime>();

                    //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


                    Random rand = new Random(DateTime.Now.Second);
                    Console.WriteLine("Comienza Add()");

                    string dtojson = JsonConvert.SerializeObject(formuario.SendFormulario());
                    HttpContent content2 = new StringContent(dtojson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = httpClient.PostAsync("/api/FormularioParaAnalisis/Add", content2).Result;
                    if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response2.StatusCode);
                        Console.WriteLine("Fin Add()");
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

        }

       
    }

   

}
