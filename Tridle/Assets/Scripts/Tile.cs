using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public IPlaceable placeable;
    public float grass;
    public IPlaceable z;
    public IUpdateable x;
    //Shrubbery

    public Sprite[] sprites;

    public float MoveDiviculty()
    {
        return 3;
    }

    public Vector2Int GetLocation()
    {
        return new Vector2Int(0, 0);
    }

    public void UpdateGrassGrow()
    {

    }
}
