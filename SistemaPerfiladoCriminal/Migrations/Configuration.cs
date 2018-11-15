namespace SistemaPerfiladoCriminal.Migrations
{
    using SistemaPerfiladoCriminal.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaPerfiladoCriminal.Context.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            //  This method will be called after migrating to the latest version. //You can use the DbSet<T>.AddOrUpdate() helper extension method //to avoid creating duplicate seed data.

            context.Casos.AddOrUpdate(x => x.LintId, crearCaso(context));
            //context.Autores.AddOrUpdate(x => x.LintId, crearAutor(context));
            //context.Reconstrucciones.AddOrUpdate(x => x.LintId, crearReconstruccion(context));
            //context.Escenarios.AddOrUpdate(x => x.LintId, crearEscenario(context));
            //context.Victimas.AddOrUpdate(x => x.LintId, crearVictima(context));
        }

        public Caso crearCaso(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            List<Victima> victimas = new List<Victima>();
            victimas.Add(crearVictima(context));

            List<Escenario> escenarios = new List<Escenario>();
            escenarios.Add(crearEscenario(context));

            List<Reconstruccion> reconstrucciones = new List<Reconstruccion>();
            reconstrucciones.Add(crearReconstruccion(context));

            List<Autor> autores = new List<Autor>();
            autores.Add(crearAutor(context));


            return new Caso()
            {
                LstrNombre = "Caso 2",
                LcolVictimas = victimas,
                LcolEscenarios = escenarios,
                LcolReconstrucciones = reconstrucciones,
                LcolAutores = autores
            };
        }

        public Victima crearVictima(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            Indicio indicio1 = new Indicio("Indicio 2");
            List<Indicio> indicios = new List<Indicio>();
            indicios.Add(indicio1);
            
            EntrevistaVictima entrevista1 = new EntrevistaVictima("entrevista 3 nombre", "entrevista 3 descripcion");

            EntrevistaVictima entrevista2 = new EntrevistaVictima("entrevista 4 nombre", "entrevista 4 descripcion");

            List<EntrevistaVictima> entrevistas = new List<EntrevistaVictima>();
            entrevistas.Add(entrevista1);
            entrevistas.Add(entrevista2);
            
            return new Victima()
            {
                //LstrFotoURL = "http://www.noverbal.es/uploads/blog/criminal.jpg",
                LstrNombre = "Victima 2",
                LstrCausa = "Causa 2",
                LstrAlias = "Alias 2",
                LstrSexo = "Femenino",
                LstrCedula = "1111111111111111",
                LstrNacionalidad = "costarricense",
                LstrTez = "Blanca",
                LstrCabello = "Cafe",
                LstrOjos = "claros, pequeños",
                LstrMarcasEspeciales = "Tatuaje",
                LstrOcupacion = "Trabajadora",
                LstrEscolaridad = "Sexto",
                LstrCreenciaReligiosa = "musulmana",
                LstrHabitos = "comia carne",
                LstrPasatiempos = "ver television",
                LstrPadecimientos = "Tiroides",
                LstrHistorialMedico = "Expediente en el EBAIS",
                LstrLugarNacimiento = "San Jose",
                LstrDireccion = "Segun el sistema ECU desde el año 2007 se ubica en Alajuelita",
                LstrTelefono = "88888888",
                LstrEstadoConyugal = "Soltera",
                LstrSalidasPais = "N/A",
                LstrExpedienteCriminal = "B1232345",
                LstrPasadaPor = "Desobediencia en el 2007",
                LstrPrivacionLibertad = "Recluida en el centro de Atencion",
                LstrInformacionResenia = "n/a",
                LstrAutopsia = "Antropofagia",
                LstrDictamenToxicologico = "Positivo en cocaina",
                LstrLaboratorio = "Ropas elementos botanicos",
                LstrFluidosBiologicos = "n/a",
                LstrManeraMuerte = "Indeterminada",
                LstrCausaMuerte = "N/A",
                LstrLesionesEncontradasAutopsia = "n/a",
                LstrToxicologia = "n/a",
                LdtiFechaNacimiento = new DateTime(1980, 04, 10, 16, 25, 00),
                LintEdad = 38,
                LdblPeso = 70.2,
                LdblEstatura = 1.80,
                LmvMadreVictima = "Madre 1, 888888888",
                LpvPadreVictima = "Padre 1, 77777777",
                LmvMatrimonioVictima = "Matrimonio Nacionalidad 2, 2222222222, Costarricense, 10/2/1950",
                LpsvParejaSentimentalVictima = "Pareja sentimental 2, 123712398213, Pareja sentimental alias 1, Pareja sentimental telefono 1",
                LcolHermanos = "Hermano 1, 6666887687",
                LcolHijos = "hijo 1 nombre, cedula, hijo 1 nacionalidad, 23, hijo 1 telefono",
                LcolEntrevistas = entrevistas
            };
        }

        public Escenario crearEscenario(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            Indicio indicio1 = new Indicio("Indicio 3");
            Indicio indicio2 = new Indicio("Indicio 4");

            List<Indicio> indicios = new List<Indicio>();
            indicios.Add(indicio1);
            indicios.Add(indicio2);

            EntrevistaEscenario entrevista1 = new EntrevistaEscenario("Nombre 3", "No sabe que sucedio 3");
            EntrevistaEscenario entrevista2 = new EntrevistaEscenario("Nombre 4", "No sabe que sucedio 4");

            List<EntrevistaEscenario> entrevistas = new List<EntrevistaEscenario>();
            entrevistas.Add(entrevista1);
            entrevistas.Add(entrevista2);
            
            return new Escenario("Escenario 2") {
                LstrDiaHallazgo = "Viernes",
                LstrHoraHallazgo = "13:26 horas segun central de radio",
                LstrUbicacion = "Hatillo Centro, del restaurante",
                LstrSitioHallazgo = "Lote baldio",
                LstrCaracteristicasSitio = "Propiedad de forma de cuña",
                LstrCondionesAcceso = "Tiene acceso desde el frente",
                LstrFrecuenciaPaso = "De uso frecuente para los que viven en el residencial",
                LstrVictimaEncontradaPor = "Vecinos de la localidad alertan a las autoridades por un fuerte mal olor al fondo de la propiedad encontrando el cuerpo, vecina del Residencial Mayorca, nadie observó lo que pasó pero olía muy feo como animal muerto. Un muchacho se asomó y encontró el cuerpo. En la zona frecuentan indigentes de Sagrada Familia y otros sectores.",
                LstrPosicionCuerpo = "Decubito dorsal, brazos ligeramente extendidos",
                LstrDescripcionVestimentas = "Un suéter de cremallera abierta",
                LstrPertenencias = "No se encontraron objetos de valor",
                LstrFenomenosCadavericos = "Cuerpo en fase enfisematosa en miembros inferiores",
                LstrDictamenMedicoLegal = "Realizado el 22 Julio 2015",
                LstrCustodiaSitioSuceso = "Fuerza Pública de Hatillo",
                LcolIndicios = indicios,
                LcolEntrevistas = entrevistas,
                LstrFechaHallazgo = new DateTime(2015, 04, 10, 8, 30, 00),
                LdtiHoraLevantamientoCuerpo = new DateTime(2015, 04, 10, 16, 25, 00)
            };
        }

        public Reconstruccion crearReconstruccion(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            CaracteristicasReconstruccion cr1 = new CaracteristicasReconstruccion("Detalle Reconstruccion 3");
            CaracteristicasReconstruccion cr2 = new CaracteristicasReconstruccion("Detalle Reconstruccion 4");


            List<CaracteristicasReconstruccion> caractReconstruccion = new List<CaracteristicasReconstruccion>();
            caractReconstruccion.Add(cr1);
            caractReconstruccion.Add(cr2);

            Reconstruccion reconstruccion1 = new Reconstruccion() { LcolCaracteristicas = caractReconstruccion };
            reconstruccion1.LstrNombre = "Reconstruccion 2";
            return reconstruccion1;
        }

        public Autor crearAutor(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            DetallesAutor da1 = new DetallesAutor("Detalle autor 3");
            DetallesAutor da2 = new DetallesAutor("Detalle autor 4");

            List<DetallesAutor> detallesAutor = new List<DetallesAutor>();
            detallesAutor.Add(da1);
            detallesAutor.Add(da2);

            Autor autor1 = new Autor() { LcolDetalles = detallesAutor };
            autor1.LstrNombre = "Autor 2";
            return autor1;
        }
    }
}
