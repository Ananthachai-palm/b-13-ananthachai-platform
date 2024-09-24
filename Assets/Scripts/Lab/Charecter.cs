using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Charecter : MonoBehaviour
{
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set 
        {
            _health = value;
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

}
