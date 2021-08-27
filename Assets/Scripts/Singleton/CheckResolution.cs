using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckResolution : MonoBehaviour
{
    public static CheckResolution instance { get; private set; } //Singleton

    private void Awake()
    {
        CheckInstance();
    }

    private void CheckInstance()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChecPhonekResolution()
    {
        if (Screen.width > Screen.height)
        {
            Screen.orientation = ScreenOrientation.Landscape;
            Debug.Log("ScreenOrientation = Landscope");          // Test ScreenOrientation - Landscope
        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Debug.Log("ScreenOrientation = Portrait");           // Test ScreenOrientation - Portrait
        }
    }
}
