using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayAmount = 2f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Invoke(nameof(ReloadScene), delayAmount);
        }
    }

    private void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
