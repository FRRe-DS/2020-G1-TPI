using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Service
{
    public class PacienteService 
    {
        DataContext dataContext;

        public PacienteService(DataContext context)
        {
            dataContext = context;
        }


        public List<Paciente> GetAll()
        {
            return dataContext.ListaPaciente.ToList();
        }

        public Paciente GetByDNI(string DNI)
        {
            return dataContext.ListaPaciente
                .Where(a => a.TipoDeDocumento == TipoDeDocumento.DNI && a.NroDeDocumento == DNI)
                .SingleOrDefault();
        }

        public void Update(Paciente paciente)
        {
            dataContext.ListaPaciente.Update(paciente);
            dataContext.SaveChanges();
        }

        public void Add(Paciente paciente)
        {
            dataContext.ListaPaciente.Add(paciente);
            dataContext.SaveChanges();
        }
        
        public void Delete(Paciente paciente)
        {
            dataContext.ListaPaciente.Remove(paciente);
            dataContext.SaveChanges();
        }

        public List<Paciente> GetPacientes()
        {
            List<Paciente> ListaPaciente = new List<Paciente>();

            Paciente paciente2 = new Paciente();
            paciente2.Apellido = "Medina";
            paciente2.Nombre = "Roberto";
            paciente2.NroDeDocumento = "31321634";
            paciente2.Sexo = "Masculino";
            paciente2.Telefono = "3624321141";
            paciente2.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente2.Correo = "medinar@hotmail.com";
            paciente2.FechaDeNacimiento = DateTime.Parse("1/1/1995", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente2);

            Paciente paciente3 = new Paciente();
            paciente3.Apellido = "Jhonson";
            paciente3.Nombre = "Maria";
            paciente3.NroDeDocumento = "29132632";
            paciente3.Sexo = "Femenino";
            paciente3.Telefono = "3625121134";
            paciente3.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente3.Correo = "jmari@hotmail.com";
            paciente3.FechaDeNacimiento = DateTime.Parse("2/3/1990", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente3);

            Paciente paciente4 = new Paciente();
            paciente4.Apellido = "Rodriguez";
            paciente4.Nombre = "Maximiliano";
            paciente4.NroDeDocumento = "21724622";
            paciente4.Sexo = "Masculino";
            paciente4.Telefono = "3624724312";
            paciente4.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente4.Correo = "mrodriguez@gmail.com";
            paciente4.FechaDeNacimiento = DateTime.Parse("2/12/1986", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente4);

            Paciente paciente5 = new Paciente();
            paciente5.Apellido = "Encinas";
            paciente5.Nombre = "Katherine";
            paciente5.NroDeDocumento = "31322696";
            paciente5.Sexo = "Femenino";
            paciente5.Telefono = "3624131186";
            paciente5.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente5.Correo = "Kencinas23@hotmail.com";
            paciente5.FechaDeNacimiento = DateTime.Parse("10/2/1994", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente5);

            Paciente paciente6 = new Paciente();
            paciente6.Apellido = "Bueno";
            paciente6.Nombre = "Carlos";
            paciente6.NroDeDocumento = "28321376";
            paciente6.Sexo = "Masculino";
            paciente6.Telefono = "3624112167";
            paciente6.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente6.Correo = "buenoc88@hotmail.com";
            paciente6.FechaDeNacimiento = DateTime.Parse("10/4/1988", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente6);

            Paciente paciente7 = new Paciente();
            paciente7.Apellido = "Urribarri";
            paciente7.Nombre = "Micaela";
            paciente7.NroDeDocumento = "29114637";
            paciente7.Sexo = "Femenino";
            paciente7.Telefono = "3624325188";
            paciente7.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente7.Correo = "micau@gmail.com";
            paciente7.FechaDeNacimiento = DateTime.Parse("10/2/1989", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente7);

            Paciente paciente8 = new Paciente();
            paciente8.Apellido = "Perez";
            paciente8.Nombre = "Martin";
            paciente8.NroDeDocumento = "41744665";
            paciente8.Sexo = "Masculino";
            paciente8.Telefono = "3624713319";
            paciente8.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente8.Correo = "martinp10@gmail.com";
            paciente8.FechaDeNacimiento = DateTime.Parse("6/3/2000", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente8);

            Paciente paciente9 = new Paciente();
            paciente9.Apellido = "Martinez";
            paciente9.Nombre = "Roxana";
            paciente9.NroDeDocumento = "42944383";
            paciente9.Sexo = "Femenino";
            paciente9.Telefono = "3625339923";
            paciente9.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente9.Correo = "mroxi3@hotmail.com";
            paciente9.FechaDeNacimiento = DateTime.Parse("11/2/2002", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente9);

            Paciente paciente10 = new Paciente();
            paciente10.Apellido = "Brunetta";
            paciente10.Nombre = "Ramon";
            paciente10.NroDeDocumento = "10434228";
            paciente10.Sexo = "Masculino";
            paciente10.Telefono = "3624449295";
            paciente10.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente10.Correo = "rbrunett4@hotmail.com";
            paciente10.FechaDeNacimiento = DateTime.Parse("12/6/1965", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente10);

            Paciente paciente11 = new Paciente();
            paciente11.Apellido = "Brown";
            paciente11.Nombre = "Rodrigo";
            paciente11.NroDeDocumento = "17434184";
            paciente11.Sexo = "Masculino";
            paciente11.Telefono = "3624117547";
            paciente11.TipoDeDocumento = TipoDeDocumento.DNI;
            paciente11.Correo = "rbrown1@hotmail.com";
            paciente11.FechaDeNacimiento = DateTime.Parse("11/2/1975", System.Globalization.CultureInfo.InvariantCulture);
            ListaPaciente.Add(paciente11);

            DomicilioService domicilioService = new DomicilioService(dataContext);

            List<Domicilio> domicilios = domicilioService.GetDomicilios();

            for (int i = 0; i < 10; i++)
            {
                ListaPaciente[i].Domicilio = domicilios[i];
            }
            return ListaPaciente;
        }
    }

    
}
