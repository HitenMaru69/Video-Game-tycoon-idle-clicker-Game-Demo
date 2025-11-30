using UnityEngine;
using System.Collections.Generic;
public class NewGameListPanle : MonoBehaviour
{
    [SerializeField] private List<float> _gamePricesList;
    [SerializeField] private Transform _newGameListDataContent;

    private void OnEnable()
    {
        SetNewGameListData();
    }
    private void SetNewGameListData()
    {
        for (int i = 0; i < _newGameListDataContent.childCount; i++)
        {
            if(_newGameListDataContent.childCount < _gamePricesList.Count)
            {
                Debug.LogError("Not Enough Game List Prefebs In New Game List Content");
                return;
            }


            GameListPrefeb gameListPrefeb = _newGameListDataContent.GetChild(i).GetComponent<GameListPrefeb>();
            gameListPrefeb.SetGameListData(i+1,"New Game", _gamePricesList[i]);
        }
    }
}
