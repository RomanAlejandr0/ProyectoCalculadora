
using System;
using System.IO;

namespace Primer_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2 = 0;
            float resultado;
            int elegir;
            string decidir_continuar;
            bool repetir=true;
          
            Console.WriteLine("CALCULADORA ONLINE\n"); //titulo 
            do
            {
                Console.WriteLine("Si quieres una suma pulsa 1\nSi quieres una resta pulsa 2\n" +
                                  "Si quieres una multiplicacion pulsa 3\nSi quieres una division pulsa 4");
                elegir = Convert.ToInt32(Console.ReadLine());
                switch (elegir)
                {
                    case 1:                
                        Console.WriteLine("Escribe dos numeros:");
                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"La multiplicacion es igual a:{resultado}");

                        Console.WriteLine("Quieres repetir otra operacion (si o no):");
                        decidir_continuar = Console.ReadLine();
                        if (decidir_continuar == "SI" || decidir_continuar == "Si" || decidir_continuar == "si")
                        {
                            repetir = true;
                        }
                        else if (decidir_continuar == "NO" || decidir_continuar == "No" || decidir_continuar == "no")
                        {
                            repetir = false;
                        }
                            break;

                    case 2:
                        Console.WriteLine("Escribe dos numeros:");
                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"La multiplicacion es igual a:{resultado}");

                        Console.WriteLine("Quieres repetir otra operacion (si o no):");
                        decidir_continuar = Console.ReadLine();
                        if (decidir_continuar == "SI" || decidir_continuar == "Si" || decidir_continuar == "si")
                        {
                            repetir = true;
                        }
                        else if (decidir_continuar == "NO" || decidir_continuar == "No" || decidir_continuar == "no")
                        {
                            repetir = false;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Escribe dos numeros:");
                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"La multiplicacion es igual a:{resultado}");

                        Console.WriteLine("Quieres repetir otra operacion (si o no):");
                        decidir_continuar = Console.ReadLine();
                        if (decidir_continuar == "SI" || decidir_continuar == "Si" || decidir_continuar == "si")
                        {
                            repetir = true;
                        }
                        else if (decidir_continuar == "NO" || decidir_continuar == "No" || decidir_continuar == "no")
                        {
                            repetir = false;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Escribe dos numeros:");
                        num1 = float.Parse(Console.ReadLine());
                 
                        while (num2 == 0)
                        {
                            Console.WriteLine("ingresa tu segundo numero");
                            num2 = float.Parse(Console.ReadLine());
                            if (num2 == 0)
                            {
                                Console.WriteLine("no esta permitido usar 0 como segundo numero");
                            }
                        }
                        resultado = num1 / num2;
                        Console.WriteLine($"La division es igual a:{resultado}");

                        Console.WriteLine("Quieres repetir otra operacion (si o no):");
                        decidir_continuar = Console.ReadLine();
                        if (decidir_continuar == "SI" || decidir_continuar == "Si" || decidir_continuar == "si")
                        {
                            repetir = true;
                        }
                        else if (decidir_continuar == "NO" || decidir_continuar == "No" || decidir_continuar == "no")
                        {
                            repetir = false;
                        }
                        break;
                }
            } 
            while (repetir == true);

        }
    }
}
