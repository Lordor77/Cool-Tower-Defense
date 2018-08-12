using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {

    public float currentX;
    private Camera mainCamera;
	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        currentX = Input.GetAxisRaw("Mouse X");
	}
    private void LateUpdate()
    {
        
    }
}
