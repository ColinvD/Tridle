using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{

    private Character player;

    void Start()
    {
        player = FindObjectOfType<Character>();
    }

    private void OnMouseDown()
    {
        Vector2Int temp = new Vector2Int((int)transform.position.x, (int)transform.position.y);
        player.PointToPointMove(temp);
    }

}
