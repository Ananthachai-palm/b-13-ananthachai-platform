using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTimer;

    private void Update()
    {
        bulletTimer -= Time.deltaTime;

        Behaviour();

        if (IsReadyToShoot())
        {
            bulletTimer = bulletSpawnTime;
        }
    }
    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (IsReadyToShoot())
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
    private bool IsReadyToShoot()
    {
        return (bulletTimer <= 0f);
    }
}
