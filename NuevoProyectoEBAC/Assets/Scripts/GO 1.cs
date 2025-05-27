
using UnityEngine;

public class GO1 : MonoBehaviour
{
    public GameObject Cubo;
    bool negro;
    bool blanco;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        blanco = true;
        negro = false;
        var c = Cubo.GetComponent<MeshRenderer>().material;
        Color colorblanco = c.color = Color.black;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (negro || blanco)
        {
            Debug.Log("La operación es verdadera, por lo que el color es blanco");
            var c = Cubo.GetComponent<MeshRenderer>().material;
            Color colorblanco = c.color = Color.white;
            blanco = false;
        }
        else
        {
            Debug.Log("La operación es falsa, por lo que el color es negro");
            var c = Cubo.GetComponent<MeshRenderer>().material;
            Color colorblanco = c.color = Color.black;
            blanco = true;
        }


    }
}

// Start is called once before the first execution of Update after the MonoBehaviour is created
//void Awake()
//{
//    var c = Cubo.GetComponent<MeshRenderer>().material;
//    var SpawnCubo = Instantiate<GameObject>(Cubo);
//    c.color = new Color(Random.value, Random.value, Random.value);
//}

// Update is called once per frame

