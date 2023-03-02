using System;

namespace ExamenVectores
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int[] salarios;
            int linea;
            bool varios = false;

            Console.WriteLine("Ingrese el numero de personas a las que se les va a preguntar el salario: ");

            linea = Convert.ToInt32(Console.ReadLine());
            salarios = new int[linea];
            string[] personas = new string[linea];

            for (int i = 0; i < salarios.Length; i++)
            {
                Console.WriteLine($"Ingrese el salario de la {i + 1} persona");
                int salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese el nombre de la {i + 1} persona");
                string nombre = Console.ReadLine();

                personas[i] = nombre;
                salarios[i] = salario;
            }


            int locSalario = 0;
            string locNombre = "";
            string mayoresSalarios = "";
            string mNombres = "";

            for (int i = 0; i < salarios.Length; i++)
            {
                Console.WriteLine( $"{personas[i]} tienen un salario de {salarios[i]}");
                if (salarios[i] > locSalario)
                {
                    locSalario = salarios[i];
                    locNombre = personas[i];
                }
                if (salarios[i] == locSalario)
                {
                    varios = true;

                    mNombres += personas[i] + " y";
                    mayoresSalarios += Convert.ToString(locSalario + ", ");
                }

            }
            if (varios == true)
            {
                Console.WriteLine($"El salario de {mayoresSalarios} Corresponden a  {mNombres}");
            }
            else 
            {
                Console.WriteLine($"El salario de {locSalario} Corresponde a  {locNombre}");
            }
        }
    }
}
