using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terbang : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody2D rb;
    public float velocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameManager.GameOver();
    }
}
