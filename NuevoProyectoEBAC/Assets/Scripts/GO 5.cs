using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GO5 : MonoBehaviour
{
    public GameObject Cubo5;

    public bool estado;
    public bool estadoV;
    MeshRenderer meshRenderer_Cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    private void Start()
    {
        meshRenderer_Cube = Cubo5.GetComponent<MeshRenderer>();
        estado = Cubo5.GetComponent<GO4>().blanco;
        estadoV = Cubo5.GetComponent<GO3>().blanco;

    }
    void FixedUpdate()
    {
        if (estado && estadoV)
        {
            estado = true;
            meshRenderer_Cube.material.color = Color.white;
            Debug.Log("La operación es verdadera, por lo que el GO5 es blanco");
        }
        else
        {
            meshRenderer_Cube.material.color = Color.black;
            estado = false;
            Debug.Log("La operación es falsa, por lo que el GO5 es negro");
        }
    }
}
