using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 50;
    [SerializeField] float fastAtack = 1;
    ParticleSystem fast;
   
    Banck bank;


    public void Update()
    {
        fast = FindObjectOfType<ParticleSystem>();
        ControlFast();

    }

    public bool InstTower(Tower tower, Vector3 position)
    {
        bank = FindObjectOfType<Banck>();

        if (bank == null)
        {
            return false;
        }
        else if (bank.CurrenBank >= cost)
        {
            Instantiate(tower, position, Quaternion.identity);
            bank.Withdraw(cost);
           
            return true;
        }
        return false;

    }


    public void ControlFast() {


        var vel = fast.emission;
        vel.rateOverTime = fastAtack;



    }


}
