using UnityEngine;

public class GO3 : MonoBehaviour
{
    public GameObject Esfera;
    public bool blanco;
    public bool negro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        negro = true;
        blanco = false;
    }
    void FixedUpdate()
    {
        var c = Esfera.GetComponent<MeshRenderer>().material;

        if (negro && blanco)
        {
            //Debug.Log("La operación es verdadera, por lo que el color es blanco");
            Color color = c.color = Color.white;
        }
        else
        {
            //Debug.Log("La operación es falsa, por lo que el color es negro");
            Color color = c.color = Color.black;
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
