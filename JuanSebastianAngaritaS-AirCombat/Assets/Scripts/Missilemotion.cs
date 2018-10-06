﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilemotion : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * speed);
    }

    void OnCollisionEnter(Collision collision) {

        Debug.Log("colision detectada");
        GameObject enemy = collision.collider.gameObject;
        GameObject.Destroy(enemy);
        GameObject Missile = this.gameObject;
        GameObject.Destroy(Missile);
	}
}
