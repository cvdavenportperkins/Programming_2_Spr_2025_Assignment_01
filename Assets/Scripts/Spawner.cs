using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject coinPrefab;

    public void SpawnCoin()
    {
        Vector2 spawnPosition = new Vector2(Random.Range( -5, 5), Random.Range( -5, 5));
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
