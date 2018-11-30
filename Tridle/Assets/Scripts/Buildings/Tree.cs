using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Building
{


    public Tree(float health, float value, GameObject placeholder) : base(new Harvestable(health))
    {
        base.placeholder = placeholder;
        Debug.Log("spawned a tree");
    }
}
