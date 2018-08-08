using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour {

    //[SerializeField]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform target;
    public float fireRate = 1f;
    public float fireCountDown = 0f;
    public Transform PartToRotate;
    
    


    // Use this for initialization
    void Start ()
    { 
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(PartToRotate.rotation,lookRotation,Time.deltaTime * 15f).eulerAngles;
            PartToRotate.rotation = Quaternion.Euler(0f, rotation.y,0f);
            if (fireCountDown <= 0)
            {
                Shoot();
                fireCountDown = 1f / fireRate;
            }
            fireCountDown -= Time.fixedDeltaTime;
        }
        
	}
    private void OnTriggerStay(Collider other)
    {
        if (target == null)
        {
            target = other.transform;
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (target == null)
        {
            target = other.transform;
            //_hasTrarget = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        target = null;
       // _hasTrarget = false;
    }
    public void Shoot()
    {
        GameObject bulletGo =  Instantiate(bulletPrefab,firePoint.position,firePoint.rotation) as GameObject;
        Bullet bullet = bulletGo.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.BulletTarget(target);
        }
    }
}
