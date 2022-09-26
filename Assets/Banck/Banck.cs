using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Banck : MonoBehaviour
{
    [SerializeField] int liquidity = 150;
    [SerializeField] int currenBank;
    [SerializeField] TextMeshProUGUI diplaybalance;
    
    public int CurrenBank { get { return currenBank; } }

    
    void Awake()
    {
        currenBank = liquidity;
        BoardScore();
    }

    public void Deposit(int month) {

        currenBank += Mathf.Abs(month);
        BoardScore();
    }

    public void Withdraw(int month)
    {
        currenBank -= Mathf.Abs(month);
        BoardScore();

        if (currenBank < 0) {
            Reload();
            

        }


       void Reload() {

            Scene reload = SceneManager.GetActiveScene();
            SceneManager.LoadScene(reload.buildIndex);
        
        
        }

        

    }

    void BoardScore() {

        diplaybalance.text = "Gold: " + currenBank;


    }



}
