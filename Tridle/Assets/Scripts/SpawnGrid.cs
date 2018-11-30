using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour
{
    [SerializeField]
    GameObject tilePrefab;

    [SerializeField]
    int width;
    [SerializeField]
    int height;


    Grid _grid;
	void Start()
    {
        _grid = new Grid(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                _grid[i, j] = Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity).AddComponent<Tile>();
                _grid[i, j].Reset();
            }
        }

    }
}
