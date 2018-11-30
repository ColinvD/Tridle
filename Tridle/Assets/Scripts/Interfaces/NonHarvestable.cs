using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonHarvestable : IHarvestable
{
    public void Damage(float amount)
    {

    }

    public float GetHealth()
    {
        return 0;
    }

    public float GetHealthFraction()
    {
        return 1;
    }
}
