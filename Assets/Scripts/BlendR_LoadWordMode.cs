using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlendR_LoadWordMode : MonoBehaviour
{
    public void LoadLevel()
    {
        LoadWordMode.beginR = false;
        LoadWordMode.middleR = false;
        LoadWordMode.endR = false;
        LoadWordMode.blendR = true;

        SceneManager.LoadScene(1);
    }
}
