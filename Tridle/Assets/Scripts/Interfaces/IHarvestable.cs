using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHarvestable
{
    void Damage(float amount);
    bool AbleHarvest();
}
