using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fireBalls;
    private float spawnDelay = 2.0f;
    private float spawnRate = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomFireBall", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomFireBall()
    {
        int randomIndex = Random.Range(0, fireBalls.Length);
        float randomX = Random.Range(-14, 14);
        float zPosition = 22.0f;
        float yPosition = 0.5f;    
        
        Vector3 randomSpawnPos = new Vector3(randomX, yPosition, zPosition);
        
        Instantiate(fireBalls[randomIndex], randomSpawnPos, fireBalls[randomIndex].gameObject.transform.rotation);
    }
}
