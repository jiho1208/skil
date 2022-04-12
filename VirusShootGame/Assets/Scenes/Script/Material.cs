using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Material : MonoBehaviour
{
    public float ymin;
    public float ymax;
    public float speed;

    MeshRenderer MeshR;
    void Start()
    {
        MeshR = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 offset = new Vector2(0, /*MeshR.material.mainTextureOffset.y > ymax ? ymin :*/
            MeshR.material.mainTextureOffset.y + Time.deltaTime * speed);
        MeshR.material.mainTextureOffset = offset;
    }
}
