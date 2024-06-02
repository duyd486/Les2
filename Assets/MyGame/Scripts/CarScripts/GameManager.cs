using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int fuel = 0;
    public UnityEvent<int> CoinEvent;
    public UnityEvent<int> RoundEvent;
    public UnityEvent<int> FuelEvent;

    private int roundNumber = 0;
    private int coinNumber = 0;
    private static GameManager instance;


    public static GameManager Instance
    {
        get => instance;
    }


    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(instance);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        if(CoinEvent == null)
        {
            CoinEvent = new UnityEvent<int>();
        }
        if(RoundEvent == null)
        {
            RoundEvent = new UnityEvent<int>();
        }
        if (FuelEvent == null)
        {
            FuelEvent = new UnityEvent<int>();
        }
        coinNumber = DataManager.DataCoin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetFuel(int fuel)
    {
        this.fuel += fuel;
        FuelEvent?.Invoke(this.fuel);
        DataManager.DataFuel = this.fuel;
    }
    
    public void SetRound(int roundNumber)
    {
        this.roundNumber += roundNumber;
        RoundEvent?.Invoke(this.roundNumber);
    }
    public void SetCoin(int coinNumber)
    {
        this.coinNumber += coinNumber;
        CoinEvent?.Invoke(this.coinNumber);
        DataManager.DataCoin = this.coinNumber;
    }
}
