﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRed : MonoBehaviour {

    public GameObject redRoom;
    public AudioSource noise;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        redRoom.SetActive(true);
        Debug.Log("Red spawn");
        noise.volume -= 0.2f;
    }
}
