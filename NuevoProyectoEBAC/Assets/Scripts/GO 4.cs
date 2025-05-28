using UnityEngine;

public class GO4 : MonoBehaviour
{
    public GameObject Esfera2;
    public bool blanco;
    public bool negro;
    public bool falso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        blanco = true;
        negro = false;
    }
    void FixedUpdate()
    {
        var c = Esfera2.GetComponent<MeshRenderer>().material;
        //c.color = new Color(Random.value, Random.value, Random.value);

        if (blanco || negro)
        {
            // Debug.Log("La operación es verdadera, por lo que el color es blanco");
            Color color = c.color = Color.white;
            falso = true;
        }
        else
        {
            //Debug.Log("La operación es falsa, por lo que el color es negro");
            Color color = c.color = Color.black;
            falso = false;
        }
    }

    //void OnEnable()
    //{
    //    var SpawnCubo = Instantiate<GameObject>(Esfera);
    //}

    //void OnDisable()
    //{
    //    Debug.Log("Se desactivó la esfera");
    //}

    // Update is called once per frame

}
