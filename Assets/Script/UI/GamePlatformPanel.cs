using TMPro;
using UnityEngine;

public class GamePlatformPanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gamePlatform;
    [SerializeField] GameObject nextPanel;

    public void NextPanel()
    {
        CreateGameData.gamePlatform = gamePlatform.options[gamePlatform.value].text;
        nextPanel.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
