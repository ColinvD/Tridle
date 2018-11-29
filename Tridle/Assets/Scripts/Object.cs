using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : IPlaceable, IDamageable, IUpdateable
{
    private IDamageable _damageable;
    private IPlaceable _placeable;
    private IUpdateable _updateable;

    public Object(IDamageable ID, IPlaceable IP, IUpdateable IU)
    {
        _damageable = ID;
        _placeable = IP;
        _updateable = IU;
    }

    public bool Damage(float amount)
    {
        return _damageable.Damage(amount);
    }

    public float GetHealth()
    {
        return _damageable.GetHealth();
    }

    public float GetHealthFraction()
    {
        return _damageable.GetHealthFraction();
    }

    public void tick()
    {
        _updateable.tick();
    }

    public float GetSpeedMultiplier()
    {
        return _placeable.GetSpeedMultiplier();
    }

    public Vector2Int GetLocation()
    {
        return _placeable.GetLocation();
    }
}