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

            //context.Autores.AddOrUpdate(x => x.LintId, crearAutor(context));
            //context.Reconstrucciones.AddOrUpdate(x => x.LintId, crearReconstruccion(context));
            //context.Escenarios.AddOrUpdate(x => x.LintId, crearEscenario(context));
            //context.Victimas.AddOrUpdate(x => x.LintId, crearVictima(context));
        }

        public Victima crearVictima(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            Indicio indicio1 = new Indicio();
            indicio1.LstrDescripcion = "Indicio 1";            
            List<Indicio> indicios = new List<Indicio>();
            indicios.Add(indicio1);

            MadreVictima madreVictima = new MadreVictima();
            madreVictima.LstrNombre = "Madre 1";
            madreVictima.LstrTelefono = "Telelefono madre 1";

            PadreVictima padreVictima = new PadreVictima();
            padreVictima.LstrNombre = "Padre 1";
            padreVictima.LstrTelefono = "Telefono padre 1";

            MatrimonioVictima matrimonioVictima = new MatrimonioVictima();
            matrimonioVictima.LstrNombre = "Matrimonio nombre";
            matrimonioVictima.LstrCedula = "Matrimonio Cedula";
            matrimonioVictima.LstrNacionalidad = "Matrimonio Nacionalidad";
            matrimonioVictima.LstrFecha = new DateTime(2005, 04, 10, 16, 25, 00);

            ParejaSentimentalVictima parejaSentimentalVictima = new ParejaSentimentalVictima();
            parejaSentimentalVictima.LstrNombre = "Pareja sentimental nombre";
            parejaSentimentalVictima.LstrCedula = "Pareja sentimental cedula";
            parejaSentimentalVictima.LstrAlias = "Pareja sentimental alias";
            parejaSentimentalVictima.LstrTelefono = "Pareja sentimental telefono";



            HermanoVictima hermanoVictima1 = new HermanoVictima();
            hermanoVictima1.LstrNombre = "Hermano 1";
            hermanoVictima1.LstrTelefono = "telefono hermano 1";

            HermanoVictima hermanoVictima2 = new HermanoVictima();
            hermanoVictima2.LstrNombre = "Hermano 2";
            hermanoVictima2.LstrTelefono = "telefono hermano 2";

            List<HermanoVictima> hermanos = new List<HermanoVictima>();
            hermanos.Add(hermanoVictima1);
            hermanos.Add(hermanoVictima2);



            HijoVictima hijo1 = new HijoVictima();
            hijo1.LstrNombre = "hijo 1 nombre";
            hijo1.LstrCedula = "hijo 1 cedula";
            hijo1.LstrNacionalidad = "hijo 1 nacionalidad";
            hijo1.LintEdad = 23;
            hijo1.LstrTelefono = "hijo 1 telefono";

            HijoVictima hijo2 = new HijoVictima();
            hijo2.LstrNombre = "hijo 2 nombre";
            hijo2.LstrCedula = "hijo 2 cedula";
            hijo2.LstrNacionalidad = "hijo 2 nacionalidad";
            hijo2.LintEdad = 31;
            hijo2.LstrTelefono = "hijo 2 telefono";

            List<HijoVictima> hijos = new List<HijoVictima>();
            hijos.Add(hijo1);
            hijos.Add(hijo2);



            EntrevistaVictima entrevista1 = new EntrevistaVictima();
            entrevista1.LstrNombre = "entrevista 1 nombre";
            entrevista1.LstrDescripcion = "entrevista 1 descripcion";

            EntrevistaVictima entrevista2 = new EntrevistaVictima();
            entrevista2.LstrNombre = "entrevista 2 nombre";
            entrevista2.LstrDescripcion = "entrevista 2 descripcion";

            List<EntrevistaVictima> entrevistas = new List<EntrevistaVictima>();
            entrevistas.Add(entrevista1);
            entrevistas.Add(entrevista2);


            return new Victima()
            {
                LstrFotoURL = "http://www.noverbal.es/uploads/blog/criminal.jpg",
                LstrNombre = "Victima 1",
                LstrCausa = "Causa 1",
                LstrAlias = "Alias 1",
                LstrSexo = "Femenino",
                LstrCedula = "11111111",
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
                LstrInformacionResenia = "",
                LstrAutopsia = "Antropofagia",
                LstrDictamenToxicologico = "Positivo en cocaina",
                LstrLaboratorio = "Ropas elementos botanicos",
                LstrFluidosBiologicos = "",
                LstrManeraMuerte = "Indeterminada",
                LstrCausaMuerte = "N/A",
                LstrLesionesEncontradasAutopsia = "n/a",
                LstrToxicologia = "n/a",
                LdtiFechaNacimiento = new DateTime(1980, 04, 10, 16, 25, 00),
                LintEdad = 38,
                LdblPeso = 70.2,
                LdblEstatura = 1.80,
                LmvMadreVictima = madreVictima,
                LpvPadreVictima = padreVictima,
                LmvMatrimonioVictima = matrimonioVictima,
                LpsvParejaSentimentalVictima = parejaSentimentalVictima,
                LcolHermanos = hermanos,
                LcolHijos = hijos,
                LcolEntrevistas = entrevistas
            };
        }

        public Escenario crearEscenario(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            Indicio indicio1 = new Indicio();
            indicio1.LstrDescripcion = "Indicio 1";
            Indicio indicio2 = new Indicio();
            indicio2.LstrDescripcion = "Indicio 2";

            List<Indicio> indicios = new List<Indicio>();
            indicios.Add(indicio1);
            indicios.Add(indicio2);

            EntrevistaEscenario entrevista1 = new EntrevistaEscenario();
            entrevista1.LstrNombre = "Nombre 1";
            entrevista1.LstrDescripcion = "No sabe que sucedio 1";
            EntrevistaEscenario entrevista2 = new EntrevistaEscenario();
            entrevista2.LstrNombre = "Nombre 2";
            entrevista2.LstrDescripcion = "No sabe que sucedio 2";

            List<EntrevistaEscenario> entrevistas = new List<EntrevistaEscenario>();
            entrevistas.Add(entrevista1);
            entrevistas.Add(entrevista2);


            return new Escenario() {
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
            DetalleReconstruccion detalleReconstruccion1 = new DetalleReconstruccion();
            detalleReconstruccion1.LstrDetalle = "Detalle Reconstruccion 1";
            DetalleReconstruccion detalleReconstruccion2 = new DetalleReconstruccion();
            detalleReconstruccion2.LstrDetalle = "Detalle Reconstruccion 2";

            List<DetalleReconstruccion> detallesReconstruccion = new List<DetalleReconstruccion>();
            detallesReconstruccion.Add(detalleReconstruccion1);
            detallesReconstruccion.Add(detalleReconstruccion2);

            return new Reconstruccion() { LcolDetallesReconstruccion = detallesReconstruccion };
        }

        public Autor crearAutor(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            DetalleAutor detalleAutor1 = new DetalleAutor();
            detalleAutor1.LstrDetalle = "Detalle autor 1";
            DetalleAutor detalleAutor2 = new DetalleAutor();
            detalleAutor2.LstrDetalle = "Detalle autor 2";

            List<DetalleAutor> detallesAutor = new List<DetalleAutor>();
            detallesAutor.Add(detalleAutor1);
            detallesAutor.Add(detalleAutor2);

            return new Autor() { LcolDetallesAutor = detallesAutor };
        }
    }
}
