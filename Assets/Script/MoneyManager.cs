using System;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }

    private event EventHandler MoneyIncreaseOnClick;

    [SerializeField] TextMeshProUGUI totalMoney_Txt;

    private int totalMoney = 0;

    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        totalMoney_Txt.text = "$" + totalMoney.ToString();
        MoneyIncreaseOnClick += OnMoneyIncress;
        
    }

    private void OnDisable()
    {
        MoneyIncreaseOnClick -= OnMoneyIncress;
    }

   public int GetCurrentMoney()
    {
        return totalMoney;
    }

    private void OnMoneyIncress(object sender, EventArgs e)
    {
        totalMoney += 1;
        totalMoney_Txt.text = "$" + totalMoney.ToString();
    }

    public void MoneyIncressEvent()
    {
        MoneyIncreaseOnClick?.Invoke(this, EventArgs.Empty);
    }

}
