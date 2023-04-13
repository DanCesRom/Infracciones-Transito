namespace Infracciones_Transito
{
    public class Executers
    {
        public static void Multas()
        {
            Console.Clear();
            Console.WriteLine("Que tipo de Multa le pondra al conductor?\n");
            Console.WriteLine("Los tipos de Infracciones son:\n");
            for (int x = 0; x < 5; x++)
            {
                string Penalizacion_comas = string.Format("{0:n0}", Datos_Infracciones.Penalidad[x]);
                Console.WriteLine($"{x+1}) Multa por {Datos_Infracciones.Multa[x]} de {Penalizacion_comas} pesos.");
            }
            Datos_Infracciones.Precio = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();
        }

        public static void Menu()
        {
            Console.WriteLine("Que Opcion quieres elegir? \n");
            foreach (string x in Datos_Menu.Menu) { Console.WriteLine(x); }
        }


        public static void BasedeDatosCiudadanos()
        {
            try
            {
                string nombreArchivo = "Ciudadanos.txt"; // Nombre del archivo en la misma carpeta que el programa

                // Obtener la ruta del directorio de trabajo actual
                string directorioActual = Directory.GetCurrentDirectory();

                // Combinar la ruta del directorio de trabajo actual con el nombre del archivo
                string rutaArchivo = Path.Combine(directorioActual, nombreArchivo);

                // Leer todas las líneas del archivo de texto
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Agregar las líneas en la lista de Ciudadanos
                foreach (string linea in lineas)
                {
                    Datos_Conductor.Ciudadanos.Add(linea);
                }
            }
            catch (Exception ex){Console.WriteLine("Ocurrió un error: " + ex.Message);}
        }

        public static void BasedeDatosVehiculos()
        {
            try
            {
                string nombreArchivo = "Vehiculos.txt"; // Nombre del archivo en la misma carpeta que el programa

                // Obtener la ruta del directorio de trabajo actual
                string directorioActual = Directory.GetCurrentDirectory();

                // Combinar la ruta del directorio de trabajo actual con el nombre del archivo
                string rutaArchivo = Path.Combine(directorioActual, nombreArchivo);

                // Leer todas las líneas del archivo de texto
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Agregar las líneas en la lista de Vehiculos
                foreach (string linea in lineas)
                {
                    Datos_Vehiculos.Vehiculos.Add(linea);
                }
            }
            catch (Exception ex) { Console.WriteLine("Ocurrió un error: " + ex.Message); }
        }

        public static void Separador()
        {
            Console.WriteLine(Datos_Conductor.Ciudadanos[0]);
            Console.WriteLine(Datos_Conductor.Ciudadanos[1]);
            Console.WriteLine("Proporciona el numero de la Cedula del Conductor\n");
            string confirmacion = Convert.ToString(Console.ReadLine());
            foreach (string x in Datos_Conductor.Ciudadanos)
            {
                string[] partes = x.Split(":");
                var divpartes = partes.ToList();
                (string a, string b, string c, string d, string e) = (divpartes[0], divpartes[1], divpartes[2], divpartes[3], divpartes[4]);
                
                if (a == confirmacion)
                { 
                    string y = ($"Cedula {a} de {b} por {Datos_Infracciones.Multa[Datos_Infracciones.Precio]} de {Datos_Infracciones.Penalidad[Datos_Infracciones.Precio]} pesos.");
                    Console.WriteLine($"La cedula {a} existe, sus datos son:\n"); 
                    Console.WriteLine(x + "\n"); Console.WriteLine(Datos_Vehiculos.Vehiculos[Datos_Conductor.id]);
                    Console.WriteLine($"La Multa se le agrego a la {y}");
                    Datos_Infracciones.Registro.Add(y);
                    return; 
                }
                Datos_Conductor.id += 1;
            }
        }
    }

}


