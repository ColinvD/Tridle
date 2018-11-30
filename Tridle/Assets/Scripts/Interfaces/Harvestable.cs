using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvestable : IHarvestable
{
    private float _health;

    public Harvestable(float health)
    {
        _health = health;
    }

    public void Damage(float amount)
    {
        _health -= amount;
        if(_health <= 0)
        {
            //die
        }
    }
}
