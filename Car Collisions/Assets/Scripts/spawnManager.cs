using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject carPrefabs;
    public int carCount;
    public int round = 1;
    private PlayerController PlayerController;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
        SpawnEnemyWave(round);
    }

    // Update is called once per frame
    void Update()
    {
        carCount = FindObjectsOfType<Car>().Length;

        if (carCount == 0)
        {
            round++;
            SpawnEnemyWave(round);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        if(PlayerController.gameOver == false)
        for (int i = 0; i < enemiesToSpawn; i++)
        {
             Instantiate(carPrefabs, GenerateSpawnPosition(), carPrefabs.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosZ = Random.Range(45, 57);
        float spawnPosx = Random.Range(-8, 49);

        Vector3 randomPos = new Vector3(spawnPosx, 19, spawnPosZ);

        return randomPos;
    }
}
