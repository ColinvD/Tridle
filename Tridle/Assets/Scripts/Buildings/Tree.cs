using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Building
{


    public Tree(float health, float value) : base(new Harvestable(health), new Sprite[0])
    {
        Debug.Log("spawned a tree");
    }
}
