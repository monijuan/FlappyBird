using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    Rigidbody rig;
    public float force = 200;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rig.AddForce(Vector3.up * force);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Die"))
        {
            Debug.Log("you are die");
            gameObject.SetActive(false);
        }
    }
}
