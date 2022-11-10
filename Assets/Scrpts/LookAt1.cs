using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt1 : MonoBehaviour
{
    public Transform look;
    void Update()
    {
        transform.forward=(look.position - transform.position).normalized;
    }
}
