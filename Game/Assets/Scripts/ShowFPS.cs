using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShowFPS : MonoBehaviour
{
    public float timer, refresh, avgFramerate;
    public Text m_Text;
    private bool fpsCount = true;

    public void Update()
    {
        if (fpsCount)
        {
            float timelapse = Time.smoothDeltaTime;
            timer = timer <= 0 ? refresh : timer -= timelapse;

            if (PauseMenuManager.isPaused == false && ShopKeeper.shopActive == false)
            {
                if (timer <= 0) avgFramerate = (int)(1f / timelapse);
                m_Text.text = avgFramerate.ToString();
            }
        }
        else
        {
            m_Text.text = "";
        }
    }

    public void DEBUG_FPS(InputAction.CallbackContext context)
    {
        fpsCount = !fpsCount;
    }
}
