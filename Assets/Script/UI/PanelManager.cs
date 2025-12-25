using System.Collections.Generic;
using UnityEngine;

public enum PanelName
{
    UpgradePanel,
    GameListPanel,
    CreateGamePanel,
    GameNamePanel,
    GameEnginePanel,
    GamePlateFormPanel,
    GameCategoryPanel,
    CreateGameProgressPanel,
    HireEmployListPanel,

}

[System.Serializable]
public class GamePanelData
{
    public GameObject panelObject;
    public PanelName panelName;
}


public class PanelManager : MonoBehaviour
{
    public static PanelManager Instance {get; private set;}
 
    [SerializeField] private List<GamePanelData> _gamePanels;

    private void Awake()
    {
        Instance = this;
    }
    
    public void ShowPanel(PanelName gamePanelName)
    {
        _gamePanels.Find(panel => panel.panelName == gamePanelName).panelObject.SetActive(true);
    }

    public void HidePanel(PanelName gamePanelName)
    {
        _gamePanels.Find(panel => panel.panelName == gamePanelName).panelObject.SetActive(false);
    }

}
