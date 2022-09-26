using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMove : MonoBehaviour
{

    [SerializeField] List<WayPint> coordinates = new List<WayPint>();
    [SerializeField] [Range (0f,5f)]float speed=1f;
    Enemy penalEnemy;
   

    // Start is called before the first frame update
    void OnEnable()
    {
        FinPath();
        StarPath();
        StartCoroutine(WathCoor());
       

    }


    private void Start()
    {
        penalEnemy = GetComponent<Enemy>();
    }

    void StarPath()
    {
        transform.position = coordinates[0].transform.position;
    }

    //for the movement of square

    void FinPath()
    {

        coordinates.Clear();

        GameObject parent = GameObject.FindGameObjectWithTag("Path");

        foreach (Transform child in parent.transform)
        {
            WayPint waipoint = child.GetComponent<WayPint>();
            if (waipoint!=null) { 
            coordinates.Add(waipoint); ;
        } }
    }



    void FindPath() {

        penalEnemy.Penalenemy();
        gameObject.SetActive(false);


    }

    IEnumerator WathCoor() {

        foreach (WayPint warpoint in coordinates) {

            Vector3 starPosition = transform.position;
            Vector3 endPosition = warpoint.transform.position;
            float interval=0;

            transform.LookAt(endPosition);

            while (interval < 1) 
            
            {

                interval += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(starPosition,endPosition,interval);


                yield return new WaitForEndOfFrame();
                    
            
            }
            

          
        }

        FindPath();


    }
   
}
