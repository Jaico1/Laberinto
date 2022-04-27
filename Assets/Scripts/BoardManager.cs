using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static BoardManager Instance;
    
    public Cell CellPrefab;
    public Player player;
    public List<Cell> cells;



    public void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GenerateBoard(10, 10);
        Instantiate(player, new Vector2(0,0), Quaternion.identity);
        
    }

    public void GenerateBoard(int Height, int Width)
    {

        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var c = new Vector2(i, j);
                cells.Add(Instantiate(CellPrefab, c, Quaternion.identity));
                
            }
        }
        
        var center = new Vector2((float)Width / 2 - 0.5f, (float)Height / 2 - 0.5f);
        Camera.main.transform.position = new Vector3(center.x, center.y, -20); 

        assignNeighbors();
    }

    public void assignNeighbors()
    {
        foreach (Cell c in cells)
        {
            
            foreach (Cell cin in cells)
            {
                bool Der = cin.x == c.x + 1 && cin.y == c.y;
                bool Izq = cin.x == c.x - 1 && cin.y == c.y;
                bool Up = cin.y == c.y + 1 && cin.x == c.x;
                bool Down = cin.y == c.y - 1 && cin.x == c.x;
                

                if (Der)
                {
                    c.rightNeighbor = cin;
                    
                }

                if (Izq)
                {
                    c.leftNeighbor = cin;
                }

                if (Up)
                {
                    c.upNeighbor = cin;
                }

                if (Down)
                {
                    c.downNeighbor = cin;
                }
            }
        }
    }
    
}
