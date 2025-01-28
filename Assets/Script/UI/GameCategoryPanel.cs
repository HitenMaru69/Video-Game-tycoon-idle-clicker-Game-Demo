using TMPro;
using UnityEngine;

public class GameCategoryPanel : MonoBehaviour
{
    [SerializeField] TMP_Dropdown gameCategory;
    [SerializeField] GameObject nextPanel;

    public void NextPanel()
    {
        CreateGameData.gameCategory = gameCategory.options[gameCategory.value].text;
        //nextPanel.SetActive(true);
        //this.gameObject.SetActive(false);
    }
}
