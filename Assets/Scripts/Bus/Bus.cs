using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public int doors = 2;
    public Color color = Color.yellow;

    private void Awake()
    {
        init();
    }

    public void init()
    {
        BusBase myBus = new BusBase(4, Color.blue);
    }
}


public class BusBase
{
     public int doors = 2;
    public Color color = Color.yellow;
    public BusBase()
    {
        Debug.Log("Construtor");
    }

    public BusBase (int doors)
    {
        this.doors = doors;
    }
    public BusBase(int doors,Color color)
    {
        this.doors = doors;
        this.color = color;
    }
}