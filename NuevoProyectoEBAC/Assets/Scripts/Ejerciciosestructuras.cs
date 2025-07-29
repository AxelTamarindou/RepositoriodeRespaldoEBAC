using JetBrains.Annotations;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEditor.PackageManager;
using UnityEngine;


public class Ejerciciosestructuras : MonoBehaviour
{
    HashSet<string> HashsetColores = new HashSet<string>();
    HashSet<int> HashsetNúmeros = new HashSet<int>();
    Queue<string> ColoresOrden = new Queue<string>();
    Stack<string> StackColores = new Stack<string>();
    public List<int> listaNumeros = new List<int>();
    



    int tamaño = 15;
    int RangoSuperior = 100;
    int RangoInferior = 0;
    public int[] MiArregloUniDimensional = new int[3];

    void Start()
    {
       
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
            listaNumeros.Add(Random.Range(RangoInferior, RangoSuperior));
        }

        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }

        Debug.Log("Lista de 100 números aleatorios ordenados");

        var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();

        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
    }

    public void LanzamientoDado()
    {
        for (int i = 0; i < 10; i++)
        {
            listaNumeros.Add(Random.Range(1, 7));
        }
        Debug.Log("En 10 lanzamientos de un dado, los resultados fueron: ");
        foreach (int numero in listaNumeros)
        {
            Debug.Log(numero);
            HashsetNúmeros.Add(numero);
        }
        Debug.Log("Los números que aparecen repetidos son:");
        foreach (int numero in HashsetNúmeros)
        {
            Debug.Log(numero);
        }

    }

    public void Colores()
    {
        StackColores.Push("Rojo");
        StackColores.Push("Verde");
        StackColores.Push("Azul");
        StackColores.Push("Cian");
        StackColores.Push("Morado");
        StackColores.Push("Amarillo");

        int NumColores = StackColores.Count;

        for (int i = 0; i < NumColores; i++)
        {
            Debug.Log(StackColores.Peek());
            ColoresOrden.Enqueue(StackColores.Peek());
            StackColores.Pop();
        }

        int NumOrden = ColoresOrden.Count;

        for (int i = 0; i < NumOrden; i++)
        {
            Debug.Log(ColoresOrden.Peek());
            ColoresOrden.Dequeue();
        }
    }
    void Update()
    {
        
    }
}
