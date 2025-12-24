using TMPro;
using UnityEngine;

public class GameListPrefeb : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gameNoText;
    [SerializeField] private TextMeshProUGUI _gameNameText;
    [SerializeField] private TextMeshProUGUI _gamePriceText;
    [SerializeField] private GameObject _buyButton;

    private float _gamePrice;

    public void SetGameListData(int gameNo,string gameName, float gameprize)
    {
        _gameNoText.text = gameNo.ToString();
        _gameNameText.text = gameName;
        _gamePriceText.text = "$" + gameprize.ToString();
        _gamePrice = gameprize;
    }
    
    
    
    public void BuyButtonClick()
    {
        float currentMoney = MoneyManager.Instance.GetCurrentMoney();

        if(currentMoney >= _gamePrice)
        {
            Debug.Log("Game Bought Successfully");
            EventManager.Instance.DeductMoney?.Invoke(new DeductMoneyEventArgs(_gamePrice));
            PanelManager.Instance.ShowPanel(PanelName.CreateGamePanel);
            PanelManager.Instance.ShowPanel(PanelName.GameNamePanel);
            PanelManager.Instance.HidePanel(PanelName.UpgradePanel);
            PanelManager.Instance.HidePanel(PanelName.GameListPanel);
        }
        else
        {
            Debug.Log("Not Enough Money To Buy This Game");
        }
    }
}
