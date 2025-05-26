using UnityEngine;

public class RandomAwake : MonoBehaviour
{
    public GameObject Cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        var c = Cubo.GetComponent<MeshRenderer>().material;
        var SpawnCubo = Instantiate<GameObject>(Cubo);
        c.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
