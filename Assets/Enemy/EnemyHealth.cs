using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField][Range(1,20)] int maxlife=2;
    WayPint disable;
    
     void Update()
    {
        disable = GetComponent<WayPint>();
    }
    private void OnParticleCollision(GameObject other)
        
    {
        
        PhMax();
    }


    void PhMax() {

        maxlife--;

        if (maxlife<1) {

            
            Destroy(gameObject);
        
        }
    
    }


}
