using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiamonds : MonoBehaviour
{
    public GameObject diamonds;
    public float xPos;
    public float zPos;
    public int diamondCount;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosZ = Random.Range(45, 57);
        float spawnPosx = Random.Range(-8, 49);

        Vector3 randomPos = new Vector3(spawnPosx, 19, spawnPosZ);

        return randomPos;
    }
}
