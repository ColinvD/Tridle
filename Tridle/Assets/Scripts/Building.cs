using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : IHarvestable
{
    public float moveDifficulty;

    private IHarvestable _harvestable;

    public GameObject placeholder;

    public Building(IHarvestable ID)
    {
        _harvestable = ID;
    }

    public void Damage(float amount)
    {
        _harvestable.Damage(amount);
    }

    public bool AbleHarvest()
    {
        return _harvestable.AbleHarvest();
    }
}