using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{

    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(50);

        Behaviour();
    }

    private void FixedUpdate()
    {
        Behaviour();
    }
    public override void Behaviour()
    {
        rB.MovePosition(rB.position + velocity * Time.fixedDeltaTime);

        if (rB.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }
        else if (rB.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }
    }
    private void Flip()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;

        CharHealthBar.transform.localScale *= -1;
    }
}
