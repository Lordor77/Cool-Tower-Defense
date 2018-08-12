using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public Transform Player;
    public Vector3 offsets;
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Player.position + offsets;
	}
}
