using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    // Attribute
    private Rigidbody2D rb2d;
    private Vector2 force;

    // Init in Start method
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2 (2 * GetShootDirection(), 10);
        Move();
    }

    // Override Behavior
    public override void Move()
    {
        rb2d.AddForce (force, ForceMode2D.Impulse);
    }
    public override void OnHitWith(Character inputChar)
    {
        if (inputChar is Player)
        {
            inputChar.TakeDamage(Damage);
        }
    }
}
