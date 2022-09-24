using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetenemy : MonoBehaviour
{

    [SerializeField] Transform waypint;
    [SerializeField] Transform target;
    // Start is called before the first frame update
    
    void Start()
    {
       target = FindObjectOfType<Enemy>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        waypint.LookAt(target);
    }
}
