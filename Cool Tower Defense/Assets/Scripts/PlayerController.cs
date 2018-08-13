using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCOntroller : MonoBehaviour {

    public float speed = 10f;
    public float lookSensitivity = 3f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");
        Vector3 _MoveHorizontal = transform.right * _xMov;
        Vector3 _MovVertical = transform.forward * _zMov;
        Vector3 _velocity = (_MoveHorizontal + _MovVertical).normalized * speed;
        PrefMove(_velocity);

        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        Rotate(_rotation);

        float _xRot = Input.GetAxisRaw("Mouse Y");

        float _cameraRotationX = _xRot * lookSensitivity;
        RotateCamera(_cameraRotationX);
	}
    public void PrefMove(Vector3 Velocity)
    {
        transform.Translate(Velocity);
    }
}
