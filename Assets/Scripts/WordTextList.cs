using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordTextList : MonoBehaviour
{
    private int curidx = 0;

    private List<string> beginningR_words = new List<string>();

    public TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        beginningR_words.Add(new string("rabbit"));
        beginningR_words.Add(new string("raining"));
        beginningR_words.Add(new string("river"));
        beginningR_words.Add(new string("row"));
        beginningR_words.Add(new string("ruin"));

        //middleR_words.Add(new string("bird"));
        //middleR_words.Add(new string("forcing"));
        //middleR_words.Add(new string("hurricane"));
        //middleR_words.Add(new string("journey"));
        //middleR_words.Add(new string("turtle"));

        //endingR_words.Add(new string("bear"));
        //endingR_words.Add(new string("color"));
        //endingR_words.Add(new string("number"));
        //endingR_words.Add(new string("water"));
        //endingR_words.Add(new string("year"));

        //Debug.Log(middleR_words.Count);
    }

    public void LoadWord_beginR()
    {
        if (LoadWordMode.beginR) {
            if (curidx == beginningR_words.Count)
            {
                curidx = 0;
                text.text = beginningR_words[curidx];
            }
            else
            {
                text.text = beginningR_words[curidx];
                curidx += 1;

            }
        }
    }
}
