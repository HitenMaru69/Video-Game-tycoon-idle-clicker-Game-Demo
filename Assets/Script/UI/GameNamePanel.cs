using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GameNamePanel : MonoBehaviour
{
    [SerializeField] TMP_InputField gameName;
    [SerializeField] GameObject nextPanel;

    public void NextPanel()
    {
        CreateGameData.gameName = gameName.text;
        nextPanel.SetActive(true);
        gameName.text = "";
        this.gameObject.SetActive(false);


       
    }


}

