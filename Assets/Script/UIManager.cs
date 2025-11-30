using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private PanelManager _panelManager;

    private void Awake()
    {
        Instance = this;
    }

    public void UpgradeButtonClick()
    {
        _panelManager.ShowPanel(PanelName.UpgradePanel);
        _panelManager.ShowPanel(PanelName.GameListPanel);
    }

    public void NewGameButtonClick()
    {
        _panelManager.ShowPanel(PanelName.GameListPanel);
    }

    public void HireEmployeButtonClick()
    {
        _panelManager.HidePanel(PanelName.GameListPanel);
    }

    public void CloseUpgradePanelButtonClick()
    {
        _panelManager.HidePanel(PanelName.GameListPanel);
        _panelManager.HidePanel(PanelName.UpgradePanel);
    }
}
