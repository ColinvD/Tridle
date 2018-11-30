using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHarvestable
{
    void Damage(float amount);
    float GetHealth();
    float GetHealthFraction();
}
