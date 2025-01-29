using System.ComponentModel;
using TMPro;
using UnityEngine;

enum GamePlatform
{
    Mobile,
    PC,
    PlayStation
}
public class GamePlatformPanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gamePlatform;
    [SerializeField] GameObject nextPanel;

    [SerializeField] int mobileTime;
    [SerializeField] int pcTime;
    [SerializeField] int playStationTime;

    private GamePlatform gamePlatformEnum;

    public void NextPanel()
    {
        CreateGameData.gamePlatform = gamePlatform.options[gamePlatform.value].text;
        gamePlatformEnum = (GamePlatform)gamePlatform.value;
        AddTimeAccrodingToGamePlatform();
        nextPanel.SetActive(true);
        this.gameObject.SetActive(false);
    }

    void AddTimeAccrodingToGamePlatform()
    {
        switch (gamePlatformEnum)
        {
            case GamePlatform.Mobile:
                CreateGameData.gameCreateTime += mobileTime;
                break;

            case GamePlatform.PC:
                CreateGameData.gameCreateTime += pcTime;
                break;

            case GamePlatform.PlayStation:
                CreateGameData.gameCreateTime += playStationTime;
                break;


        }
    }
}
