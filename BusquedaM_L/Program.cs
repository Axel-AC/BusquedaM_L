using System;
using System.Linq;

namespace BusquedaM_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se mostrara opciones en el cual se podra iniciar secion o crear cuenta");
            Console.WriteLine("Si deseas iniciar sesion escribe 'Ins', si deseas crear una cuenta escribe 'Cc'");
            Console.WriteLine("");

            List<string> Cr = new List<string>();
            List<string> Pss = new List<string>();

            while (true)
            {
                string Ce;
                string Ps;
                string d = Console.ReadLine();

                if (d == "Cc")
                {
                    while (true)
                    {
                        while (true)
                        {
                            Console.WriteLine("Crea un correo electronico.");
                            Ce = Console.ReadLine();
                            Cr.Add(Ce);

                            Console.WriteLine("Crea una contrasena");
                            Console.WriteLine("*Minimo de 6 caracteres");
                            Console.WriteLine("*Que tenga minimo una mayuscula");
                            Console.WriteLine("*Que contenga minimo un numero");

                            Ps = MAin();
                            Console.WriteLine("");

                            if (Ps.Length >= 6 && Ps.Any(char.IsUpper))
                            {
                                Pss.Add(Ps);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error lea bien las instrucciones");
                                Console.WriteLine("");
                            }
                        }

                        Console.WriteLine("Ingresa nuevamnete Correo y Constrasena");
                      
                        string[] array = Cr.ToArray();
                        string[] array2 = Pss.ToArray();

                        Ce = Console.ReadLine();
                        Ps = MAin();

                        if (Array.Exists(array, valor => valor == Ce) && Array.Exists(array2, valor => valor == Ps))
                        {
                            Console.WriteLine($"Correo correcto: {Ce}");
                            Console.WriteLine($"Contrasena correcta");
                            Console.WriteLine("");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Correo o contrasena incorrectos.");
                            Console.WriteLine("Corrigir y leer de nuevo las indicaciones.");
                            Console.WriteLine("");
                        }
                    }
   
                }
                else
                {
                    string[] array = Cr.ToArray();
                    string[] array2 = Pss.ToArray();

                    Console.WriteLine("Ingresa tu correo electronico");
                    Ce = Console.ReadLine();

                    Console.WriteLine("Ingresa tu contrasena") ;
                    var PS = Console.ReadLine();

                    if (Array.Exists(array, valor => valor == Ce) && Array.Exists(array2, valor => valor == PS))
                    {
                        Console.WriteLine("Correo y contrasena correctos");
                    }
                    else
                    {
                        Console.WriteLine("Correo o contrasena incorrectos");
                    }
                }

                Console.WriteLine("Si deseas finalizar con el programa ingresa la tecla 'esc'");
                var y = Console.ReadKey(true);
                if (y.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Programa cerrado...");
                    break;
                }
            }
        }
        static string MAin()
        {
          var Ps1 = Console.ReadLine();
            return Ps1;
        }
    }
}