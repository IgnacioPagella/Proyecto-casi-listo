using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;


public class Playersiguecam : MonoBehaviour
{
    Camera cam;
    Collider planecollider;
    RaycastHit hit;
    Ray ray;


    void Start()
    {
        if (photonView.IsMine == true)
        {
            cam = Camera.main;
            planecollider = GameObject.Find("Plane").GetComponent<Collider>();
        }

    }


    void Update()
    {
      
        
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider != planecollider)
            {


                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 5);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }

        }


    }
}
//}