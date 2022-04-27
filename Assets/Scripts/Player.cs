using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public Cell currentCell;
    public List<Cell> cells;

    void Start()
    {




    }
    public void Awake()
    {
        cells = BoardManager.Instance.cells;

        foreach (Cell c in cells)
        {
            if (c.x ==0 && c.y==0)
            {
                currentCell = c;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(upKey) && currentCell.upNeighbor.isWalkable)
        {
            GetComponent<Transform>().position = new Vector3(currentCell.upNeighbor.x, currentCell.upNeighbor.y, 0);
            currentCell = currentCell.upNeighbor;

        }
        else if (Input.GetKeyDown(downKey))
        {
            GetComponent<Transform>().position = new Vector3(currentCell.downNeighbor.x, currentCell.downNeighbor.y, 0);
            currentCell = currentCell.downNeighbor;
        }
        else if (Input.GetKeyDown(rightKey))
        {
            GetComponent<Transform>().position = new Vector3(currentCell.rightNeighbor.x, currentCell.rightNeighbor.y, 0);
            currentCell = currentCell.rightNeighbor;
        }
        else if (Input.GetKeyDown(leftKey))
        {
            GetComponent<Transform>().position = new Vector3(currentCell.leftNeighbor.x, currentCell.leftNeighbor.y, 0);
            currentCell = currentCell.leftNeighbor;
        }
    }
}
