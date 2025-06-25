using UnityEditor;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int limiteinferior = 0;
        int limitesuperior = 10;
        int valoraleatorio = Random.Range(limiteinferior, limitesuperior);
        int valoraleatorio2 = Random.Range(limiteinferior, limitesuperior);
        int valoraleatorio3 = Random.Range(limiteinferior, limitesuperior);
        Debug.Log("El primer valor aleatorio generado entre 0 y 10 es " + valoraleatorio);
        Debug.Log("El segundo valor aleatorio generado entre 0 y 10 es " + valoraleatorio2);
        Debug.Log("El tercer valor aleatorio generado entre 0 y 10 es " + valoraleatorio3);

        int limiteInferiorArreglo = 0;
        int limiteSuperiorArreglo = 3;
        int valoraleatorioArreglo = Random.Range(limiteInferiorArreglo, limiteSuperiorArreglo);
        int valoraleatorioArreglo2 = Random.Range(limiteInferiorArreglo, limiteSuperiorArreglo);
        Debug.Log("El primer valor aleatorio generado entre 0 y 3 es " + valoraleatorioArreglo);
        Debug.Log("El segundo valor aleatorio generado entre 0 y 3 es " + valoraleatorioArreglo2);
        

        int[] MiArregloUniDimensionalUno = new int[3] { valoraleatorio, valoraleatorio2, valoraleatorio3};
        int[] MiArregloUniDimensionalDos = new int[3] { valoraleatorio, valoraleatorio2, valoraleatorio3};
        int[] MiArregloUniDimensionalSuma = new int[1] { MiArregloUniDimensionalUno[valoraleatorioArreglo] + MiArregloUniDimensionalDos[valoraleatorioArreglo2] };


        for (int i = 0; i < MiArregloUniDimensionalUno.Length; i++)
        {
            Debug.Log(i);
            Debug.Log(MiArregloUniDimensionalUno[i]);

        }

        for (int entero = 0; entero < MiArregloUniDimensionalSuma[0]; entero++)
        {
            Debug.Log(entero);
        }
        Debug.Log(MiArregloUniDimensionalUno[valoraleatorioArreglo]);
        Debug.Log(MiArregloUniDimensionalDos[valoraleatorioArreglo2]);
        Debug.Log(MiArregloUniDimensionalSuma[0]);

        string[] Saludo = new string[] { "Hola ", "mundo ", "¿Cómo ", "están?" };
        string saludocompleto = "";
        for (int i = 0; i < Saludo.Length; i++)
        {
            saludocompleto += Saludo[i];
        }
        foreach (string saludo in Saludo)
        {

            saludocompleto += saludo;
        }

        Debug.Log(saludocompleto);

        int[,] ArregloBiDimensionalUno = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int x = 0; x < ArregloBiDimensionalUno.GetLength(0); x++)
        {
            Debug.Log("El valor x es " + x);

            for (int y = 0; y < ArregloBiDimensionalUno.GetLength(1); y++)
            {
                for (int z = 0; z < MiArregloUniDimensionalUno.Length; z++)
                {
                    Debug.Log("El valor z es " + z);
                    Debug.Log("El valor del arreglo UniDimensional según z es " + MiArregloUniDimensionalUno[z]);
                    Debug.Log("El valor de x y y es " + ArregloBiDimensionalUno[x, y] * MiArregloUniDimensionalUno[z]);
                }
            }
    }
        //for (int a = 0; a <= MiArregloUniDimensionalUno.Length; a++)
        //{
        //    Debug.Log(a);
        //    Debug.Log(MiArregloUniDimensionalUno.Length);
        //    Debug.Log(MiArregloUniDimensionalUno[a]);
        //    for (int b = 0; b <= ArregloBiDimensionalUno.GetLength(1); b++)
        //    {
        //        Debug.Log(b);
        //        Debug.Log(ArregloBiDimensionalUno.GetLength(0));
        //        Debug.Log(MiArregloUniDimensionalUno[b]);
        //    }
        //}


    }
}
