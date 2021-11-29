using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC5
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void InOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                InOrder(raiz.izquierdo);
                Console.WriteLine("ID: " + raiz.dato.id + " Paciente: " + raiz.dato.nombre + " " + raiz.dato.apellido);
                InOrder(raiz.derecho);
            }
        }

        public void PreOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("ID: " + raiz.dato.id + " Paciente: " + raiz.dato.nombre + " " + raiz.dato.apellido);
                PreOrder(raiz.izquierdo);
                PreOrder(raiz.derecho);
            }
        }

        public void PostOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                PostOrder(raiz.izquierdo);
                PostOrder(raiz.derecho);
                Console.WriteLine("ID: " + raiz.dato.id + " Paciente: " + raiz.dato.nombre + " " + raiz.dato.apellido);
            }
        }

        public void InsertarNodo(Paciente dato)
        {
            Nodo puntero, padre;
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = dato;
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (dato.id < puntero.dato.id)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nuevoNodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nuevoNodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nuevoNodo;
            }
        }

        public Nodo Eliminar(Nodo puntero, int id)
        {
            if (puntero == null) return puntero;
            if (id < puntero.dato.id) puntero.izquierdo = Eliminar(puntero.izquierdo, id);
            if (id > puntero.dato.id) puntero.derecho = Eliminar(puntero.derecho, id);
            if (id == puntero.dato.id)
            {
                if (puntero.izquierdo == null && puntero.derecho == null)
                {
                    puntero = null;
                    return puntero;
                }
                else if (puntero.izquierdo == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.derecho;
                    temp = null;
                }
                else if (puntero.derecho == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.izquierdo;
                    temp = null;
                }
            }
            return puntero;
        }
    }
}
