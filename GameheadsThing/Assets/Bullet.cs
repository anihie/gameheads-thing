using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {

    }
    private void OnCollisionExit(Collision collision)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }

}

