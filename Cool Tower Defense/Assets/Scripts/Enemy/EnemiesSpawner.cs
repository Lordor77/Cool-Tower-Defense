using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour {
    // Variables
    public GameObject enemy_01;
    private float timer;


	// Use this for initialization
	void Start () {
        timer = 0f;//2f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(enemy_01, transform.position, transform.rotation);
            timer = 1f;//4f;
        }
	}
}
