using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTube : MonoBehaviour
{
    public float timeDelta = 2f;
    float timer = 2f;
    public GameObject prefab;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>timeDelta)
        {
            timer = 0;
            var go = Instantiate(prefab);
            go.transform.position = new Vector3(8, 0, 20);
        }
    }
}
