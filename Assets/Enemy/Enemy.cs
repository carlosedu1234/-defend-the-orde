using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] List<WayPint> coordinates = new List<WayPint>();
    [SerializeField] [Range (0f,5f)]float speed=1f;
   

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WathCoor());
    }

    //for the movement of squares
    IEnumerator WathCoor() {

        foreach (WayPint warpoint in coordinates) {

            Vector3 starPosition = transform.position;
            Vector3 endPosition = warpoint.transform.position;
            float interval=0;

            transform.LookAt(endPosition);

            while (interval < 1) {

                interval += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(starPosition,endPosition,interval);


                yield return new WaitForEndOfFrame();
                    
            
            }
            

        }
    }
   
}
