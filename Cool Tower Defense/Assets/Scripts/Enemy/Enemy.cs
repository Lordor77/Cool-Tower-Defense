using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Variables
    public float hp;
    public float speed;

    private Transform target;
    private int flagIndex = 0;



    void Start () {
        hp = 100f;
        speed = 10f;

        target = Flags.flags[0];
    }
	
	void Update () {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        if (Vector3.Distance(transform.position, target.position) <= 0.8f)
            GetNextFlag();
    }

    void GetNextFlag ()
    {
        if (flagIndex >= Flags.flags.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        flagIndex++;
        target = Flags.flags[flagIndex];
    }

    private void OnDestroy()
    {
        CoinsManager.coinsAmount += 10;
    }
}

