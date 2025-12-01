using System;
using System.Diagnostics;
using UnityEngine;


public class Fireball : MonoBehaviour
{
    [Header("bullet variables")]
    public float bulletspeed;
    public float firerate, bulletDamage;
    public bool isAuto;
    public GameObject firePoint;
    public GameObject bullet;

    [Header("initial Setup")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

    [System.Obsolete]
    private void Update()
    {
        if (isAuto)
        {
            if (Input.GetButtonDown("fire"))
            {

            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                FireballFunc();
            }

        }
    }


    private void FireballFunc()
    {
        Rigidbody rb = Instantiate(bulletPrefab, bulletSpawnTransform.position , bulletSpawnTransform.rotation).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward *20, ForceMode.Impulse);

    }


}


