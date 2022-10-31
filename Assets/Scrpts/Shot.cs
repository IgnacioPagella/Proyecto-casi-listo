using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Shot : MonoBehaviour
{
    public GameObject bullet;

    public Transform spawnPoint;

    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    Shot planelife;

    Inventar tamanio;

    public int VidaAvioneta = 0;

    void Update()
    {
        if (VidaAvioneta <= 0)
        {
            Destroy(gameObject);
            PhotonNetwork.LoadLevel("Lobby");
        }

        //planelife = GameObject.FindGameObjectWithTag("Player").GetComponent<Shot>();

        //tamanio = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventar>();


        if (VidaAvioneta > 100 && Input.GetKey(KeyCode.Mouse0))
        {



            if (Time.time > shotRateTime)
            {
                Debug.Log("Recibe Disparo");
                GameObject newBullet;
                newBullet = PhotonNetwork.Instantiate(bullet.name, spawnPoint.position, spawnPoint.rotation);
                shotRateTime = Time.time + shotRate;

                
                transform.localScale -= new Vector3(x: 0.05f, y: 0f, z: 0.05f);


                VidaAvioneta = VidaAvioneta - 1;

                tamanio.tamaño -= 1;

            }

        }
    }
}


