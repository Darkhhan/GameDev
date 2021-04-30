using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float EnemySpeed;
    [SerializeField]
    private Vector3[] positions;
    private int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positions[index], Time.deltaTime * EnemySpeed);
        Vector3 characterScale = transform.localScale;
        if (transform.position == positions[index])
        {
            if (index == positions.Length - 1)
            {
                index = 0;
                if (positions[index].x > positions[index + 1].x)
                {
                    characterScale.x = -1f;
                }
                if (positions[index].x < positions[index + 1].x)
                {
                    characterScale.x = +1f;
                }
            }
            else
            {
                if (positions[index].x > positions[index + 1].x)
                {
                    characterScale.x = +1f;
                }
                if (positions[index].x < positions[index + 1].x)
                {
                    characterScale.x = -1f;
                }
                index++;


            }
        }
        transform.localScale = characterScale;
    }
}