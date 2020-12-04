using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    Material material;
    Vector2 offset;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    void Update()
    {
        material.SetTextureOffset("_MainTex", offset);
        offset.x -= Time.deltaTime;
        if (offset.x < -1)
            offset.x = 0;
    }

}
