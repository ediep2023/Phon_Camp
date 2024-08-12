using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingR_LoadWordMode : MonoBehaviour
{
    public void LoadLevel()
    {
        LoadWordMode.beginR = false;
        LoadWordMode.middleR = false;
        LoadWordMode.endR = true;
        LoadWordMode.blendR = false;

        SceneManager.LoadScene(1);
    }
}
