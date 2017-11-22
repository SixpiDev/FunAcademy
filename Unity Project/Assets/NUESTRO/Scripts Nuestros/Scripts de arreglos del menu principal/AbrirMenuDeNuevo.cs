using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AbrirMenuDeNuevo : MonoBehaviour, IPointerClickHandler
{

    public GameObject menuaAbrir;

    public void OnPointerClick(PointerEventData eventData)
    {
        menuaAbrir.SetActive(true);
    }

   
}
