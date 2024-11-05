using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{

    // Field, Propoty
    [SerializeField] private int damamge;
    public IShootable shooter;
    public int Damage
    {
        get
        {
            return damamge;
        }
        set
        {
            damamge = value;
        }
    }
    public void Init(int damage, IShootable owner)
    {
        this.damamge = damage;
        shooter = owner;
    }
    // Behavior
    public int GetShootDirection()
    {
        float shootDir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;
        if (shootDir > 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
    }
    // abstract
    public abstract void OnHitWith(Character inputChar);
    public abstract void Move();

}
