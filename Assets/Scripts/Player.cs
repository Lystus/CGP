using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jump = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Ded", LoadSceneMode.Single);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space)) 
        {
            rigidbody.velocity = Vector2.up * jump;
        }
    }
}