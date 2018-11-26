using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlaceable
{
    Vector2Int GetLocation();
    float GetSpeedMultiplier();
}
