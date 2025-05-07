using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySpawner : MonoBehaviour
{
    public GameObject keyPrefab;  // Assign your key prefab here
    public Vector3 spawnAreaMin;  // Bottom-left corner of the spawn area
    public Vector3 spawnAreaMax;  // Top-right corner of the spawn area

    // Start is called before the first frame update
    void Start()
    {
        SpawnKeys();
    }

    void SpawnKeys() {
        for (int i = 0; i < 5; i++) {
            float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float randomZ = Random.Range(spawnAreaMin.z, spawnAreaMax.z);

            float terrainY = Terrain.activeTerrain.SampleHeight(new Vector3(randomX, 0, randomZ));
            float spawnY = terrainY + 1.5f; // 1.5 units above the terrain

            Vector3 spawnPosition = new Vector3(randomX, spawnY, randomZ);
            Instantiate(keyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}