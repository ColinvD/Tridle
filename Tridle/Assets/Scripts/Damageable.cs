using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : IDamageable
{
    private float _health;

    private ResourceType _resource;
    private float _value;

    public Damageable(float health, ResourceType resource, float value)
    {
        _value = value;
        _resource = resource;
        _health = health;
    }

    public bool Damage(float amount)
    {
        _health -= amount;
        if(_health <= 0)
        {
            ResourceHandler.Instance.GetResource(_resource).Amount += _value;
            //die
        }
        return true;
    }

    public float GetHealth()
    {
        return 1;
    }

    public float GetHealthFraction()
    {
        return 0.5f;
    }
}
