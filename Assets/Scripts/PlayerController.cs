using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f;
    Rigidbody2D rb2d;
    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb2d.AddTorque(-torqueAmount);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb2d.AddTorque(torqueAmount);
        }
    }
}
