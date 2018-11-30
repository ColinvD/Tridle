using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : IPlaceable, IHarvestable, IUpdateable
{
    private IHarvestable _damageable;
    private IPlaceable _placeable;
    private IUpdateable _updateable;

    public Building(IHarvestable ID, IPlaceable IP, IUpdateable IU)
    {
        _damageable = ID;
        _placeable = IP;
        _updateable = IU;
    }

    public void Damage(float amount)
    {
        _damageable.Damage(amount);
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