using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueLugar : MonoBehaviour {

    public GameObject lugares;

    private int nivel;

	// Use this for initialization
	void Start () {
        nivel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(lugares.transform.position.x == 0)
        {
            nivel = 1;
        }
        if(lugares.transform.position.x == 75)
        {
            nivel = 2;
        }
        if(lugares.transform.position.x == 150)
        {
            nivel = 3;
        }
        if(lugares.transform.position.x == 225)
        {
            nivel = 4;
        }
    }

    public int getNivel()
    {
        return nivel;
    }
}
