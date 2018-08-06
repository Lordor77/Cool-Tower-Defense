using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    // Variables
    public Transform home;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(home.transform.position.x, home.transform.position.y, home.transform.position.z));
    }
}
