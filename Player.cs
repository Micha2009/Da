using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;

    void Update()
    {
        Move();
    }

    public Projectile projectilePrefab;

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }   
   
}
