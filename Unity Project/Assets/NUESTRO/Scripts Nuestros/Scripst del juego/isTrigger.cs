using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour {
	
	private void OnCollisionEnter2D(Collision2D collision){
		Destroy (collision.gameObject);
		Destroy (this.gameObject);
		Debug.Log ("COLISION");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
