using UnityEngine;

public class Fireball : MonoBehaviour
{
    [Header("bullet variables")]
    public float bulletspeed;
    public float firerate, bulletDamage;
    public bool isAuto;

    [Header("initial Setup")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

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
            if (Input.GetButtonDown("fire"))
            {
                Shoot();
            }

        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.parent.position, Quaternion.identity);
    }
}