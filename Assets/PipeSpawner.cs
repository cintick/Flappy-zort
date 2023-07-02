using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    private float timer = 0.0f;
    private int seconds;
    public int PipeInterval;

    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);

        if (seconds == PipeInterval)
        {
            Spawnpipe();
        }

    }
    private void Spawnpipe()
    {
        float highpoint = transform.position.y + 5;
        float lowpoint = transform.position.y - 5;

        Instantiate(pipes, new Vector3(transform.position.x, UnityEngine.Random.Range(highpoint, lowpoint), 0), transform.rotation);
        timer = 0;
    }
}
    

