using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] materiales = new GameObject[25];
    public Vector3 spawnValues;
    public int cantidadDeMateriales = 5;
    public float tiempoEntreMateriales = 0.5f;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnMaterials());
	}
	
	// Update is called once per frame
	IEnumerator SpawnMaterials () {
        for (int i = 0; i < cantidadDeMateriales; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(materiales[Random.Range(0, materiales.Length)], spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(tiempoEntreMateriales);
        }
	}
}
