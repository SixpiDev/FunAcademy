using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour {

    public float speed;
    public bool apuntame;
	public float posCaida;

    public int disparoAMaterial;

    private Rigidbody2D rig;
    private SpriteRenderer sr;
    
    
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Start () {
        rig.velocity = transform.up * -speed;
        posCaida = 0;
        disparoAMaterial = 0;
    }



	
	
}
