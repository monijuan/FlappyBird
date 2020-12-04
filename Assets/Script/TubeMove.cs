using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMove : MonoBehaviour
{
    public float speed=10;
    public float maxLeft = -10f;

    Transform transform_;
    private void Start()
    {
        transform_ = transform;
    }
    private void Update()
    {
        transform_.Translate(Vector3.left * speed * Time.deltaTime);
        //Debug.Log(Time.deltaTime);
        if (transform_.position.x<maxLeft)
        {
            Destroy(gameObject);
        }
    }
    
}
