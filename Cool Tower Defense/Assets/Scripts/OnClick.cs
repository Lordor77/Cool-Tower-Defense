﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {

    // Use this for initialization
    private void OnMouseOver()
    {
        if (Input.GetKey("e"))
        {
            Debug.Log("Key E pressed on a tower base.");
        }
    }
}