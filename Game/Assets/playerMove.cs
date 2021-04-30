using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed = 2.5F;
    public float jump = 5f;
    public string JumpButton = "Jump";
    void Start()
    {

    }

    void Update()
    {

        Vector3 horizontalMove = new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0f, 0f);
        transform.position += horizontalMove * Time.deltaTime * speed;

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            characterScale.x = +1f;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            characterScale.x = -1f;
        }
        transform.localScale = characterScale;
        if (Input.GetButtonDown(JumpButton))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {

    }



}
