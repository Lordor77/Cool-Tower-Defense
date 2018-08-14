using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {

    public float speed = 30f;
    public float borderSize = 10f;
    private bool doMovement = true;
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))        
            doMovement = !doMovement;
        
        if (!doMovement)       
            return;
        
        if (Input.mousePosition.y >= Screen.height - borderSize)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        }
        if (Input.mousePosition.y <= borderSize)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime,Space.World);
        }
        if (Input.mousePosition.x >= Screen.width - borderSize)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
        if (Input.mousePosition.x <= borderSize)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * scrollSpeed * 1000 * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y,minY,maxY);
        transform.position = pos;
    }
}
