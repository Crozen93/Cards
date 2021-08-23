using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Slider loadSlider;

    private void Awake()
    {      
        CheckResolution();
    }

    void Start()
    {
        StartCoroutine(LoadScene());     
    }

    IEnumerator LoadScene()
    {         
        float startTime = 0;

        while (startTime <= 3f)
        {
            loadSlider.value = startTime;
            startTime += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("GameScene");
    }

    void CheckResolution()
    {
        if (Screen.width > Screen.height)
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
