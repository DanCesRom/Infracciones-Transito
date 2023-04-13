namespace Infracciones_Transito
{
    public class Datos_Conductor
    {
        public static string[] Informacion = { "Nombre", "Cedula", "Direccion", "Tipo de Licencia", "Fecha de Nacimiento" };
        public static List<string> Ciudadanos = new List<string>();
        public static int id = 0;

    }

    public class Datos_Vehiculos
    {

        public static string[] Informacion = {"Numero de Placa","Marca","Modelo","Color", "Año", "Numero de Chasis (VIN)" };
        public static List<string> Vehiculos = new List<string>();

    }

    public class Datos_Amet
    {

        public static string[] Amet1 = {"Numero de Empleado: F-3849 Nombre: Ramon Jimenez Tolledo Dirreccion: Cristo Rey Fecha de Ingreso: 03/07/2023"};

    }


    public class Datos_Infracciones
    {
        public static string[] Multa = {"Obstruccion de transito", "Pase de Semaforo en Rojo", "Hablar por el Celular", "Conducir sin cinturon", "Licencia Vencida"  };
        public static int[] Penalidad = { 1800, 5950, 3750, 2560, 3890 };
        public static int Precio;
        public static List<string> Registro = new List<string>();

    }

    public class Datos_Menu
    {
        public static string[] Menu = { "1) Poner Multa al Conductor", "2) Ver Datos de Ciudadanos", "3) Ver Datos de Amet", "4) Ver Multas puestas" , "5) Salir"};

    }


}