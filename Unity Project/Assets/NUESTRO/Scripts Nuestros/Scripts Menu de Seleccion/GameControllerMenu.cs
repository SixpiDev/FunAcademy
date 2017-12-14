using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerMenu : MonoBehaviour {

    public GameObject lugaresVacio;
    private EstadoJuego estadoJuego;
    private FlechaDrc fd;
    private FlechaIzq fi;

    public GameObject casaBonita;
    public GameObject casaFea;

    public GameObject granjaBonita;
    public GameObject granjaFea;

    public GameObject parqueBonito;
    public GameObject parqueFeo;

    public GameObject hospitalBonita;
    public GameObject hospitalFea;

    public bool acaboDeSalir = false;

    public int UnaVezPulsadoTrasJuegoNoMoverLugares = 0;

    void Awake()
    {
        estadoJuego = FindObjectOfType<EstadoJuego>();
        fd = FindObjectOfType<FlechaDrc>();
        fi = FindObjectOfType<FlechaIzq>();
    }

	// Use this for initialization
	void Start () { 
        if(estadoJuego.getCompletado(1) == true)
        {
            granjaFea.SetActive(false);
            granjaBonita.SetActive(true);
        }
        if (estadoJuego.getCompletado(2) == true)
        {
            parqueFeo.SetActive(false);
            parqueBonito.SetActive(true);
        }
        if (estadoJuego.getCompletado(3) == true)
        {
            hospitalFea.SetActive(false);
            hospitalBonita.SetActive(true);
        }
        if (estadoJuego.getCompletado(4) == true)
        {
            casaFea.SetActive(false);
            casaBonita.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (acaboDeSalir == true)
        {
            if (lugaresVacio.transform.position.x == 0)
            {
                estadoJuego.setNivel(1);
            }
            if (lugaresVacio.transform.position.x == 75)
            {
                estadoJuego.setNivel(2);
            }
            if (lugaresVacio.transform.position.x == 150)
            {
                estadoJuego.setNivel(3);
            }
            if (lugaresVacio.transform.position.x == 225)
            {
                estadoJuego.setNivel(4);
            }
        }
        else
        {
            if (estadoJuego.getNivel() == 1)
            {
                lugaresVacio.transform.position = new Vector3(0, 0, 0);
                fd.cuantosClicks = 3;
                fi.cuantosClicks = 0;
            }
            if (estadoJuego.getNivel() == 2)
            {
                lugaresVacio.transform.position = new Vector3(75, 0, 0);
                fd.cuantosClicks = 2;
                fi.cuantosClicks = 1;
            }
            if (estadoJuego.getNivel() == 3)
            {
                lugaresVacio.transform.position = new Vector3(150, 0, 0);
                fd.cuantosClicks = 1;
                fi.cuantosClicks = 0;
            }
            if (estadoJuego.getNivel() == 4)
            {
                lugaresVacio.transform.position = new Vector3(225, 0, 0);
                fd.cuantosClicks = 0;
                fi.cuantosClicks = 3;
            }
        }

        if(estadoJuego.getCompletado(estadoJuego.getNivel()) == true)
        {
            if(estadoJuego.getNivel() == 1)
            {
                granjaFea.SetActive(false);
                granjaBonita.SetActive(true);
            }else if(estadoJuego.getNivel() == 2)
            {
                parqueFeo.SetActive(false);
                parqueBonito.SetActive(true);
            }else if(estadoJuego.getNivel() == 3)
            {
                hospitalFea.SetActive(false);
                hospitalBonita.SetActive(true);      
            }else if(estadoJuego.getNivel() == 4)
            {
                casaFea.SetActive(false);
                casaBonita.SetActive(true);     
            }
            
        }
    }


}
