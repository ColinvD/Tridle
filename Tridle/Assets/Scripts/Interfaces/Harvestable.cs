using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvestable : IHarvestable
{
    private float _health;

    private ResourceType _resource;
    private float _value;

    public Harvestable(float health, ResourceType resource, float value)
    {
        _value = value;
        _resource = resource;
        _health = health;
    }

    public void Damage(float amount)
    {
        _health -= amount;
        if(_health <= 0)
        {
            ResourceHandler.Instance.GetResource(_resource).Amount += _value;
            //die
        }
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
