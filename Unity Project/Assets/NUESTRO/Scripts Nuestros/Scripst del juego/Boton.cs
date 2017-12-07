using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Boton : MonoBehaviour, IPointerClickHandler
{
    public GameObject proyectil;

    private GameController gc;
    Vector3 pos = new Vector3(0f, -12.5f, 100f);

    void Start()
    {
        gc = FindObjectOfType<GameController>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(gc.objetivo != null && gc.objetivo.tag == gameObject.tag)
        {
			Debug.Log (gc.objetivo.GetComponent<Caida> ().posCaida);
			pos[0] = gc.objetivo.GetComponent<Caida> ().posCaida;
            Instantiate(proyectil, pos, Quaternion.identity);
        }
        else
        {
            //animacion de que el objetivo no va en el color que has seleccionado
        }
        
    }
}
