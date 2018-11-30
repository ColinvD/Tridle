using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : Building
{
    public Path(float health, float value) : base(new NonHarvestable(), new Placeable(), new NonUpdateable())
    {
        Debug.Log("placed a path");
    }
}
