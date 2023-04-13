using System;
using System.IO;

namespace Infracciones_Transito
{
    public class Program
    {
        static public void Main(String[] args)
        {
            Executers.BasedeDatosCiudadanos();
            Executers.BasedeDatosVehiculos();
            for (int i = 0; i < 1;)
            {
                Console.Clear();
                Executers.Menu();
                int Eleccion = Convert.ToInt32(Console.ReadLine());
                if (Eleccion == 1)
                { Executers.Multas(); Executers.Separador(); Thread.Sleep(6000); }

                else if (Eleccion == 2)
                { foreach (string x in Datos_Conductor.Ciudadanos) { Console.WriteLine(x); }; Thread.Sleep(4000); }

                else if (Eleccion == 3) { Console.WriteLine(Datos_Amet.Amet1[0]); Thread.Sleep(4000); }

                else if (Eleccion == 4) { foreach (string x in Datos_Infracciones.Registro) { Console.WriteLine(x);} Thread.Sleep(3000); }

                else if (Eleccion == 5) { Console.WriteLine("Saliste"); break; }

                else { Console.WriteLine("No eligio ninguna de las elecciones"); Thread.Sleep(3000); }
            }
        }

    }

}