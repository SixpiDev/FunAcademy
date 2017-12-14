using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonVale : MonoBehaviour, IPointerClickHandler
{

    bool pulsado = false;

    public GameObject cuadroInformativo;
    public GameObject oscurecedor;

    public AudioSource musicaJuego;

	// Use this for initialization
	void Start () {
        pulsado = false;
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        pulsado = true;
        cuadroInformativo.SetActive(false);
        oscurecedor.SetActive(false);
        gameObject.SetActive(false);
        musicaJuego.Play();
    }

    public bool getPulsado()
    {
        return pulsado;
    }

    
}
