using TMPro;
using UnityEngine;

enum GameCategory {

    Card,
    Hypercasual,
    Endless,
    Horror,
    Action
}

public class GameCategoryPanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gameCategory;
    [SerializeField] GameObject nextPanel;

    [SerializeField] int cardgameTime;
    [SerializeField] int hyperCasualgameTime;
    [SerializeField] int endlessgameTime;
    [SerializeField] int horrogameTime;
    [SerializeField] int actiongameTime;
    

    private GameCategory gameCategoryEnum;
    public void NextPanel()
    {
        CreateGameData.gameCategory = gameCategory.options[gameCategory.value].text;
        gameCategoryEnum = (GameCategory)gameCategory.value;
        AddTimeAccrodingToGameCatagory();
        //nextPanel.SetActive(true);
        //this.gameObject.SetActive(false);

        Debug.Log("Total game time " + CreateGameData.gameCreateTime);


    }

    void AddTimeAccrodingToGameCatagory()
    {
        switch (gameCategoryEnum)
        {
            case GameCategory.Card:
                CreateGameData.gameCreateTime += cardgameTime;
                break;

            case GameCategory.Hypercasual:
                CreateGameData.gameCreateTime += hyperCasualgameTime;
                break;

            case GameCategory.Endless:
                CreateGameData.gameCreateTime += endlessgameTime;
                break;

            case GameCategory.Horror:
                CreateGameData.gameCreateTime += horrogameTime;
                break;

            case GameCategory.Action:
                CreateGameData.gameCreateTime += actiongameTime;
                break;


        }
    }
}
