using UnityEngine;

public class GO2 : MonoBehaviour
{
    public GameObject Cápusla;
    bool blanco;
    bool negro;
    void Update()
    {
        var c = Cápusla.GetComponent<MeshRenderer>().material;
        var SpawnCubo = Instantiate<GameObject>(Cápusla);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (negro || blanco)
        {
            Debug.Log("La operación es verdadera, por lo que el color es blanco");
            var c = Cápusla.GetComponent<MeshRenderer>().material;
            Color colorblanco = c.color = Color.white;
            blanco = false;
        }
        else
        {
            Debug.Log("La operación es falsa, por lo que el color es negro");
            var c = Cápusla.GetComponent<MeshRenderer>().material;
            Color colorblanco = c.color = Color.black;
            blanco = true;
        }


    }
}


