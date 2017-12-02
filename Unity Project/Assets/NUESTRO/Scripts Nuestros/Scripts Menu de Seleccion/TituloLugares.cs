using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TituloLugares : MonoBehaviour {

    public Text Titulo;
    public GameObject lugares;

    private void Update()
    {
        if(lugares.transform.position == new Vector3(0, 0, 0))
        {
            Titulo.text = "Granja";
        }else if(lugares.transform.position == new Vector3(75, 0, 0))
        {
            Titulo.text = "Parque";
        }
        else if(lugares.transform.position == new Vector3(150, 0, 0))
        {
            Titulo.text = "Hospital";
        }
        else if(lugares.transform.position == new Vector3(225, 0, 0))
        {
            Titulo.text = "Casa";
        }
    }
}
