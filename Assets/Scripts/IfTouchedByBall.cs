using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTouchedByBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            print("touched");
        }
    }
}
