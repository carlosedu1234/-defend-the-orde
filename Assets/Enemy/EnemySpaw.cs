using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaw : MonoBehaviour
{
    [SerializeField] GameObject enemys;
    [SerializeField] int poolsize = 5;
    [SerializeField] float timeSpaw = 2f;
    GameObject[] pool;

    // Update is called once per frame
    private void Awake()
    {
        PopulationPool();
    }

    void OnEnable()
    {
        StartCoroutine(SpawEnemys());

    }

    void PopulationPool()
    {
        pool = new GameObject[poolsize];
        for (int i = 0; i < pool.Length; i++) {

            pool[i] = Instantiate(enemys, transform);
            pool[i].SetActive(false);

        }

    }

    void OnEnableinPool(){

        for (int i = 0; i < pool.Length; i++)
        {
            if (pool[i].activeInHierarchy==false) {
                pool[i].SetActive(true);
                return;
            }
        }
        }

    


    IEnumerator SpawEnemys()
    {
        while (true)
        {
            OnEnableinPool();    
            yield return new WaitForSeconds(timeSpaw);
           
        }
    }
}
