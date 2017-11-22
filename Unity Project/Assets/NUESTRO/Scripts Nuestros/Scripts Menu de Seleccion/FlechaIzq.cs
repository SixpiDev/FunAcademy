using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlechaIzq : MonoBehaviour, IPointerClickHandler
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
            lugares.transform.position += new Vector3(+75, 0, 0);
            cuantosClicks++;
            otraFlecha.GetComponent<FlechaDrc>().cuantosClicks--;
        }
        else
        {
            
            lugares.transform.position = new Vector3(0, 0, 0);
            cuantosClicks = 0;
            otraFlecha.GetComponent<FlechaDrc>().cuantosClicks = clicksMaximos;
        }
    }

    public int getCuantosClicks()
    {
        return cuantosClicks;
    }
   
}
