using UnityEngine;

public class RandomUpdate : MonoBehaviour
{
    public GameObject Cápusla;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        var c = Cápusla.GetComponent<MeshRenderer>().material;
        var SpawnCubo = Instantiate<GameObject>(Cápusla);
        c.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    
}
