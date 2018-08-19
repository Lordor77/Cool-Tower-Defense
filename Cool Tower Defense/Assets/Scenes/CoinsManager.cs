using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour {

    // Variables
    public Text coinsText;
    public static int coinsAmount = 0;



    void Start ()
    {
        coinsText.text = coinsAmount.ToString();
    }
    
    void Update ()
    {
    }
}
