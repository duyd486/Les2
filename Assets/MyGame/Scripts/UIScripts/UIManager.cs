using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //public TextMeshProUGUI textFuel;
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textRound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateValue());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateCoin()
    {
        int coin = GameManager.instance.GetCoin();
        textCoin.text = coin.ToString();
    }
    /*void UpdateFuel()
    {
        int fuel = GameManager.instance.GetFuel();
        textFuel.text = fuel.ToString();
    }*/
    void UpdateRound()
    {
        int round = GameManager.instance.GetRound();
        textRound.text = round.ToString();
    }
    IEnumerator UpdateValue()
    {
        for(; ; )
        {
            yield return new WaitForSeconds(0.5f);
            UpdateCoin();
            //UpdateFuel();
            UpdateRound();
        }
    }
}
