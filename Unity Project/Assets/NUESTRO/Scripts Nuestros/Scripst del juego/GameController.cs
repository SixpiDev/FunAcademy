using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {

    public GameObject[] materiales = new GameObject[25];
    public Vector3 spawnValues;
    public int cantidadDeMateriales = 5;
    public float tiempoEntreMateriales = 0.5f;

    int i;
    bool wop;

    public Queue<GameObject> enCaida = new Queue<GameObject>();
    public GameObject objetivo;

    GameObject cae;
    

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnMaterials());
	}
	
	// Update is called once per frame
	IEnumerator SpawnMaterials () {
        for (int i = 0; i < cantidadDeMateriales; i++)
        {
            wop = false;
            cae = materiales[Random.Range(0, materiales.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(cae, spawnPosition, Quaternion.identity);
       
            enCaida.Enqueue(cae);
            objetivo = enCaida.Peek();

            enCaida.Peek().GetComponent<HaloScript>().ActivaHalo();

            yield return new WaitForSeconds(tiempoEntreMateriales);
        }
	}

    public void eliminaPrimero()
    {
        objetivo = enCaida.Peek();
        enCaida.Dequeue();
    }

    private void Update()
    {

    }
}
