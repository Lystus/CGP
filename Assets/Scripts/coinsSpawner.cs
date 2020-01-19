using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float FramesTillLastSpawn = 0;
    public float spawnSpeed = 30;
    // Update is called once per frame
    public float spawnChance;
    public GameObject Coins;
    void Update()
    {
        FramesTillLastSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);
        float value = Random.Range(transform.position.y + 2f, transform.position.y - 2f);
        if (temp <= spawnChance && FramesTillLastSpawn <= 0)
        {
            Instantiate(Coins, new Vector3(24.2f, value, -0.95f), Quaternion.identity, transform);
            FramesTillLastSpawn = (int)spawnSpeed;
        }


    }
}