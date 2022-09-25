using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxlife=2;
    [SerializeField] int hitPoints = 0;

    private void OnEnable()
    {
        hitPoints = maxlife;
    }

    private void OnParticleCollision(GameObject other)
        
    {
        
        PhMax();
    }


    void PhMax() {

        hitPoints--;

        if (hitPoints < 1) {


            gameObject.SetActive(false);

        }
    
    }


}
