using System;
using UnityEngine;
public class EjerciciosVariablesMod8 : MonoBehaviour

{
    public GameObject CubodeColores;
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
        meshRenderer_Cubo = CubodeColores.GetComponent<MeshRenderer>();
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
        string LetrasPares = Saludo.Substring(0, 1) + Saludo.Substring(2, 1) + Saludo.Substring(4, 1) + Saludo.Substring(6, 1) + Saludo.Substring(8, 1);
        Debug.Log(LetrasPares);
        //Debug.Log(Saludo % 2);
        //int Pares = LetrasPares.Length;
        //Debug.Log(Pares);
        //if (Pares % 2 == 0)
        //{
        //    Debug.Log(Pares % 2);
        //    Debug.Log(Pares % 2 == 2);
        //    Debug.Log(Pares % 2 == 4);
        //}
        float b = 0.1234f;
        string a = b.ToString();
        string c = a.Substring(0, 6);
        meshRenderer_Cubo = CubodeColores.GetComponent<MeshRenderer>();
        string NombreCompleto = "Axel Vázquez López";
        string PrimerApellido = NombreCompleto.Substring(5, 7);
        string SegundoApellido = NombreCompleto.Substring(13, 5);
        Debug.Log(a);
        Debug.Log(c);
        Debug.Log(NombreCompleto);
        Debug.Log(PrimerApellido);
        Debug.Log(SegundoApellido);
        string MensajeMocho = "MensaJerónimo";
        string Recorte = MensajeMocho.Substring(5, 8);
        Debug.Log(Recorte);
    }
    // Update is called once per frame
    void Update()
    {
        E += 2;
        Ee2 += E + e2;
        Debug.Log(Ee2);

        if (Ee2 % 2 == 0)
        {
            meshRenderer_Cubo.material.color = Color.white;
            Debug.Log("El número" + Ee2 + "Es par, por lo tanto el color del cubo es blanco");
        }
        else
        {
            meshRenderer_Cubo.material.color = Color.black;
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

