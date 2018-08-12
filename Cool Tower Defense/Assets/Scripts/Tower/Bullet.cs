//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Transform target;
    public float dmg;
    public float bulletSpeed = 25f;
    //private Enemy hp;


    private void Start()
    {
        dmg = 50;
        //hp = GetComponent<Enemy>();
    }
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
            transform.Translate(Vector3.forward*bulletSpeed*Time.deltaTime);

        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        target.GetComponent<Enemy>().hp -= dmg;
        Destroy(this.gameObject);
        target = null;
    }
}
