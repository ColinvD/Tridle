using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : IHarvestable
{
    public float moveDifficulty;

    private IHarvestable _harvestable;

    private Sprite[] _sprite;

    public Building(IHarvestable ID, Sprite[] sprite)
    {
        _sprite = sprite;
        _harvestable = ID;
    }

    public void Damage(float amount)
    {
        _harvestable.Damage(amount);
    }
}