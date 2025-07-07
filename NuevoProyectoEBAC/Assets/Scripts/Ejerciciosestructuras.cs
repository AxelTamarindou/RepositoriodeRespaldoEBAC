using JetBrains.Annotations;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;


public class Ejerciciosestructuras : MonoBehaviour
{
    HashSet<string> HashsetStrings = new HashSet<string>();
    Queue<string> Strings = new Queue<string>();
    Queue<string> StringsOrden = new Queue<string>();
    Stack<string> StackBaraja = new Stack<string>();
    public List<int> MiFuncion = new List<int>();
    int tamaño = 15;
    int RangoSuperior = 100;
    int RangoInferior = 0;
    public int[] MiArregloUniDimensional = new int[3];

    void Start()
    {
        //for (int i = 0; i < tamaño; i++)
        //{
        //    MiFuncion.Add(Random.Range(RangoInferior, RangoSuperior));
        //}

        //foreach (var numero in MiFuncion)
        //{
        //    Debug.Log(numero);
        //}

        //Debug.Log("Lista de 100 números aleatorios ordenados");

        //var listaOrdenada = MiFuncion.OrderBy(p => p).ToList();

        //foreach (var numero in listaOrdenada)
        //{
        //    Debug.Log(numero);
        //}


        //StackBaraja.Push("As");
        //StackBaraja.Push("5");
        //StackBaraja.Push("1");
        //StackBaraja.Push("4");
        //StackBaraja.Push("3");
        //Debug.Log(StackBaraja.Peek());
        //StackBaraja.Pop();
        //Debug.Log(StackBaraja.Peek());
        //StackBaraja.Pop();
        //Debug.Log(StackBaraja.Peek());
        //StackBaraja.Pop();
        //Debug.Log(StackBaraja.Peek());
        //StackBaraja.Pop();
        //Debug.Log(StackBaraja.Peek());
        //StackBaraja.Pop();
        //for (int i = 0; i < 20; i++)
        //{
        //    HashsetInts.Add(i);
        //}
        //foreach (int entero in HashsetInts)
        //{
        //    Debug.Log(entero);
        //}

    }
    public void Arreglo(int RangoInferior, int RangoSuperior)
    {
        for (int i = 0; i < MiArregloUniDimensional.Length; i++)
        {
            MiArregloUniDimensional[i] = Random.Range(RangoInferior, RangoSuperior);
        }

        var ArregloOrdenado = MiArregloUniDimensional.OrderByDescending(p => p).ToList();

        foreach (var numero in ArregloOrdenado)
        {
            Debug.Log(numero);
        }
    }
    public void Estructura1(int tamaño, int RangoInferior, int RangoSuperior)
    {
        for (int i = 0; i < tamaño; i++)
        {
            MiFuncion.Add(Random.Range(RangoInferior, RangoSuperior));
        }

        foreach (var numero in MiFuncion)
        {
            Debug.Log(numero);
        }

        Debug.Log("Lista de 100 números aleatorios ordenados");

        var listaOrdenada = MiFuncion.OrderBy(p => p).ToList();

        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
    }

    public void ProposicionesStrings()
    {
        Strings.Enqueue("Algunos perros son negros o Algunos perros son blancos");
        Debug.Log(HashsetStrings.Add(Strings.Peek()));
        Debug.Log(Strings.Peek());
        if (HashsetStrings.Contains("Algunos perros son"))
        {
            HashsetStrings.Remove("Algunos perros son");
        }
        else
        {
            Debug.Log("La proposición es verdadera, por lo que se realiza el acortamiento de la oración");
            Strings.Enqueue("Algunos perros son negros o blancos");
            Strings.Dequeue();
            Debug.Log(Strings.Peek());
        }
    }
    
    public void ListaBaraja()
    {
        StackBaraja.Push("Azul");
        StackBaraja.Push("Verde");
        StackBaraja.Push("Rojo");
        StackBaraja.Push("Amarillo");

        //foreach (string color in StackBaraja) 
        //{
        //    Debug.Log(color);
        //    StringsOrden.Enqueue(color);
        //}
        StringsOrden.Enqueue(StackBaraja.Peek());
        Debug.Log(StringsOrden.Peek());
        StackBaraja.Pop();
        StringsOrden.Dequeue();
        StringsOrden.Enqueue(StackBaraja.Peek());
        Debug.Log(StringsOrden.Peek());
        StackBaraja.Pop();
        StringsOrden.Dequeue();
        StringsOrden.Enqueue(StackBaraja.Peek());
        Debug.Log(StringsOrden.Peek());
        StackBaraja.Pop();
        StringsOrden.Dequeue();
        StringsOrden.Enqueue(StackBaraja.Peek());
        Debug.Log(StringsOrden.Peek());



        // Primero se forma en la cola, el primer elemento de la fila
        //StringsOrden.Enqueue(StackBaraja.Peek());
        //Debug.Log(StringsOrden.Peek());
        //// Sale el primer elemento de la fila, que se formó en la cola
        //StringsOrden.Dequeue();
        //StackBaraja.Pop();
        //// Pasa al siguiente elemento de la fila agregarse a la cola
        //StringsOrden.Enqueue(StackBaraja.Peek());
        //Debug.Log(StringsOrden.Peek());
    }
    void Update()
    {
        
    }
}
