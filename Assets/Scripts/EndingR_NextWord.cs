using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingR_NextWord : MonoBehaviour
{
    private int curidx = 0;
    private List<string> endingR_words = new List<string>();

    public TextMesh text;
    void Start()
    {
        endingR_words.Add(new string("bear"));
        endingR_words.Add(new string("color"));
        endingR_words.Add(new string("number"));
        endingR_words.Add(new string("water"));
        endingR_words.Add(new string("year"));

    }

    public void LoadWord_endingR()
    {
        if (LoadWordMode.endR)
        {
            if (curidx == endingR_words.Count)
            {
                curidx = 0;
                text.text = endingR_words[curidx];
            }
            else
            {
                text.text = endingR_words[curidx];
                curidx += 1;

            }
        }
    }
}
