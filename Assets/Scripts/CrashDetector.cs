using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        print("Ouch");
    }
}