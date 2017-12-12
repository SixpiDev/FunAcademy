using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 100;

	public void restarPuntos(float value)
	{
		Health -= value;
		HealthBar.size = Health / 100f;
	}

    public void sumarPuntos(float value)
    {
        Health += value;
        HealthBar.size = Health / 100f;
    }

}
