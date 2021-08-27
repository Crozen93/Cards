using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] private Slider loadSlider;             // load slider

    void Start()
    {
        CheckResolution.instance.ChecPhonekResolution();    // Check resolution
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

}
