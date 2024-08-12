using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendR_NextWord : MonoBehaviour
{
    private int curidx = 0;
    private List<string> blendR_words = new List<string>();

    public TextMesh text;
    void Start()
    {
        blendR_words.Add(new string("bread"));
        blendR_words.Add(new string("crayon"));
        blendR_words.Add(new string("grow"));
        blendR_words.Add(new string("price"));
        blendR_words.Add(new string("scribble"));

    }

    public void LoadWord_blendR()
    {
        if (LoadWordMode.blendR)
        {
            if (curidx == blendR_words.Count)
            {
                curidx = 0;
                text.text = blendR_words[curidx];
            }
            else
            {
                text.text = blendR_words[curidx];
                curidx += 1;

            }
        }
    }
}
