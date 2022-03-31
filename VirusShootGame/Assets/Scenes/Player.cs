using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed * Time.deltaTime;
    }
}
