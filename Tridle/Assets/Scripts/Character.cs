using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Grid grid;

    List<float> damageAdditive;
    List<float> damageMultipliers;
    List<float> chopSpeedAdditive;
    List<float> chopSpeedMultipliers;
    List<float> walkSpeedAdditive;
    List<float> walkSpeedMultipliers;
    List<float> stompingPowerAdditive;
    List<float> stompingPowerMultipliers;
    //MoveInput
    public Vector2Int location;
    private Sprite sprite;
    public int axeLevel;

    public void PointToPointMove(Tree tree)
    {

    }
    public void PointToPointMove(Vector2Int loc)
    {
        var openList = new List<Tile>();
        var closedList = new List<Tile>();
    }

    public Tree FindClosestTree()
    {
        return new Tree();
    }

    public void Harvest(IPlaceable tree)
    {

    }
    public void Harvest(Vector2Int loc)
    {
        Harvest(grid[loc].placeable);
    }


}
