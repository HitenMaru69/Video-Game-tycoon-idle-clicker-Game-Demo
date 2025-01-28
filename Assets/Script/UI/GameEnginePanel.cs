using TMPro;
using UnityEngine;

public class GameEnginePanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gameEngineName;
    [SerializeField] GameObject nextPanel;

    public void NextPanel()
    {
        CreateGameData.gameEngine = gameEngineName.options[gameEngineName.value].text;
        nextPanel.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
