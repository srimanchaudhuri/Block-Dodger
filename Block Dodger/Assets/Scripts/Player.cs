using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speedVariable = 15f;
    [SerializeField] private float mapWidth = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speedVariable;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
