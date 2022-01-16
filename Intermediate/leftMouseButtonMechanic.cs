using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMouseButtonMechanic : MonoBehaviour
{
    [SerializeField] private float fireRate = 15f;
    
    private float nextTimeToFire = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire){
        	nextTimeToFire = Time.time + 1f/fireRate;
        	Shoot();
        }
    }

    void Shoot() {
        // To Know How to Shoot Using Raycast check our shootRayCastMechanic.cs Script
    }
}