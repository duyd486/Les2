using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int fuel = 0;
    public static GameManager instance;
    private int roundNumber = 0;
    private int coinNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetFuel(int fuel)
    {
        this.fuel += fuel;
    }
    public void SetRound(int roundNumber)
    {
        this.roundNumber += roundNumber;
    }
    public void SetCoin(int coinNumber)
    {
        this.coinNumber += coinNumber;
    }
    public int GetCoin()
    {
        return coinNumber;
    }
    public int GetFuel()
    {
        return fuel;
    }
    public int GetRound()
    {
        return roundNumber;
    }
}
