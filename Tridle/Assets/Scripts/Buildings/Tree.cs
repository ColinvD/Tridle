using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Building
{
    public Tree(float health, float value) : base(new Harvestable(health, ResourceType.Wood, value), new Placeable(), new Updateable())
    {
        Debug.Log("spawned a tree");
    }
}
