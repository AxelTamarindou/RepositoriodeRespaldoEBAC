using UnityEditor;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] MiArregloUniDimensionalUno = new int[3];
        int[] MiArregloUniDimensionalDos = new int[3];
        int[] MiArregloUniDimensionalSuma = new int[3];
        
        
      
        

        for (int i = 0; i < MiArregloUniDimensionalSuma.Length; i++)
        {
            MiArregloUniDimensionalUno[i] = Random.Range(0, 50);
            MiArregloUniDimensionalDos[i] = Random.Range(0, 50);
            Debug.Log("El primer valor es " + MiArregloUniDimensionalUno[i]);
            Debug.Log("El segundo valor es " + MiArregloUniDimensionalDos[i]);
            MiArregloUniDimensionalSuma[i] = MiArregloUniDimensionalUno[i] + MiArregloUniDimensionalDos[i];
            Debug.Log("El resultado de la suma es " + MiArregloUniDimensionalSuma[i]);
        }


        string[] Saludo = new string[] { "Hola ", "mundo ", "¿Cómo ", "están?" };
        string saludocompleto = "";

        
        foreach (string saludo in Saludo)
        {

            saludocompleto += saludo;
        }

        Debug.Log(saludocompleto);


        int[,] ArregloBiDimensionalUno = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        int[] resultado = new int[ArregloBiDimensionalUno.GetLength(0)];

        for (int a = 0; a < ArregloBiDimensionalUno.GetLength(0); a++)
        {
            for (int b = 0; b < ArregloBiDimensionalUno.GetLength(1); b++)
            {
                resultado[a] += ArregloBiDimensionalUno[a, b] * MiArregloUniDimensionalUno[b];
                Debug.Log(ArregloBiDimensionalUno[a, b] * MiArregloUniDimensionalUno[b]);
                //Debug.Log(resultado[a]);
            }
            
        }
        

    }
}
