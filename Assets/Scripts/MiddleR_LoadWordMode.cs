using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MiddleR_LoadWordMode : MonoBehaviour
{
    public void LoadLevel()
    {
        LoadWordMode.beginR = false;
        LoadWordMode.middleR = true;
        LoadWordMode.endR = false;
        LoadWordMode.blendR = false;

        SceneManager.LoadScene(1);
    }
}
