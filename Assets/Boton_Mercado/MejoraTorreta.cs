using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejoraTorreta : MonoBehaviour
{
    Tower fast;


    private void Start()
    {
        fast = FindObjectOfType<Tower>();
    }



    public void prueba() {
       
        fast.ControlFast();
        Debug.Log("boton funcionando");
    }
}
