using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CerrarMenuTrasero : MonoBehaviour, IPointerClickHandler {

    public GameObject menuACerrar;

    public void OnPointerClick(PointerEventData eventData)
    {
        menuACerrar.SetActive(false);
    }
}
