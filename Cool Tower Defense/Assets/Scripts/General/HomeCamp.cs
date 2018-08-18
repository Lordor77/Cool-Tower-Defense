using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeCamp : MonoBehaviour {
    // Variables
    private int lives;
    public Text GUI_Lives;


	// Use this for initialization
	void Start () {
        lives = 10;
        GUI_Lives.text = "Lives: " + lives;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy_01"))
        {
            Destroy(other);
            lives--;
            GUI_Lives.text = "Lives: " + lives.ToString();
        }
    }
}
