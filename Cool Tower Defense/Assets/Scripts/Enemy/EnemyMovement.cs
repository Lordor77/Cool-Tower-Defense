using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    // Variables
    public GameObject target;
    private float speed = 8f;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
