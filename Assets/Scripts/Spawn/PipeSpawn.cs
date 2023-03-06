using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject PipePrefab;
    private float timer = 0f;   //updatable value
    private float spawnTime = 1.9f; //time between pipe spawn
    private ushort destroyTime = 7; //life time of pipe
    private float heightRow = 1.8f;

    private void Update()
    {
        if (spawnTime <= timer)
        {
            GameObject pipe = Instantiate(PipePrefab);
            pipe.transform.position = this.transform.position + new Vector3(0, Random.Range(-heightRow, heightRow), 0);
            timer = 0f;
            Destroy(pipe, destroyTime);
        }

        timer += Time.deltaTime;
    }
}
