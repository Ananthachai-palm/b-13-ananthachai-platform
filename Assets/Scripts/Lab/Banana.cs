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
        Move();
    }

    // Override Behavior
    public override void Move()
    {
        Debug.Log("Banana moves with constant speed using Transform");
    }
    public override void OnHitWith(Character inputChar)
    {

    }
}
