using Unity.VisualScripting;
using UnityEngine;

public class Clases : MonoBehaviour
{
    public float numero1 = 5;
    public float numero2 = 4;
    public bool numero3;
    public float resultado;
    void Start()
    {
        resultado = SumaFunciones(numero1, numero2);
        Debug.Log(resultado);
        VuelveACeroAlNumero(out resultado);
        Debug.Log(resultado);
    }

    public float SumaFunciones (float a, float b)
    {
        return a * b;
    }

    public void VuelveACeroAlNumero (out float numero)
    {
        numero = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
