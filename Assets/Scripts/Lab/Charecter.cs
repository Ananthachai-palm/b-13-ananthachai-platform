using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Charecter : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set 
        {
            health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rB;

    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    public void Init(int newHealth)
    {
        Health = newHealth;
    }

}
