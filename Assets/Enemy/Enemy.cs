using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int ribEnemy=15;
    [SerializeField] int penalEnemy=15;
    Banck bank;
    


    void Start()
    {
        bank = FindObjectOfType<Banck> ();
        
    }

    // Update is called once per frame
    public void Ribenemy() {


        if (bank == null) { return; }
            bank.Deposit(ribEnemy);
      
    
    }
    public void Penalenemy()
    {

        if (bank == null) { return; }
        bank.Withdraw(penalEnemy);
        

    }
}
