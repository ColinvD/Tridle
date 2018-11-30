using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : Building
{
    public Path(Sprite[] sprites) : base(new NonHarvestable())
    {
        Debug.Log("placed a path");
    }
}
