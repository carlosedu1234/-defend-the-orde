using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPint : MonoBehaviour
{
    [SerializeField] bool convert;
    [SerializeField] GameObject towers;
    GameObject parentTowers;
    public bool isconvert { get { return convert; } }

    public void Start()
    {
        parentTowers = GameObject.FindWithTag("parentTowers");
    }
    private void OnMouseDown()
    {
        if (convert==true) 
        {

            GameObject newTower= Instantiate(towers, transform.position, Quaternion.identity);
            newTower.transform.parent = parentTowers.transform;
            convert = false;

        }
    }
}
