using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDonw : MonoBehaviour
{
    private Animator buttonAni;
    private Boton boton;
    void Start()
    {
        buttonAni = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boton.showMenu) {

            buttonAni.SetBool("b_ShowMenu", true);

        }

        if (!boton.showMenu)
        {

            buttonAni.SetBool("b_ShowMenu", false);

        }
    }
}
