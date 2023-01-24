using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreationController : MonoBehaviour
{
    public InputField inputField;
    public string userName;

    // Update is called once per frame
    void Update()
    {
        inputField.ActivateInputField();
        inputField.Select();
    }

    //Creates character, saves name and current level to disc using SaveManager class which doesn't destroy upon changing scenes
    public void createCharacter()
    {
        inputField.enabled = false;
        string name = inputField.text;
        if (name.Length > 0)
        {
            userName = name;
            SaveManager.instance.saveLevel("Tutorial");
            SaveManager.instance.saveName(userName);
            SaveManager.instance.savePlayerPosition(0.0f, 0.0f);
            SaveManager.instance.Save();
        }
    }
}
