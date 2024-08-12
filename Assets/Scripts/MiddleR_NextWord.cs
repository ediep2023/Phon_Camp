using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleR_NextWord : MonoBehaviour
{
    private int curidx = 0;
    private List<string> middleR_words = new List<string>();

    public TextMesh text;
    void Start()
    {
        middleR_words.Add(new string("bird"));
        middleR_words.Add(new string("forcing"));
        middleR_words.Add(new string("hurricane"));
        middleR_words.Add(new string("journey"));
        middleR_words.Add(new string("turtle"));

    }

    public void LoadWord_middleR()
    {
        if (LoadWordMode.middleR)
        {
            if (curidx == middleR_words.Count)
            {
                curidx = 0;
                text.text = middleR_words[curidx];
            }
            else
            {
                text.text = middleR_words[curidx];
                curidx += 1;

            }
        }
    }
}
