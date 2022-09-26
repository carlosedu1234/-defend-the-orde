using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    int ScoreB;
    Banck goldInt;
    TMP_Text textI;
    public void Start()
    {
        textI = GetComponent<TMP_Text>();
        textI.text = "Gold: ";
    }
    public void Scoreboar(int score)
    {

        
            ScoreB += score;
            string data = ScoreB + string.Empty;
            textI.text = "Gold: " + data;
        
    }
}

