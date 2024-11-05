using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy , IShootable
{
    [SerializeField] private float attackRange;
    public Player player;

    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    public float BulletTimer { get; set; }


    private void Update()
    {
        BulletTimer -= Time.deltaTime;

        Behaviour();

        if (IsReadyToShoot())
        {
            BulletTimer = BulletSpawnTime;
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

    public void Shoot()
    {
        if (IsReadyToShoot())
        {
            anim.SetTrigger("Shoot");
            GameObject bulletObject = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = bulletObject.GetComponent<Rock>();
            rock.Init(20, this);

            Destroy(bulletObject, 2f);

        }
    }
    private bool IsReadyToShoot()
    {
        return (BulletTimer <= 0f);
    }
}
