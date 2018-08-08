//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Transform target;

    public void BulletTarget(Transform _target)
    {
        target = _target;
    }
	// Update is called once per frame
	void Update () {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward*15F*Time.deltaTime);

        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        target = null;
    }
}
