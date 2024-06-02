
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScriptableManager : MonoBehaviour
{
    public Sword[] dataSword;

    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI id;

    private void Start()
    {
        OnClickButton();
    }

    public void OnClickButton()
    {
        Sword sword;
        sword = dataSword[Random.Range(0, dataSword.Length)];
        image.sprite = sword.icon;
        id.text = sword.id.ToString();
        name.text = sword.name.ToString();
    }


}
