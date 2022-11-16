using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_FP_Switch1_HectorM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, carrera, categoria;
            double pagoTotal = 90;
            byte horasTrabajadas;
            //----
            Console.WriteLine("Ingresa el nombre del profesor");
            nombre = Console.ReadLine();
            //----
            Console.WriteLine("Ingresa la carrera a la que perteneces \t\n ISIC \t IGE \t INLG \t IID");
            carrera = Console.ReadLine();
            //----
            Console.WriteLine("Selecciona la categoria del maestro");
            categoria = Console.ReadLine();
            //----
            Console.WriteLine("Ingresa las horas trabajadas del maestro");
            horasTrabajadas = Convert.ToByte(Console.ReadLine());

            //Switch

            //If para el requerimiento R3 
            if (horasTrabajadas < 3 || horasTrabajadas > 40)
            {
                Console.WriteLine("Incumplimiento de horas, vuelve a realizar el proceso");
                Thread.Sleep(5000);
                return;
            }
            //SWITCH
            switch (categoria)
            {
                case "A":
                    pagoTotal = (pagoTotal * horasTrabajadas) * 1.0048;
                    Console.WriteLine("El maestro de nombre: {0}, con categoria {1}, y un total " +
                        "de {2} horas a la semana, tendra una renumeracion de $ {3}" +
                        "quincenal.", nombre, categoria, horasTrabajadas, pagoTotal * 2);
                    break;
                case "B":
                    //Requerimiento R1
                    if (horasTrabajadas < 13)
                    {
                        Console.WriteLine("Incumplimiento de horas, la categoria B debe de tener mas horas asignadas. Vuelve a realizar el proceso");
                        Thread.Sleep(7000);
                        return;
                    }
                    else
                    {
                        pagoTotal = (pagoTotal * horasTrabajadas) * 1.0063;
                        Console.WriteLine("El maestro de nombre: {0}, con categoria {1}, y un total " +
                            "de {2} horas a la semana, tendra una renumeracion de $ {3}" +
                            "quincenal.", nombre, categoria, horasTrabajadas, pagoTotal * 2);
                    }
                    break;
                case "C":
                    //Requerimiento r2
                    if (horasTrabajadas > 35) 
                    {
                        Console.WriteLine("Incumplimiento de horas, la categoria C debe de tener mas horas asignadas. Vuelve a realizar el proceso");
                        Thread.Sleep(7000);
                        return;
                    }
                    else
                    {
                        //Validar R4 de la anmtiguedad del maestro
                        byte antiguedad;
                        double bono;
                        Console.WriteLine("Ingresa los años de antiguedad del maestro");
                        antiguedad = Convert.ToByte(Console.ReadLine());
                        if(antiguedad >= 5)
                        {
                            bono = (antiguedad * 700) / 52;
                            Console.WriteLine(bono);
                        }
                        pagoTotal = (pagoTotal * horasTrabajadas) * 1.0098;
                        Console.WriteLine("El maestro de nombre: {0}, con categoria {1}, y un total " +
                            "de {2} horas a la semana, tendra una renumeracion de $ {3}" +
                            "quincenal. ", nombre, categoria, horasTrabajadas, pagoTotal * 2);
                    }
                    
                    break;
                default:
                    break;
            }

            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(2000);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(2000);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(2000);
        }
    }
}
