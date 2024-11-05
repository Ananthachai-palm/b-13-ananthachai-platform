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
        Damage = 40;
        force = new Vector2 (5 * GetShootDirection(), 200);
        Move();
    }

    // Override Behavior
    public override void Move()
    {
        Debug.Log("Rock move with Rigidbody:force");
    }
    public override void OnHitWith(Character inputChar)
    {

    }
}
