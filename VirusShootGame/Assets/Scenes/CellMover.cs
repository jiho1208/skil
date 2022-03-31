using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMover : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 Direction = Vector3.zero;
    void Start()
    {
        
    }

    void Update()
    {
        Transform thisTransform = GetComponent<Transform>();
        thisTransform.position += Direction.normalized * speed * Time.deltaTime;
    }
}
