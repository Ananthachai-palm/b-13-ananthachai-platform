using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    // Field, Propoty
    [SerializeField] private int damamge;
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

    protected string owner;

    // Behavior
    public int GetShootDirection()
    {
        return 1;
    }

    // abstract
    public abstract void OnHitWith(Character inputChar);
    public abstract void Move();

}
