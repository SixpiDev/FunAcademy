﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Boton : MonoBehaviour, IPointerClickHandler
{
    public GameObject proyectil;

    private BarraVida bd;
    private GameController gc;

	Vector3 pos = new Vector3(0f, -12.5f, 124.3f);

    void Start()
    {
        gc = FindObjectOfType<GameController>();
        bd = FindObjectOfType<BarraVida>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(gc.objetivo != null && gc.objetivo.tag == gameObject.tag && gc.objetivo.GetComponent<Caida>().disparoAMaterial == 0)
        {
            gc.objetivo.GetComponent<Caida>().disparoAMaterial++;
			//Debug.Log (gc.objetivo.GetComponent<Caida> ().posCaida);
			pos[0] = gc.objetivo.GetComponent<Caida> ().posCaida;
            Instantiate(proyectil, pos, Quaternion.identity);
            gc.eliminaPrimero();
            bd.sumarPuntos(10);
        }
        else
        {
            bd.restarPuntos(5);
        }
        
    }
}
