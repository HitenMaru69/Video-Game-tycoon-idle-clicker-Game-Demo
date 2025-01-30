using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameCrateProgres : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider progressImage;
    

    private void Start()
    {
        progressImage.value = 0;
        StartCoroutine(FillSliderOverTime());
    }

    IEnumerator FillSliderOverTime()
    {
        float currentTime = 0f;
        while (currentTime < CreateGameData.gameCreateTime)
        {
            currentTime += Time.deltaTime;
            progressImage.value = Mathf.Lerp(0, 1, currentTime / CreateGameData.gameCreateTime);
            yield return null;
        }
        
        progressImage.value = 1;
        Debug.Log("Game Progress is Complete");

        // add Functionality afte game Progress complate
        
    }

    

}
