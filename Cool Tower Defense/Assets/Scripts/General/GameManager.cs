using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public float dmg;
    public float fireRate;
    public float range;
    private TowerShoot upgrades;
    private Bullet dmgUpgrade;

	// Use this for initialization
	void Start () {
        fireRate = upgrades.fireRate;
        //range = upgrades.towerRange;
        dmg = dmgUpgrade.dmg;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Opening the option to buy towers upgrades
        if (Input.GetMouseButtonDown(1))
        {

        }
	}
}
