using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    public float speed = 4f;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
}