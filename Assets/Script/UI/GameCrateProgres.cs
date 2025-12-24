using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameCrateProgres : MonoBehaviour
{
    [SerializeField] Slider progressImage;
    [SerializeField] TextMeshProUGUI randomTxt;
    [SerializeField] GameObject finishButton;


    List<String> randomTextList = new()
    {
        "Creating Blueprint",
        "Creating Art",
        "Writing Code",
        "Game Balances and Fixes",
        "Fixing Bugs",
        "Testing Quality Assurance",
        "Adding Music and Sound ",
        "Final Improvement",
        "Ready To Launch"
    };

    void OnEnable()
    {
        progressImage.gameObject.SetActive(true);
        finishButton.SetActive(false);
        progressImage.value = 0;
        randomTxt.text = randomTextList[0];
        StartCoroutine(FillSliderOverTime());

    }

    IEnumerator FillSliderOverTime()
    {
        float currentTime = 0f;
        float totalTime = CreateGameData.gameCreateTime;
        int totalIndex = randomTextList.Count;
        float nextIndexTime = totalTime / totalIndex;
        int currentStep = 0;

        while (currentTime < totalTime)
        {
            currentTime += Time.deltaTime;
            progressImage.value = Mathf.Lerp(0, 1, currentTime / totalTime);

    
            int newStep = Mathf.FloorToInt(currentTime / nextIndexTime);
            if (newStep != currentStep && newStep < totalIndex)
            {
                currentStep = newStep;
                randomTxt.text = randomTextList[currentStep];
            }

            yield return null;
        }

        progressImage.value = 1;
        randomTxt.text = randomTextList[^1];
        progressImage.gameObject.SetActive(false);
        finishButton.SetActive(true);

    }

    public void ClickOnFinishButton()
    {
        CreateGameData.gameCreateTime = 0;
        this.gameObject.SetActive(false);
        PanelManager.Instance.HidePanel(PanelName.CreateGamePanel);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
