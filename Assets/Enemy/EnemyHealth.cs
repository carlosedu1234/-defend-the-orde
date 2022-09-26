using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxlife=2;
    [SerializeField] int increaseDificult = 1;
     int hitPoints = 0;
    Enemy deadEnemy;
    private void OnEnable()
    {
        hitPoints = maxlife;
    }

    private void Start()
    {
        deadEnemy = GetComponent<Enemy>();
    }

    private void OnParticleCollision(GameObject other)
        
    {
        
        PhMax();
    }


    void PhMax() {

        hitPoints--;

        if (hitPoints < 1) {

            maxlife += increaseDificult;
            gameObject.SetActive(false);
            deadEnemy.Ribenemy();

        }
    
    }


}
