using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
         -Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
         -Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
         -Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
         - Si el IMC es mayor de 29.9 entonces tiene obesidad.
         Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular */

        //Declaracion de variables.
        int pacientes;
        double peso, altura, imc;
        string categoria;

        //Numero de pacientes
        Console.WriteLine("Ingrese numero de Pacientes: ");
        pacientes = int.Parse(Console.ReadLine());

        //Solicitar datos y categorizar pacientes
        for (int i = 1; i <= pacientes; i++)
        {
            //Solicitar peso y altura
            Console.WriteLine("Paciente {0}:", i);
            Console.WriteLine("Ingrese el peso en kilogramos del paciente: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura en metros del paciente: ");
            altura = double.Parse(Console.ReadLine());

            //Caluclar el IMC
            imc = peso / (altura * altura);

            //Clasificación
            if (imc < 18.5)
            {
                categoria = "Desnutrido";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                categoria = "Peso saludable";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            // Categoria del Paciente
            Console.WriteLine("El IMC del paciente {0} es {1} y su categoría es {2}", i, imc, categoria);
        }
    }
}
