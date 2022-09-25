using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetenemy : MonoBehaviour
{
    [SerializeField] ParticleSystem ProyectilMateial;
    [SerializeField] Transform waypint;
    [SerializeField] float range=15f;
    Transform target;
    // Start is called before the first frame update
    
    void Update()
    {
        FinClosesTarget();
        AiWipon();
    }

    private void FinClosesTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closesTarget = null;
        float maxDistance = Mathf.Infinity; 

        foreach (Enemy enemy in enemies) {
            float tagetDistance = Vector3.Distance(transform.position, enemy.transform.position);

            
            if (tagetDistance < maxDistance) {

                closesTarget = enemy.transform;
                maxDistance = tagetDistance;
                
            
            }


        }
        target = closesTarget;
    }

    // Update is called once per frame
    void AiWipon()
    {
        float tagetDistance = Vector3.Distance(transform.position,target.position);
        waypint.LookAt(target);
        if (tagetDistance < range)
        {
            Atack(true);
        }
        else { Atack(false); }
    }

    void Atack(bool isActive) {

        var fire = ProyectilMateial.emission;
        fire.enabled = isActive;
    
    }

}
