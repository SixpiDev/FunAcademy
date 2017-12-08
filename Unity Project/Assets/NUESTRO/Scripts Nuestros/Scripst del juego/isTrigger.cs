using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour {

    private GameController gc;

    void Start()
    {
        gc = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision){
		Destroy (collision.gameObject);
		Destroy (this.gameObject);
    }
}
