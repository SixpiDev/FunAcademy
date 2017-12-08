using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour {

    private GameController gc;
    bool ya;

	void Start () {
        ya = false;
        gc = FindObjectOfType<GameController>();
	}
	
	void Update () {
		if(gameObject.transform.position.y < - 15 && ya == false)
        {
            gc.eliminaPrimero();
            ya = true;
        }
	}
}
