using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Placeable : MonoBehaviour, IPlaceable
{
    private float speed;

    public Vector2Int GetLocation()
    {
        return new Vector2Int(0, 0);
    }

    public float GetSpeedMultiplier()
    {
        return speed;
    }
}