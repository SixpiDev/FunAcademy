using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaPosicion : MonoBehaviour {

    public Vector3 posicionObjetivo = new Vector3(0, 0, 0);
	
	// Update is called once per frame
	void Update () {
        posicionObjetivo = gameObject.transform.position;
	}
}
