using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 20f;
    [SerializeField] private float spawnPosZ = 20f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    [SerializeField] private float minSpawnInterval = 1f;
    [SerializeField] private float maxSpawnInterval = 3f;

    void Start()
    {
        // Если в сцене есть PlayerController — подставляем его xRange,
        // чтобы зоны спауна всегда совпадали с лимитами игрока.
        var player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            spawnRangeX = Mathf.Abs(player.XRange);
        }

        StartCoroutine(SpawnAnimalWithRandomInterval());
        //InvokeRepeating("SpawnRandomInterval", startDelay, spawnInterval)
    }

    private IEnumerator SpawnAnimalWithRandomInterval()
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            SpawnRandomInterval();
            float spawnInterval = Random.Range(minSpawnInterval, minSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnRandomInterval()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }

}
