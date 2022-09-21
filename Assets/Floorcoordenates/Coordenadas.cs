using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]

public class Coordenadas : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordenadas = new Vector2Int();
    // Update is called once per frame


    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DirCoordenadas();
        
    }
    void Update()
    {

        if (!Application.isPlaying) {

            DirCoordenadas();
            UpdateOvjectName();

        }
    }

    void DirCoordenadas()
    {
        coordenadas.x = Mathf.RoundToInt(transform.parent.position.x/UnityEditor.EditorSnapSettings.move.x);
        coordenadas.y = Mathf.RoundToInt(transform.parent.position.z/ UnityEditor.EditorSnapSettings.move.y);//UnityEditor.EditorSnapSettings.move.y es = 10

        label.text = (coordenadas.x+" , "+coordenadas.y);

        
    }


    void UpdateOvjectName() {

        transform.parent.name = coordenadas.ToString();
    
    }
}
