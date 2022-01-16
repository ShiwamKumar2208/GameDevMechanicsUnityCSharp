using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootRayCastMechanic : MonoBehaviour
{
    // I m just Continuing with my leftMouseButtonMechanic.cs Script
    // And This Script is required by the Takedamage.cs Script

    public float damage = 10f;
    public float range = 100f;

    [SerializeField] private Transform firePoint = null;
    [SerializeField] private float impactForce = 30f;

    void Shoot() {
    	RaycastHit hit;

    	if (Physics.Raycast(firePoint.transform.position, firePoint.transform.forward, out hit, range)) {

    		Target target = hit.transform.GetComponent<Target>();
    		if (target != null){
    			target.TakeDamage(damage);
    		}

    		if (hit.rigidbody != null) {
    			hit.rigidbody.AddForce(-hit.normal * impactForce);
    		}
    	}
    }
}