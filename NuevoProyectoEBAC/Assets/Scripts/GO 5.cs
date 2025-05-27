using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GO5 : MonoBehaviour
{
    public GameObject Cubo5;

    bool Negro;
    bool Blanco;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    private void Awake()
    {
        Blanco = true;
        Negro = false;
        // Mi idea de código era
        // var White = (Cubo5.GetComponent<GO3>().blanco = true);
        // var Black = (Cubo5.GetComponent<GO3>().negro = false);
        // Blanco = White;
        // Negro = Black;
        // if (Negro && Blanco)
        //{
        //   Color color = c.color = Color.white;
        //  Debug.Log("La operación es verdadera, por lo que el GO5 es blanco");
        //}
    }
    void FixedUpdate()
    {
        var c = Cubo5.GetComponent<MeshRenderer>().material;
        if (Blanco && Negro)
        {
            Color color = c.color = Color.white;
            Debug.Log("La operación es verdadera, por lo que el GO5 es blanco");
        }
        else
        {
            Color color = c.color = Color.black;
            Debug.Log("La operación es falsa, por lo que el GO5 es negro");
        }
    }
}
