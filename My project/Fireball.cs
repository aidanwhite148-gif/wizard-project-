csharp Assets\Fireball.cs
using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour
{
    [Header("bullet variables")]
    public float bulletspeed = 20f;
    public float firerate, bulletDamage;
    public bool isAuto;
    public GameObject firePoint;
    public GameObject bullet;

    [Header("initial Setup")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

    private void Update()
    {
        if (isAuto)
        {
            if (Input.GetButtonDown("fire"))
            {
                // handle auto fire if needed
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

    // made public so other controllers can call it
    public void FireballFunc()
    {
        if (bulletPrefab == null || bulletSpawnTransform == null) return;

        Rigidbody rb = Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletSpawnTransform.rotation)
                         .GetComponent<Rigidbody>();
        if (rb != null)
        {
            // use configured speed and spawn transform forward
            rb.AddForce(bulletSpawnTransform.forward * bulletspeed, ForceMode.Impulse);
        }
    }
}

public class CooldownController : MonoBehaviour
{
    public float attackCooldown = 2f; // Cooldown duration in seconds
    private bool canAttack = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {
            Attack();
            StartCoroutine(Cooldown());
        }
    }

    void Attack()
    {
        // Call Fireball.Spawn
        Fireball fb = FindObjectOfType<Fireball>();
        if (fb != null)
        {
            fb.FireballFunc();
        }
        else
        {
            Debug.LogWarning("No Fireball component found in scene.");
        }

        Debug.Log("Attack!");
    }

    IEnumerator Cooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}