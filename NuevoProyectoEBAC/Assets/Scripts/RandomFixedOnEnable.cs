using UnityEngine;

public class FixedOnEnable : MonoBehaviour
{
    public GameObject Esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        var c = Esfera.GetComponent<MeshRenderer>().material;
        c.color = new Color(Random.value, Random.value, Random.value);
    }

    void OnEnable()
    {
        var SpawnCubo = Instantiate<GameObject>(Esfera);
    }

    void OnDisable()
    {
        Debug.Log("Se desactivó la esfera");
    }

    // Update is called once per frame

}
