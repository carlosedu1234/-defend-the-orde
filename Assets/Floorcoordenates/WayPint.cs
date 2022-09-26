using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPint : MonoBehaviour
{
    [SerializeField] bool convert;
    [SerializeField] Tower TowerPrefac;
    
    public bool isconvert { get { return convert; } }
    
    public void OnMouseDown()
    {
        if (convert) 
        {
            bool costTower= TowerPrefac.InstTower(TowerPrefac, transform.position); 
      
            convert=!costTower;
            
        }
    }
}
