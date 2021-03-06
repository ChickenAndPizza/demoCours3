﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
    [SerializeField] GameObject Gun;
    [SerializeField] Camera PlayerCamera;
    [SerializeField] GameObject Player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X") != 0)
        {
            Player.transform.Rotate(0, Input.GetAxis("Mouse X") * 50, 0);
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            PlayerCamera.transform.Rotate(-Input.GetAxis("Mouse Y") * 2, 0, 0);
        }
    }
}
