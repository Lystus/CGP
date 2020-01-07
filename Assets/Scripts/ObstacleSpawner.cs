using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float FramesTillLastSpawn = 0;
    public float spawnSpeed = 30;

    // Update is called once per frame
    public float spawnChance;
    public GameObject obstPrefab;
    public GameObject parctileSyst;
    void Update()
    {
        FramesTillLastSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);
        float value = Random.Range(transform.position.y + 2f, transform.position.y - 2f);
        if (temp <= spawnChance && FramesTillLastSpawn <= 0)
        {

            Instantiate(obstPrefab, new Vector3(9.2f, value, -0.95f), Quaternion.identity, transform);
            //Instantiate(parctileSyst, new Vector3(9.2f, value, 0), Quaternion.identity, transform);

            FramesTillLastSpawn = (int)spawnSpeed;
        }


    }
}
