using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;

    public float fireRate = 1;
    private float nextTime;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextTime)
        {
            nextTime = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
