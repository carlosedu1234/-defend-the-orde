using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]

public class Coordenadas : MonoBehaviour
{

    [SerializeField]Color defaultColor =Color.white;
    [SerializeField] Color blockColor = Color.gray;
    TextMeshPro label;
    Vector2Int coordenadas = new Vector2Int();
    // Update is called once per frame
    WayPint waipon;

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        label.enabled = false;
        waipon = GetComponentInParent<WayPint>();
        DirCoordenadas();
        
    }
    void Update()
    {

        if (!Application.isPlaying) {

            DirCoordenadas();
            UpdateOvjectName();

        }
        GetColor();
        DisableLabe();
    }

    void GetColor() {
        if (waipon.isconvert)
        {

            label.color = defaultColor;

        }
        else { label.color = blockColor; }

      
    }

    void DisableLabe() {

        if (Input.GetKey(KeyCode.C))
        {
            label.enabled=!label.IsActive();

        }
        

    }

    void DirCoordenadas()
    {
        coordenadas.x = Mathf.RoundToInt(transform.parent.position.x/UnityEditor.EditorSnapSettings.move.x);
        coordenadas.y = Mathf.RoundToInt(transform.parent.position.z/ UnityEditor.EditorSnapSettings.move.z);//UnityEditor.EditorSnapSettings.move.y es = 10

        
        label.text = (coordenadas.x+" , "+coordenadas.y);

        
    }


    void UpdateOvjectName() {

        transform.parent.name = coordenadas.ToString();
    
    }
}
