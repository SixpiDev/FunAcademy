using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoloUnoMarcado : MonoBehaviour, IPointerClickHandler
{
    public Boolean marcado = false;

    public GameObject actual;
    public GameObject uno;
    public GameObject dos;

    public void OnPointerClick(PointerEventData eventData)
    {
       if(getMarcado() == false)
        {
            actual.SetActive(true);
            marcado = true;
            uno.GetComponent<SoloUnoMarcado>().getActual().SetActive(false);
            dos.GetComponent<SoloUnoMarcado>().getActual().SetActive(false);
            uno.GetComponent<SoloUnoMarcado>().marcado = false;
            dos.GetComponent<SoloUnoMarcado>().marcado = false;
        }
    }

    public Boolean getMarcado()
    {
        return marcado;
    }

    public GameObject getActual()
    {
        return actual;
    }

 
}
