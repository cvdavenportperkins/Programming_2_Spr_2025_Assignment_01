using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject coinPrefab;

    public SpawnCoin()
    {
        Vector2 spawnPosition = new Vector2(Random Range - 5, 5);
        Instatiate(coinPrefab);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(colorPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
