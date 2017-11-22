using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour {
	public AudioSource fuente;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Reproducir(){
		fuente.Play ();
	}
}
