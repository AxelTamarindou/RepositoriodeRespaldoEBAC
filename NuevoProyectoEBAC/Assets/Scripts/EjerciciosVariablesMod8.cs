using System;
using UnityEngine;
public class EjerciciosVariablesMod8 : MonoBehaviour

{
    public GameObject CubodeColores;
    public GameObject CuboBlancoyNegro;
    private MeshRenderer meshRenderer_Cubo;
    public string colores;
    int E = 8;
    int e2 = 7;
    float F = 2;
    float f2 = 17;
    float Ff2 = 0;
    int Ee2 = 0;
    void Start()
    {
        Ff2 = (int)F + f2;
        Debug.Log(Ff2);
        float FE = (int)F + (int)E;
        Debug.Log(FE);
        Debug.Log(e2);
        string Millar = "1546";
        string SegundoMillar = "2718";
        int ValorEntero = int.Parse(Millar) + int.Parse(SegundoMillar);
        Debug.Log(ValorEntero);
        if (int.TryParse(Millar.ToString(), out ValorEntero))
        {
            Debug.Log("La operación fue correcta");
        }
        string Saludo = "Hola Mundo desde EBAC Palabra muy grande";
        string SaludoPar = "";

        for (int i = 0; i < Saludo.Length; i += 2)
        {
            {
                Debug.Log(SaludoPar += Saludo[i] + "");
            }
        }

        //Segundo intento
        //for (int i = 0; i < Saludo.Length; i++)
        //{
        //    {
        //        Debug.Log(SaludoPar += Saludo[i % 2] + "");
        //    }
        //}

        // Tercer intento
        //int SaludoPar = Saludo.Length;
        //string LetrasPar = SaludoPar.ToString();
        //for (int i = 0; i < Saludo.Length; i++)
        //{
        //    {
        //        Debug.Log(LetrasPar += Saludo[i] + "");
        //    }
        //}

        float b = 0.1234489f;
        string a = b.ToString("F4");
        string NombreCompleto = "Axel Vázquez López";
        string PrimerApellido = NombreCompleto.Substring(5, 7);
        string SegundoApellido = NombreCompleto.Substring(13, 5);
        Debug.Log(a);
        //Debug.Log(NombreCompleto);
        //Debug.Log(PrimerApellido);
        //Debug.Log(SegundoApellido);
        string MensajeMocho = "MensaJerónimo";
        string Recorte = MensajeMocho.Substring(5, 8);
        //Debug.Log(Recorte);
    }
    // Update is called once per frame
    void Update()
    {
        var meshRenderer_CuboBooleano = CuboBlancoyNegro.GetComponent<MeshRenderer>();
        var meshRenderer_Cubo = CubodeColores.GetComponent<MeshRenderer>();
        E += 2;
        Ee2 += E + e2;
        //Debug.Log(Ee2);

        if (Ee2 % 2 == 0)
        {
            meshRenderer_CuboBooleano.material.color = Color.white;
            Debug.Log("El número" + Ee2 + "Es par, por lo tanto el color del cubo es blanco");
        }
        else
        {
            meshRenderer_CuboBooleano.material.color = Color.black;
            Debug.Log("El número" + Ee2 + "Es non, por lo tanto el color del cubo es negro");
        }
            switch (colores)
            {
                case "Blanco":
                    meshRenderer_Cubo.material.color = Color.white;
                    break;
                case "Negro":
                    meshRenderer_Cubo.material.color = Color.black;
                    break;
                case "Azul":
                    meshRenderer_Cubo.material.color = Color.blue;
                    break;
                case "Verde":
                    meshRenderer_Cubo.material.color = Color.green;
                    break;
                case "Amarillo":
                    meshRenderer_Cubo.material.color = Color.yellow;
                    break;
            }
       
    }

    void FixedUpdate()
    {
        F *= F;
        Debug.Log(F);
    }
}

