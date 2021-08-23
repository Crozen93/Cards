using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{  

    public bool tableTextureBool;

    [Header("UI")]
    public Button changeTexTableButton;
    public Image tableImage;
    public Sprite[] tableTexture;

    private void Awake()
    {
        tableTextureBool = PlayerPrefs.GetInt("tableTexture") == 1 ? true : false;
        ChangeTexTableLoad();

    }

    private void Start()
    {
        changeTexTableButton.onClick.AddListener(() =>  ChangeTexTableSave());
    }

    //Change Color Table
    //load
    void ChangeTexTableLoad()
    {
        if (tableTextureBool == false)
        {
            tableImage.sprite = tableTexture[0];
        }
        else
        {
            tableImage.sprite = tableTexture[1];
        }
    }

    //save
    public void ChangeTexTableSave()
    {
        if (tableTextureBool == false)
        {
            tableImage.sprite = tableTexture[1];
            tableTextureBool = true;
        }
        else
        {
            tableImage.sprite = tableTexture[0];
            tableTextureBool = false;
        }

        PlayerPrefs.SetInt("tableTexture", tableTextureBool ? 1 : 0);
    }
}
