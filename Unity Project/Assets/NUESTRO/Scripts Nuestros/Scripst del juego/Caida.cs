﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour {

    public float speed;
    private Rigidbody2D rig;
    private SpriteRenderer sr;

    
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Start () {
        rig.velocity = transform.up * -speed;
	}
	
	
}