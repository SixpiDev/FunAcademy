using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour {

    private int score;

    public int scoreInicial;
    public int fallo;
    public int acierto;

	// Use this for initialization
	void Start () {
        score = scoreInicial;
	}
	
    public void scoreFallo()
    {
        score -= fallo;
    }

    public void scoreAcierto()
    {
        score += acierto;
    }
}
