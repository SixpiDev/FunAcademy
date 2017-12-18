using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProyectil : MonoBehaviour {

    public float speed;

    private GameController gc;
    private Rigidbody2D rb;

    Vector2 v2 = new Vector2(1, 1);

    void Awake()
    {
        gc = FindObjectOfType<GameController>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Start () {
        //Debug.Log("Tag: "+ gc.objetivo.tag+" / X :" + gc.objetivo.transform.position.x + " / Y: " + gc.objetivo.transform.position.y);

        Vector3 lanza = new Vector3(gc.objetivo.transform.position.x+0, 15, 0);   
        rb.velocity = lanza * speed;
	}

}
