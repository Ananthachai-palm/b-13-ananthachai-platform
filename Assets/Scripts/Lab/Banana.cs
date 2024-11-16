using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    // Attribute
    [SerializeField] private float speed;

    // Init in Start method
    private void Start()
    {
        speed = 5f * GetShootDirection();
    }
    private void FixedUpdate()
    {
        Move();
    }

    // Override Behavior
    public override void Move()
    {
        Vector2 newPosistion = new Vector2(transform.position.x + speed 
                                           * Time.fixedDeltaTime, transform.position.y);
        transform.position = newPosistion;
    }
    public override void OnHitWith(Character inputChar)
    {
        if (inputChar is Enemy)
        {
            inputChar.TakeDamage(Damage);
        }
    }
}
