using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 50;
    
    Banck bank;
   

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


}
