
using UnityEngine;

public class GO1 : MonoBehaviour
{
    public GameObject Cubo;
    public bool color = false;
    public MeshRenderer meshRenderer_Cubo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer_Cubo = Cubo.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (color)
        {
            meshRenderer_Cubo.material.color = Color.black;
            color = false;
        }
        else
        {
            meshRenderer_Cubo.material.color = Color.white;
            color = true;
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

