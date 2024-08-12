using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToHomeScreen : MonoBehaviour
{
    public void ReturnToHome()
    {
        LoadWordMode.beginR = false;
        LoadWordMode.middleR = false;
        LoadWordMode.endR = false;
        LoadWordMode.blendR = false;

        SceneManager.LoadScene(0);
    }
}
