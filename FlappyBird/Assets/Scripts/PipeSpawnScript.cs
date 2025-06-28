using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PipeSpawnScript : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public GameObject pipe;
    public float yukseklik;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklik, yukseklik), 0);


    }


    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklik, yukseklik), 0);
            Destroy(newpipe, 15);
            timer = 0;

        }
        timer += Time.deltaTime;

    }
}
