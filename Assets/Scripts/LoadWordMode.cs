using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWordMode : MonoBehaviour
{
    public int sceneNumber;
    public static bool beginR = false;
    public static bool middleR = false;
    public static bool endR = false;
    public static bool blendR = false;

    public void LoadLevel()
    {
        beginR = true;
        middleR = false;
        endR = false;
        blendR = false;

        SceneManager.LoadScene(1);
    }
}
