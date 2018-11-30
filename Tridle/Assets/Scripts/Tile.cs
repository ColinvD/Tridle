using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Building building;
    public float grass;
    //Shrubbery

    public Sprite sprite;
    public Sprite[] grassSprites;

    public float G { get; set; }
    public float H { get; set; }
    public float F { get; set; }
    public Tile Parent { get; set; }

    public float MoveDifficulty()
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

    public void Reset()
    {
        G = 0;
        H = 0;
        F = 0;
        Parent = null;
    }
}
