using System.Collections.Generic;
using UnityEngine;

public class EmployListPanel : MonoBehaviour
{
    [SerializeField] private List<int> _employePrices;
    [SerializeField] private Transform _contentTransform;


    private void OnEnable()
    {
        SetEmployePrice();
    }

    private void SetEmployePrice()
    {
        for(int i =0;i< _contentTransform.childCount; i++)
        {
            GameListPrefeb gameListPrefeb = _contentTransform.GetChild(i).GetComponent<GameListPrefeb>();
            gameListPrefeb.SetGameListData(i+1,"New Employe" + (i + 1), _employePrices[i] );
        }
    }
}
