using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlechita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<siguejugador>().player = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
