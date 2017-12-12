using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {

    public GameObject[] materiales = new GameObject[25];
    public Vector3 spawnValues;
    public int cantidadDeMateriales = 5;  //Tiene que ser siempre menor que la longitud del array Materiales;
    public float tiempoEntreMateriales = 0.5f;

    public int[] caidoYa = new int[3];

    public Queue<GameObject> enCaida = new Queue<GameObject>();
    public GameObject objetivo;

    GameObject cae;
    

    // Use this for initialization
    void Start () {
        for (int i = 0; i < caidoYa.Length; i++)
        {
            caidoYa[i] = -1;
        }

        for(int i = 0; i < materiales.Length; i++)
        {
            materiales[i].GetComponent<Caida>().disparoAMaterial = 0;
        }

        StartCoroutine(SpawnMaterials());
	}
	
	// Update is called once per frame
	IEnumerator SpawnMaterials () {
        for (int i = 0; i < cantidadDeMateriales; i++)
        {
            int materialRandom = nMaterialRandom();
            float x = Random.Range(-spawnValues.x, spawnValues.x);

            materiales[materialRandom].GetComponent<Caida>().posCaida = x;

            cae = materiales[materialRandom];
            Vector3 spawnPosition = new Vector3(x, spawnValues.y, spawnValues.z);
            Instantiate(cae, spawnPosition, Quaternion.identity);

            enCaida.Enqueue(cae);
            objetivo = enCaida.Peek();

            yield return new WaitForSeconds(tiempoEntreMateriales);
        }
	}

    public void eliminaPrimero()
    {
        enCaida.Dequeue();
        if(enCaida.Count > 0)   
        {
            objetivo = enCaida.Peek();
        }
    }

    private int nMaterialRandom()
    {
        bool esta = true;
        bool salir = false;
        int resultado = -1;
        int numero = -1;
        while (resultado == -1)
        {
            if (esta == true)
            {
                esta = false;
                numero = Random.Range(0, materiales.Length);
                for (int i = 0; i < caidoYa.Length; i++)
                {
                    if (caidoYa[i] != null && caidoYa[i] == numero)
                    {
                        esta = true;
                    }
                }
            }
            else
            {
                resultado = numero;
            }
        }
         for(int i = 0; i < caidoYa.Length && salir == false; i++)
        {
            if(caidoYa[i] == -1)
            {
                caidoYa[i] = numero;
                salir = true;
            }
        }
        return resultado;
    }
}
