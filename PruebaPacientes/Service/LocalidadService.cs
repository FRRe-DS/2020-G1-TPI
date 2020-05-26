using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class LocalidadService
    {
        DataContext dataContext;

        public LocalidadService(DataContext context)
        {
            dataContext = context;
        }

        public List<Localidad> GetByProvincia(int Id)
        {
            return dataContext.ListaLocalidades
                        .Where(a => a.ProvinciaId == Id)
                            .ToList();
        }
        
        public void Update(Localidad localidad)
        {
            dataContext.ListaLocalidades.Update(localidad);
            dataContext.SaveChanges();
        }

        public void Add(Localidad localidad)
        {
            dataContext.ListaLocalidades.Add(localidad);
            dataContext.SaveChanges();
        }

        public void Delete(Localidad localidad)
        {
            dataContext.ListaLocalidades.Remove(localidad);
            dataContext.SaveChanges();
        }

        public void CargarLocalidades()
        {
            Localidad localidad = new Localidad();
            localidad.Nombre = "goya";
            localidad.CodigoPostal = "3450";
            localidad.ProvinciaId = 1;
            Add(localidad);

            Localidad localidad1 = new Localidad();
            localidad1.Nombre = "esquina";
            localidad1.CodigoPostal = "3255";
            localidad1.ProvinciaId = 1;
            Add(localidad1);

            Localidad localidad2 = new Localidad();
            localidad2.Nombre = "san roque";
            localidad2.CodigoPostal = "3562";
            localidad2.ProvinciaId = 1;
            Add(localidad2);

            Localidad localidad3 = new Localidad();
            localidad3.Nombre = "resistencia";
            localidad3.CodigoPostal = "3500";
            localidad3.ProvinciaId = 2;
            Add(localidad3);

            Localidad localidad4 = new Localidad();
            localidad4.Nombre = "saenz peña";
            localidad4.CodigoPostal = "3700";
            localidad4.ProvinciaId = 2;
            Add(localidad4);

            Localidad localidad5 = new Localidad();
            localidad5.Nombre = "rio cuarto";
            localidad5.CodigoPostal = "5800";
            localidad5.ProvinciaId = 3;
            Add(localidad5);

            Localidad localidad6 = new Localidad();
            localidad6.Nombre = "rio ceballos";
            localidad6.CodigoPostal = "5111";
            localidad6.ProvinciaId = 3;
            Add(localidad6);

            Localidad localidad7 = new Localidad();
            localidad7.Nombre = "castelli";
            localidad7.CodigoPostal = "7114";
            localidad7.ProvinciaId = 4;
            Add(localidad7);

            Localidad localidad8 = new Localidad();
            localidad8.Nombre = "moron";
            localidad8.CodigoPostal = "1708";
            localidad8.ProvinciaId = 4;
            Add(localidad8);

            Localidad localidad9 = new Localidad();
            localidad9.Nombre = "el cerrito";
            localidad9.CodigoPostal = "4139";
            localidad9.ProvinciaId = 5;
            Add(localidad9);

            Localidad localidad10 = new Localidad();
            localidad10.Nombre = "sauce";
            localidad10.CodigoPostal = "4700";
            localidad10.ProvinciaId = 5;
            Add(localidad10);

            Localidad localidad11 = new Localidad();
            localidad11.Nombre = "angostura";
            localidad11.CodigoPostal = "9105";
            localidad11.ProvinciaId = 6;
            Add(localidad11);

            Localidad localidad12 = new Localidad();
            localidad12.Nombre = "cerro negro";
            localidad12.CodigoPostal = "9223";
            localidad12.ProvinciaId = 6;
            Add(localidad12);

            Localidad localidad13 = new Localidad();
            localidad13.Nombre = "colon";
            localidad13.CodigoPostal = "3280";
            localidad13.ProvinciaId = 7;
            Add(localidad13);

            Localidad localidad14 = new Localidad();
            localidad14.Nombre = "parana";
            localidad14.CodigoPostal = "3100";
            localidad14.ProvinciaId = 7;
            Add(localidad14);

            Localidad localidad15 = new Localidad();
            localidad15.Nombre = "frontera";
            localidad15.CodigoPostal = "3613";
            localidad15.ProvinciaId = 8;
            Add(localidad15);

            Localidad localidad16 = new Localidad();
            localidad16.Nombre = "espinillo";
            localidad16.CodigoPostal = "3630";
            localidad16.ProvinciaId = 8;
            Add(localidad16);

            Localidad localidad17 = new Localidad();
            localidad17.Nombre = "cerrito";
            localidad17.CodigoPostal = "4653";
            localidad17.ProvinciaId = 9;
            Add(localidad17);

            Localidad localidad18 = new Localidad();
            localidad18.Nombre = "cacho";
            localidad18.CodigoPostal = "4513";
            localidad18.ProvinciaId = 9;
            Add(localidad18);

            Localidad localidad19 = new Localidad();
            localidad19.Nombre = "la paloma";
            localidad19.CodigoPostal = "8200";
            localidad19.ProvinciaId = 10;
            Add(localidad19);

            Localidad localidad20 = new Localidad();
            localidad20.Nombre = "el aguila";
            localidad20.CodigoPostal = "8138";
            localidad20.ProvinciaId = 10;
            Add(localidad20);

            Localidad localidad21 = new Localidad();
            localidad21.Nombre = "la rioja";
            localidad21.CodigoPostal = "5300";
            localidad21.ProvinciaId = 11;
            Add(localidad21);

            Localidad localidad22 = new Localidad();
            localidad22.Nombre = "la banda";
            localidad22.CodigoPostal = "5365";
            localidad22.ProvinciaId = 11;
            Add(localidad22);

            Localidad localidad23 = new Localidad();
            localidad23.Nombre = "cerro blanco";
            localidad23.CodigoPostal = "5539";
            localidad23.ProvinciaId = 12;
            Add(localidad23);

            Localidad localidad24 = new Localidad();
            localidad24.Nombre = "asuncion";
            localidad24.CodigoPostal = "5535";
            localidad24.ProvinciaId = 12;
            Add(localidad24);

            Localidad localidad28 = new Localidad();
            localidad28.Nombre = "Posadas";
            localidad28.CodigoPostal = "3300";
            localidad28.ProvinciaId = 13;
            Add(localidad28);

            Localidad localidad29 = new Localidad();
            localidad29.Nombre = "Eldorado";
            localidad29.CodigoPostal = "3380";
            localidad29.ProvinciaId = 13;
            Add(localidad29);

            Localidad localidad30 = new Localidad();
            localidad30.Nombre = "Neuquen";
            localidad30.CodigoPostal = "8300";
            localidad30.ProvinciaId = 14;
            Add(localidad30);

            Localidad localidad31 = new Localidad();
            localidad31.Nombre = "Mallin De Mena";
            localidad31.CodigoPostal = "8347";
            localidad31.ProvinciaId = 14;
            Add(localidad31);

            Localidad localidad32 = new Localidad();
            localidad32.Nombre = "Aguara";
            localidad32.CodigoPostal = "8307";
            localidad32.ProvinciaId = 15;
            Add(localidad32);

            Localidad localidad33 = new Localidad();
            localidad33.Nombre = "Campana Mahuida";
            localidad33.CodigoPostal = "8532";
            localidad33.ProvinciaId = 15;
            Add(localidad33);

            Localidad localidad34 = new Localidad();
            localidad34.Nombre = "Alto Verde";
            localidad34.CodigoPostal = "4535";
            localidad34.ProvinciaId = 16;
            Add(localidad34);

            Localidad localidad35 = new Localidad();
            localidad35.Nombre = "Antilla";
            localidad35.CodigoPostal = "4193";
            localidad35.ProvinciaId = 16;
            Add(localidad35);

            Localidad localidad36 = new Localidad();
            localidad36.Nombre = "9 De Julio";
            localidad36.CodigoPostal = "5417";
            localidad36.ProvinciaId = 17;
            Add(localidad36);

            Localidad localidad37 = new Localidad();
            localidad37.Nombre = "Alcaucha";
            localidad37.CodigoPostal = "5461";
            localidad37.ProvinciaId = 17;
            Add(localidad37);

            Localidad localidad38 = new Localidad();
            localidad38.Nombre = "Bajada";
            localidad38.CodigoPostal = "5711";
            localidad38.ProvinciaId = 18;
            Add(localidad38);

            Localidad localidad39 = new Localidad();
            localidad39.Nombre = "Cerrito";
            localidad39.CodigoPostal = "5753";
            localidad39.ProvinciaId = 18;
            Add(localidad39);

            Localidad localidad40 = new Localidad();
            localidad40.Nombre = "28 De Noviembre";
            localidad40.CodigoPostal = "9407";
            localidad40.ProvinciaId = 19;
            Add(localidad40);

            Localidad localidad41 = new Localidad();
            localidad41.Nombre = "Bahia Langara";
            localidad41.CodigoPostal = "9011";
            localidad41.ProvinciaId = 19;
            Add(localidad41);

            Localidad localidad42 = new Localidad();
            localidad42.Nombre = "Villa Ocampo";
            localidad42.CodigoPostal = "3580";
            localidad42.ProvinciaId = 20;
            Add(localidad42);

            Localidad localidad43 = new Localidad();
            localidad43.Nombre = "Avellaneda";
            localidad43.CodigoPostal = "3561";
            localidad43.ProvinciaId = 20;
            Add(localidad43);

            Localidad localidad44 = new Localidad();
            localidad44.Nombre = "Aerolito";
            localidad44.CodigoPostal = "3741";
            localidad44.ProvinciaId = 21;
            Add(localidad44);

            Localidad localidad45 = new Localidad();
            localidad45.Nombre = "Alpapuca";
            localidad45.CodigoPostal = "5251";
            localidad45.ProvinciaId = 21;
            Add(localidad45);

            Localidad localidad46 = new Localidad();
            localidad46.Nombre = "Base Ejercito Esperanza";
            localidad46.CodigoPostal = "9411";
            localidad46.ProvinciaId = 22;
            Add(localidad46);

            Localidad localidad47 = new Localidad();
            localidad47.Nombre = "Campamento Los Chorrillos Y P";
            localidad47.CodigoPostal = "9420";
            localidad47.ProvinciaId = 22;
            Add(localidad47);

            Localidad localidad48 = new Localidad();
            localidad48.Nombre = "Aguada";
            localidad48.CodigoPostal = "4111";
            localidad48.ProvinciaId = 23;
            Add(localidad48);

            Localidad localidad49 = new Localidad();
            localidad49.Nombre = "Aguilares";
            localidad49.CodigoPostal = "4152";
            localidad49.ProvinciaId = 23;
            Add(localidad49);
        }
    }
}
