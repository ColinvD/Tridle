using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : IDamageable
{
    public void Damage(float amount)
    {

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
