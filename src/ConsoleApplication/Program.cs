//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("a");
            train.StartEngines();
            for (int i=1; i<100000; i++)
            {
                train = new Train($"{i}");
            }
            Console.WriteLine($"{train.Count}");
            //Observo que luego de determinado número de trenes creados, el método destructor toma acción y comienza a eliminar instancias creadas anteriormente, esto con el fin de generar espacio en memoria para nuevas instancias.
            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);
            //Lo que ocurre es que t1, t2 y t3 son variables diferentes que ocupan diferentes espacios de memoria, indiferentemente de su identificador y por ello las comparaciones t1 == t2 y t2 == t3 dan False como resultado.
        }
    }
}