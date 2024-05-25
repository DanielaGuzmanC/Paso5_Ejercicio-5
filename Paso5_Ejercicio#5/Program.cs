//Nombre del estudiante:Daniela Guzman
//Grupo: 213022_386
//Programa Académico:Fundamnetos de programacion_Ingeneria en sistemas
//Problema Seleccionado:5_Una central de distribución de químicos distribuye Alcohol hacia diferentes almacenes sucursales. Disponen de un muelle de carga a donde van llegando tanques de alcohol de entre 3000 y 9000 litros, con pesos variables en función de las circunstancias de la producción. La empresadispone de una flota de camiones con capacidades de carga de entre 18000 y 28000 litros.
//Se pretende establecer un protocolo consistente en cargar 20 camiones diarios. Cada camión se quiere cargar como máximo a su límite de capacidad debiendo partir si con la siguiente saca en la línea de producción se fuera a exceder su capacidad.
//La empresa quiere desarrollar una solución básica de programación que le pida al operario encargado de carga la capacidad del camión y el peso de las sacas, indicándole si debe cargar los tanques de alcohol o despachar el camión para comenzar a cargar otro.
//Código Fuente:

using System;

class Program
{
    static void Main(string[] args)
    {
        int totalTrucks = 20;
        int trucksLoaded = 0;

        while (trucksLoaded < totalTrucks)
        {
            Console.WriteLine("Ingrese la capacidad del camión en litros:");
            int truckCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el peso de las sacas en litros:");
            int sacksWeight = Convert.ToInt32(Console.ReadLine());

            if (sacksWeight <= truckCapacity)
            {
                Console.WriteLine("Cargar los tanques de alcohol en el camión.");
                trucksLoaded++;
            }
            else
            {
                Console.WriteLine("Despachar el camión y comenzar a cargar otro.");
            }
        }

        Console.WriteLine("Se han cargado todos los camiones.");
    }
}
