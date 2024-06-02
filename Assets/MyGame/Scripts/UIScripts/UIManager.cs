using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //public TextMeshProUGUI textFuel;
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textRound;
    [SerializeField]private TextMeshProUGUI textFuel;
    // Start is called before the first frame update
    void Start()
    {
        textCoin.text = DataManager.DataCoin.ToString();
        textFuel.text = DataManager.DataFuel.ToString();
        
        GameManager.Instance.CoinEvent.AddListener(UpdateCoin);
        GameManager.Instance.RoundEvent.AddListener(UpdateRound);
        GameManager.Instance.FuelEvent.AddListener(UpdateFuel);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateCoin(int coin)
    {
        if(textCoin != null)
        {
            textCoin.text = coin.ToString();
        }
    }
    /*void UpdateFuel()
    {
        int fuel = GameManager.instance.GetFuel();
        textFuel.text = fuel.ToString();
    }*/
    void UpdateRound(int round)
    {
        if(textRound != null)
        {
            textRound.text = round.ToString();

        }
    }
    void UpdateFuel(int fuel)
    {
        if(textFuel != null)
        {
            textFuel.text = fuel.ToString();
        }
    }
    
}
