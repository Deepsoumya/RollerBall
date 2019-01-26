using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    public int count;
    public VirtualJoystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal1 = joystick.Horizontal();
        float moveVertical1 = joystick.Vertical();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 movement1 = new Vector3(moveHorizontal1, 0.0f, moveVertical1);

        rb.AddForce(movement * speed);
        rb.AddForce(movement1 * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Scores: " + count.ToString();
        if (count >= 2)
        {
            winText.text = "You Win!!!";
            }
        }
    }
