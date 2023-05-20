using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject target;

    public float spawnTime = 0.0f;
    public float bulletForce = 3.0f;
    public float targetSpeed = 0.0f;

    private float currentTime = 0.0f;

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= spawnTime)
        {
            //spawn a bullet
            Vector3 spawnPosition = transform.position + transform.forward * 1.1f;
            GameObject bullet = GameObject.Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletForce);

            currentTime = 0.0f;
        }

        float rotationStep = targetSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, target.transform.position, targetSpeed, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}

