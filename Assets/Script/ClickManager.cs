using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!IsClickOnButton())
            {
                Debug.Log("yes Click");
            }
        }
    }


    bool IsClickOnButton()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
