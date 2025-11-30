using System.Collections.Generic;
using UnityEngine;

public enum PanelName
{
    UpgradePanel,
    GameListPanel,

}

[System.Serializable]
public class GamePanelData
{
    public GameObject panelObject;
    public PanelName panelName;
}


public class PanelManager : MonoBehaviour
{
 
    [SerializeField] private List<GamePanelData> _gamePanels;

    public void ShowPanel(PanelName gamePanelName)
    {
        _gamePanels.Find(panel => panel.panelName == gamePanelName).panelObject.SetActive(true);
    }

    public void HidePanel(PanelName gamePanelName)
    {
        _gamePanels.Find(panel => panel.panelName == gamePanelName).panelObject.SetActive(false);
    }

}
