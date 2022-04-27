using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    
    public GameObject Inner;
    public Cell upNeighbor;
    public Cell downNeighbor;
    public Cell leftNeighbor;
    public Cell rightNeighbor;
    public bool isWalkable;
    public int x,y;
    
    void Start()
    {

    }
    public void Awake()
    {
        x = (int)GetComponent<Transform>().position.x;
        y = (int)GetComponent<Transform>().position.y;
        isWalkable = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
