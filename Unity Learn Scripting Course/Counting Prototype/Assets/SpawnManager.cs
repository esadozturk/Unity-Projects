using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject sphere;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnSphere", 0.0f, 1.0f);
    }

    void SpawnSphere()
    {
        Instantiate(sphere, new Vector3(Random.Range(-13, 13), 13, Random.Range(0, 30)), sphere.transform.rotation);
    }
}
