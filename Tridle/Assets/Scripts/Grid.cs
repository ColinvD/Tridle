using System;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]
    GameObject tilePrefab;
    [SerializeField]
    GameObject treePrefab;
    private Tile[,] _grid;

    public void Start()
    {
        ResizeGrid(10, 10);
        _grid[4, 4].building = new Tree(10,10,Instantiate(treePrefab, new Vector3(4, 4, 0), Quaternion.identity));
    }


    public Tile[,] Array
    {
        get { return _grid; }
    }

    public int Width
    {
        get { return _grid.GetLength(0); }
    }

    public int Height
    {
        get { return _grid.GetLength(1); }
    }

    public Tile this[int x, int y]
    {
        get { return GetNode(x, y); }
        set { SetNode(value, x, y); }
    }
    public Tile this[Vector2Int pos]
    {
        get { return GetNode(pos); }
        set { SetNode(value, pos); }
    }

    public Tile GetNode(Vector2Int node)
    {
        return GetNode(node.x, node.y);
    }
    public Tile GetNode(int x, int y)
    {
        if (x > Width - 1 || y > Height - 1 || x < 0 || y < 0)
            return null;
        return _grid[x, y];
    }

    public void SetNode(Tile newNode, Vector2Int node)
    {
        SetNode(newNode, (int)node.x, (int)node.y);
    }
    public void SetNode(Tile newNode, int x, int y)
    {
        if (x > Width - 1 || y > Height - 1 || x < 0 || y < 0) { return; }
        _grid[x, y] = newNode;
    }

    public Vector2Int FindObject(Tile obj)
    {
        for (int x = 0; x < Array.GetLength(0); x++)
        {
            for (int y = 0; y < Array.GetLength(1); y++)
            {
                if (GetNode(x, y) == obj)
                    return new Vector2Int(x, y);
            }
        }
        return new Vector2Int(-1, -1);
    }

    public Vector2Int[] GetNeighboursPositions(int x, int y, bool crosswise = true)
    {
        return GetNeighboursPositions(new Vector2Int(x, y), crosswise);
    }
    public Vector2Int[] GetNeighboursPositions(Vector2Int nodePosition, bool crosswise = true)
    {
        List<Vector2Int> neighbours = new List<Vector2Int>();
        for (int x = -1; x < 2; x++)
        {
            for (int y = -1; y < 2; y++)
            {

                if ((!crosswise && (y == 1 || y == -1) && (x == 1 || x == -1)) ||
                    x == 0 && y == 0)
                    continue;

                var position = new Vector2Int(x, y) + nodePosition;

                if (position.x > Width - 1 || position.y > Height - 1 || position.x < 0 || position.y < 0)
                    continue;

                neighbours.Add(position);
            }
        }
        return neighbours.ToArray();

    }

    public Tile[] GetNeighbours(int x, int y, bool crosswise = true)
    {
        return GetNeighbours(new Vector2Int(x, y), crosswise);
    }

    public Tile[] GetNeighbours(Vector2Int nodePosition, bool crosswise = true)
    {
        List<Tile> neighbours = new List<Tile>();
        var positions = GetNeighboursPositions(nodePosition, crosswise);
        for (int i = 0; i < positions.Length; i++)
        {
            Tile temp = GetNode(positions[i]);
            if (temp != null)
            {
                neighbours.Add(temp);
            }
        }
        return neighbours.ToArray();

    }

    public void ResizeGrid(int x, int y)
    {
        _grid = new Tile[x, y];
        
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                _grid[i, j] = Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity).AddComponent<Tile>();
                _grid[i, j].grid = this;
                _grid[i, j].Reset();
            }
        }
    }
    public void ResizeGrid(Vector2Int size)
    {
        ResizeGrid(size.x, size.y);
    }

    public void ResetPath()
    {
        for (var x = 0; x < Width; x++)
        {
            for (var y = 0; y < Height; y++)
            {
                _grid[x, y].Reset();
            }
        }
    }

    public List<Tile> FindPath(Vector2Int startPoint, Vector2Int endPoint, Func<Vector2, Vector2, float> heuristic = null)
    {
        return PathFinder.FindPath(startPoint, endPoint, this, heuristic);
    }
}
