using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonHarvestable : IHarvestable
{
    public void Damage(float amount)
    {

    }
    
    public bool AbleHarvest()
    {
        return false;
    }
}
