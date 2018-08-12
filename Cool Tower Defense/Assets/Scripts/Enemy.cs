using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Variables
    private float hp;
    private float speed;
    private Transform target;

    

    void Start () {
        hp = 100f;
        speed = 10f;
        target = GameObject.Find("Flag_01").GetComponent<Transform>();
    }
	
	void Update () {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Switching Flags (For Movement)
        if (other.gameObject.CompareTag("Flag_01"))
            target = GameObject.Find("Flag_02").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_02"))
            target = GameObject.Find("Flag_03").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_03"))
            target = GameObject.Find("Flag_04").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_04"))
            target = GameObject.Find("Flag_05").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_05"))
            target = GameObject.Find("Flag_06").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_06"))
            target = GameObject.Find("Flag_07").GetComponent<Transform>();

        else if (other.gameObject.CompareTag("Flag_07"))
            target = GameObject.Find("HomeCamp").GetComponent<Transform>();
    }
}
