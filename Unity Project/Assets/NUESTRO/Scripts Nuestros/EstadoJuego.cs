using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoJuego : MonoBehaviour {

    public static int nivel = 1;
    private static bool completadoUno;
    private static bool completadoDos;
    private static bool completadoTres;
    private static bool completadoCuatro;

    public static EstadoJuego estadoJuego;

	void Awake () {
        if(estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }else if(estadoJuego != this)
        {
            Destroy(gameObject);
        }
	}

    public void setNivel(int n)
    {
        nivel = n;
    }

    public int getNivel()
    {
        return nivel;
    }

    public void setCompletado(bool b)
    {
        if(nivel == 1)
        {
            completadoUno = b;
        }
        if (nivel == 2)
        {
            completadoDos = b;
        }
        if (nivel == 3)
        {
            completadoTres = b;
        }
        if (nivel == 4)
        {
            completadoCuatro = b;
        }
    }




    public bool getCompletado(int n)
    {
        if (n == 1)
        {
            return completadoUno;
        }else if(n == 2)
        {
            return completadoDos;
        }else if(n == 3)
        {
            return completadoTres;
        }
        else
        {
            return completadoCuatro;
        }
    }
}
