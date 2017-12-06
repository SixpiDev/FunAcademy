﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloScript : MonoBehaviour {

    private Halo h1;

    void Awake()
    {
        h1 = GetComponent<Halo>();
    }

	public void ActivaHalo()
    {
        h1.enabled = true;
    }

    public void DesactivaHalo()
    {
        h1.enabled = false;
    }

}
