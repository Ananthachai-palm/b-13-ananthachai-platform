using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private HealthBarManager charHealthBar;
    public HealthBarManager CharHealthBar
    {
        get
        {
            return charHealthBar;
        }
    }
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
        return health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (!IsDead())
        {
            Debug.Log($"{name} take damage:{damage}, {name} Health: {Health}");
            charHealthBar.ReduceHealthBar(Health);
        }
        else
        {
            Debug.Log($"{name} Dead");
            Destroy(gameObject);
        }
    }
    public void Init(int newHealth)
    {
        Health = newHealth;
        charHealthBar.InitHealthBar(newHealth);
    }

}
