using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof ( MeshRenderer))]
public class MapScroller : MonoBehaviour
{
    public float HorizSpeed = 1.0f;
    public float VertSpeed = 1.0f;

    public float HorizUVMin = 1.0f;
    public float HorizUVMax = 2.0f;

    public float VertUVMin = 1.0f;
    public float VertUVMax = 2.0f;

    private MeshRenderer MeshR = null;

    void Awake()
    {
        MeshR = GetComponent<MeshRenderer>();
    }
    void Start()
    {

    }

    void Update()
    {
        Vector2 offset = new Vector2(/*(MeshR.material.mainTextureOffset.x >
            HorizUVMax) ? HorizUVMin : MeshR.material.mainTextureOffset.x +
            Time.deltaTime * HorizSpeed*/0,
                                        (MeshR.material.mainTextureOffset.y > 
                                        VertUVMax) ? VertUVMin : MeshR.material.mainTextureOffset.y
            + Time.deltaTime * VertSpeed);

        MeshR.material.mainTextureOffset = offset;
    }
}
