using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GO5 : MonoBehaviour
{
    public GameObject Cubo5;

    public bool estado;
    public bool estadoV;
    public GO3 verdadero;
    public GO4 falso;
    MeshRenderer meshRenderer_Cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    private void Start()
    {
        meshRenderer_Cube = Cubo5.GetComponent<MeshRenderer>();
    }
    void FixedUpdate()
    {
        estado = verdadero.verdadero;
        estadoV = falso.falso;
        if (estado && estadoV)
        {
            meshRenderer_Cube.material.color = Color.white;
            Debug.Log("El valor del Cubo 3 y Cubo 4 dan cómo resultado que este cubo sea blanco");
        }
        else
        {
            meshRenderer_Cube.material.color = Color.black;
            Debug.Log("El valor del Cubo 3 y Cubo 4 dan cómo resultado que este cubo sea negro");
        }
    }
}
