using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMotion : MonoBehaviour
{
    public float tumble = 0.5f;
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    void Update()
    {
        
    }
}
