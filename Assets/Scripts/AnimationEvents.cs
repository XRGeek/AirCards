using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public GameObject videoRenderer;
    public GameObject webButtons;
    public GameObject splash;
    public GameObject userName;
    public GameObject mask;
    public GameObject bottomButtons;

    // Start is called before the first frame update
    public void OnVideoMoved()
    {
        webButtons.SetActive(true);
    }

    // Update is called once per frame
    void OnUserMoved()
    {
        videoRenderer.SetActive(true);
    }

    void OnSplashFinished()
    {
        mask.SetActive(true);
        splash.SetActive(false);
        userName.SetActive(true);
    }
    void OnWebButtonMoved()
    {
        bottomButtons.SetActive(true);
    }
}
