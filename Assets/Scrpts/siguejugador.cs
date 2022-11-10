using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguejugador : MonoBehaviour
{
    public Transform player;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Vector3.up * offset;

    }
}
