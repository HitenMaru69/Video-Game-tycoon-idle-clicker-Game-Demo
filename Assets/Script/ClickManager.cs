using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{
    [SerializeField] MoneyManager moneyManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!IsCLickOnUI()) {

                moneyManager.MoneyIncressEvent();
            }
        }
    }

    bool IsCLickOnUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
