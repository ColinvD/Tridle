using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
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
    public Vector2 location;
    private Sprite sprite;
    public int axeLevel;
    private Queue<Tile> path;
    private float walkSpeedTotal;

    public void Start()
    {
        path = new Queue<Tile>();
        walkSpeedTotal = 1;
    }

    /*public void PointToPointMove(Tree tree)
    {

    }*/
    public void PointToPointMove(Vector2Int loc)
    {
        path = new Queue<Tile>(grid.FindPath(Vector2Int.RoundToInt(location), loc, null));
    }

    /*public Tree FindClosestTree()
    {
        return new Tree();
    }*/

    private void Move()
    {
        if(path.Count == 1 && path.Peek().building != null && path.Peek().building.AbleHarvest())
        {

        }
        else
        {
            float moveSpeed = walkSpeedTotal / path.Peek().MoveDifficulty() * 1000;
            Vector2 direction = path.Peek().GetLocation() - location;
            if (moveSpeed < direction.magnitude)
            {
                direction.Normalize();
                location += direction * moveSpeed;
            }
            else
            {
                location = path.Peek().GetLocation();
                path.Dequeue();
            }
            gameObject.transform.position = location;
        }
    }

    private void Update()
    {
        if (path.Count != 0)
        {
            Move();
        }
    }

    /*public void Harvest(IPlaceable tree)
    {

    }
    public void Harvest(Vector2Int loc)
    {
        Harvest(grid[loc].placeable);
    }*/


}
