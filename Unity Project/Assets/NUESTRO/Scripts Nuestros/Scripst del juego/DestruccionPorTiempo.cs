using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionPorTiempo : MonoBehaviour {

	void Update () {
        if (gameObject.transform.position.y < -50)
        {
            Destroy(gameObject);
        }
	}
}
