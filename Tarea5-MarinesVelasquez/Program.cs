using System;

namespace Tarea5_MarinesVelasquez
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Tarea 1: Crea una función llamada "Signo", que reciba un número real, y devuelva un número entero 
            con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.
           signo(2);*/

           Console.WriteLine("TAREA 1");
           Console.WriteLine("Ingrese un numero");
           int numero = Int32.Parse(Console.ReadLine());
           Console.WriteLine(Signo(numero));
           
           
           static int Signo(int numero)
           {
               if (numero>=0)
               {
                   return 1;
               }
               else
               {
                   return -1;
               }
               
            }
            Console.ReadKey();

           /*Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como parámetros. 
           El resultado será otro número entero (retorne).*/

           Console.WriteLine("TAREA 2");
           Console.WriteLine("Ingrese el 1er numero");
           int num1 = Int32.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese el 2do numero");
           int num2 = Int32.Parse(Console.ReadLine());
           Console.WriteLine(Menor(num1, num2));

           static int Menor(int num1, int num2) //Recibe 2 parametros
           {
               if (num1<num2) //Ve cual cual es el mayor
               {
                   return num2; //Retorna el otro numero
               }
               else
               {
                   return num1;
               }
           }
           Console.ReadKey();


           /*Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano "true" si es un
            número primo o "false" en caso contrario.*/

           Console.WriteLine("TAREA 3");
           Console.WriteLine("Ingrese un numero");
           int nume = Int32.Parse(Console.ReadLine());
           Console.WriteLine(EsPrimo(nume));
           
           static bool EsPrimo(int nume)
           {
               if (nume < 0)
               Console.WriteLine("El valor debe ser positivo");
               if (nume <= 3) 
                    return true;
                else
                    for (int iterar = 2; iterar <= nume - 1; iterar++)
                if (nume % iterar == 0) return false;
                return true;
           }
           Console.ReadKey();
           
            /*Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del código con su resultado
            y análisis del mismo.*/

            Console.WriteLine("TAREA 4");
            Console.Clear(); //limpia la consola para solo dejar esta tarea

                for (int fila =1; fila <=7; fila ++) //empieza en 1 y hasta que no llegue a 7 le va sumando 1
                {
                    for (int espacios = 7 - fila; espacios > 0; espacios--) // espacios es igual a 7 - el valor de fija, y mientras espacio sea mayor a cero. espacios se reduce (decremento)
                        Console.Write(" ");

                    for (int conta = 1; conta < (2 * fila); conta++) // conta vale 1 y si es menor a 2 por fila, se le suma a conta1
                        Console.Write("*");
                    Console.WriteLine(" ");

                }
                Console.ReadKey();

            /*Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar o dividir 
            los dos números que se le indiquen como parámetros. Ejemplos de su uso sería "calcula 2 + 3" o "calcula 
            5 * 60". (Utilice Funciones)*/

            Console.WriteLine("TAREA 5");
            Console.WriteLine("Ingrese el primer numero");
            float opera1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");            
            float opera2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Que operacion desea realizar? [sumar/ restar/ multiplicar /dividir]");
            string operacion = Console.ReadLine();

            calcula( opera1, opera2);

            void calcula(float opera1, float opera2)
            {
                if (operacion =="sumar")
                    Console.WriteLine($"El resultado de la suma es {opera1 +opera2}");
                if (operacion =="restar")
                    Console.WriteLine($"El resultado de la resta es {opera1 -opera2}");
                if (operacion =="multiplicar")
                    Console.WriteLine($"El resultado de multiplicar es {opera1 *opera2}");
                if (operacion =="dividir")
                    Console.WriteLine($"El resultado de dividir es {opera1 /opera2}");
            }
            Console.ReadKey();
            
            /*Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como resultado la 
            suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.   */
            
            Console.WriteLine("TAREA 6");
            Console.WriteLine("Ingrese un numero");
            int cifra = Int32.Parse(Console.ReadLine());

            Console.WriteLine(SumaCifras(cifra));

            static int SumaCifras(int cifra)
           
            {
                int suma= 0;
                while (cifra !=0)
                {
                    int resul = cifra % 10;
                    suma = suma + resul;                 
                    cifra = cifra / 10;                   
                }
                return suma;
            }
            Console.ReadKey();
   
            /*Tarea 7 (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y escriba un "triángulo"
            formado por esa letra, que tenga como anchura inicial la que se ha indicado. Por ejemplo, si la letra es * y
            la anchura es 4, debería escribir 
            **** 
            *** 
            ** 
            *    */
            Console.WriteLine("TAREA 7");            
            Console.WriteLine("Ingrese un numero");
            int Numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una letra");
            string letra = Console.ReadLine();
            triangulo(Numero, letra);

            static void triangulo(int Numero, string letra)
            {
            for (int fila =1; fila <=Numero; fila ++) 
                {
                    for (int conta = 1; conta < (2 * fila); conta++) // conta vale 1 y si es menor a 2 por fila, se le suma a conta1
                        Console.Write(letra);                    
                    for (int espacios = Numero - fila; espacios < 0; espacios--) // espacios es igual a 7 - el valor de fija, y mientras espacio sea mayor a cero. espacios se reduce (decremento)
                        Console.Write(" ");
                    Console.WriteLine(" "); 
                }
            }
            Console.ReadKey(); 
        }
    
    }
}
