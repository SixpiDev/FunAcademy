using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour {

    private GameController gc;
    bool ya;
    private BarraVida bd;

	void Start () {
        ya = false;
        gc = FindObjectOfType<GameController>();
        bd = FindObjectOfType<BarraVida>();
	}
	
	void Update () {
		if(gameObject.transform.position.y < - 15 && ya == false)
        {
            gc.eliminaPrimero();
            bd.restarPuntos(5);
            ya = true;
        }
	}
}
