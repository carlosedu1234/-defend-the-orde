using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] List<WayPint> coordinates = new List<WayPint>();
    // Start is called before the first frame update
    void Start()
    {
        WathCoor();
    }

    void WathCoor() {

        foreach (WayPint warpoint in coordinates) {

            Debug.Log(warpoint.name);
        }
    }
   
}
