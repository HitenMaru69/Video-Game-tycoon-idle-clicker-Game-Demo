using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameNamePanel;

    private void Start()
    {
        gameNamePanel.SetActive(false);

    }

    public void CreateGameBu()
    {
        gameNamePanel.SetActive(true);
    }


}
