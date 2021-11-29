using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            Paciente p1 = new Paciente(5, "Victor", " Alarcon");
            Paciente p2 = new Paciente(2, "Manuel", " Arroyo");
            Paciente p3 = new Paciente(10, "Miriam", " Castellanos");
            Paciente p4 = new Paciente(100, "Pamela", " Curasma");
            Paciente p5 = new Paciente(1, "Dania", " Cubas");
            Paciente p6 = new Paciente(3, "Diego", " Machuca");

            arbol.InsertarNodo(p1);
            arbol.InsertarNodo(p2);
            arbol.InsertarNodo(p3);
            arbol.InsertarNodo(p4);
            arbol.InsertarNodo(p5);
            arbol.InsertarNodo(p6);

            Console.WriteLine("********** ORDENAMIENTO PREORDER **********");
            arbol.PreOrder(arbol.GetRaiz());
            Console.WriteLine("********** ORDENAMIENTO INORDER **********");
            arbol.InOrder(arbol.GetRaiz());
            Console.WriteLine("********** ORDENAMIENTO POSTORDER **********");
            arbol.PostOrder(arbol.GetRaiz());
            Console.WriteLine("\n");

            Console.WriteLine("ELIMINANDO ELEMENTOS ID: " + p4.id + " , ID: " + p5.id + "\n");
            arbol.Eliminar(arbol.GetRaiz(), p4.id);
            arbol.Eliminar(arbol.GetRaiz(), p5.id);

            Console.WriteLine("********** ORDENAMIENTO PREORDER **********");
            arbol.PreOrder(arbol.GetRaiz());
            Console.WriteLine("********** ORDENAMIENTO INORDER **********");
            arbol.InOrder(arbol.GetRaiz());
            Console.WriteLine("********** ORDENAMIENTO POSTORDER **********");
            arbol.PostOrder(arbol.GetRaiz());

            Console.ReadKey();
        }
    }
}
