using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    float speed = 2.5F;
    float jump = 5f;
    public string Jump_button = "Jump";
    void Start()
    {

    }

    void Update()
    {

        Vector3 horizontalMove = new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0f, 0f);
        transform.position += horizontalMove * Time.deltaTime * speed;

        if (Input.GetButtonDown(Jump_button))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }
    }



}
