using TMPro;
using UnityEngine;

enum GameEngine
{
    Unity,
    Unreal,
    Godot
}

public class GameEnginePanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gameEngineName;
    [SerializeField] GameObject nextPanel;

    [SerializeField] int unityTime;
    [SerializeField] int unrealTime;
    [SerializeField] int goDotTime;

    private GameEngine gameEngineEnum;

    public void NextPanel()
    {
        CreateGameData.gameEngine = gameEngineName.options[gameEngineName.value].text;
        gameEngineEnum = (GameEngine)gameEngineName.value;
        AddTimeAccrodingToGameEngine();
        nextPanel.SetActive(true);
        gameEngineName.value = 0;
        this.gameObject.SetActive(false);
    }

    void AddTimeAccrodingToGameEngine()
    {
        switch (gameEngineEnum)
        {
            case GameEngine.Unity:
                CreateGameData.gameCreateTime += unityTime;
                break;

            case GameEngine.Unreal:
                CreateGameData.gameCreateTime += unrealTime;
                break;

            case GameEngine.Godot:
                CreateGameData.gameCreateTime += goDotTime;
                break;


        }
    }
}
