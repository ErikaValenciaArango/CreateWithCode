using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject enemy;
    private float spawnPos = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, GenerateSpawnPositon(), enemy.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPositon()
    {
        float spawnPosX = Random.Range(-spawnPos, spawnPos);
        float spawnPosZ = Random.Range(-spawnPos, spawnPos);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
