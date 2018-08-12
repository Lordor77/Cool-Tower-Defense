using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    // Variables
    public GameObject flag_01;
    public GameObject flag_02;
    public GameObject flag_03;
    public GameObject flag_04;
    public GameObject flag_05;
    public GameObject flag_06;
    public GameObject flag_07;
    public GameObject homeCamp;
    private float speed = 15f;//8f;
    private GameObject target;


    // Use this for initialization
    void Start () {
        target = flag_01;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag("Flag_01"))
            target = flag_02;
        /*
        else if (collision.gameObject.CompareTag("Flag_02"))
            target = flag_03;
        else if (collision.gameObject.CompareTag("Flag_03"))
            transform.LookAt(flag_04.transform);
        else if (collision.gameObject.CompareTag("Flag_04"))
            transform.LookAt(flag_05.transform);
        else if (collision.gameObject.CompareTag("Flag_05"))
            transform.LookAt(flag_06.transform);
        else if (collision.gameObject.CompareTag("Flag_06"))
            transform.LookAt(flag_07.transform);
        else if (collision.gameObject.CompareTag("Flag_07"))
            transform.LookAt(homeCamp.transform);
            */
    }
}
