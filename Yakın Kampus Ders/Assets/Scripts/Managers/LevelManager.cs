using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;
    public GameObject collectiblePrefab;
    public List<GameObject> collectibles;

    public void RestartLevel()
    {
        DeactivateDoor();
        RandomizeDoorPosition();
        DeleteCollectibles();
        GenerateCollectibles();
    }

    private void DeleteCollectibles()
    {
        foreach (GameObject c in collectibles)
        {
            Destroy(c);
        }
        collectibles.Clear();
    }

    private void GenerateCollectibles()
    {
        var newCollectible = Instantiate(collectiblePrefab);
        newCollectible.transform.position = new Vector3(Random.Range(-4.5f, 3.5f),0,5);
        collectibles.Add(newCollectible);
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-3f, 3f);
        door.transform.position = pos;
    }

    private void DeactivateDoor()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}
