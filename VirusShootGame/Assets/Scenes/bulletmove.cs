using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    private float DestroyTime;
    void Start()
    {
        
    }

    void Update()
    {
        DestroyTime += Time.deltaTime;
        transform.position += new Vector3(0, 0, 1);
        if (DestroyTime >= 5)
        {
            Destroy(gameObject);
        }
    }
}
