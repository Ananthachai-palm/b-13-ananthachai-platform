using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    public float BulletTimer { get; set; }

    private void Start()
    {
        BulletTimer = 0.0f;
    }
    private void Update()
    {
        Shoot();
    }
    private void FixedUpdate()
    {
        BulletTimer -= Time.deltaTime;
        if (IsReadyToShoot())
        {
            BulletTimer = BulletSpawnTime;
        }
    }
    private bool IsReadyToShoot()
    {
        return (BulletTimer <= 0f);
    }
    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && IsReadyToShoot())
        {
            GameObject bulletObject = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Destroy (bulletObject, 2f);

            BulletTimer = BulletSpawnTime;
        }
    }
}
