using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlechaDrc : MonoBehaviour, IPointerClickHandler
{
    public GameObject lugares;
    public GameObject otraFlecha;

    public int clicksMaximos;
    public int cuantosClicks;

    void Start()
    {
        cuantosClicks = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(cuantosClicks < clicksMaximos)
        {
            lugares.transform.position += new Vector3(75, 0, 0);
            cuantosClicks++;
            otraFlecha.GetComponent<FlechaIzq>().cuantosClicks--;
        }
    }

    public int getCuantosClicks()
    {
        return cuantosClicks;
    }
   
}
