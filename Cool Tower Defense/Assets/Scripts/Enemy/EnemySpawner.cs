using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour{
    // Variables
    public GameObject enemy_01;
    public float timer;
    public float SpawnSpeed = 10f;


    // Use this for initialization
    void Start()
    {
        timer = 0f;//2f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(enemy_01, transform.position, transform.rotation);
            timer = SpawnSpeed;//4f;
        }
    }
}