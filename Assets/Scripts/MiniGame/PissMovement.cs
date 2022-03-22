using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PissMovement : MonoBehaviour
{
    public Targert target;

    Rigidbody2D _rb;

    float dirX;
    float dirY;

    public float moveSpeed = 20f;

    public Text displayScoreText;

    public GameObject warning;
    public GameObject floatingScore;

    public Joystick joystick;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        displayScoreText.text = ScoreCount.countScore.ToString("0");
        Movement();
    }

    private void Movement()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.6f, 2.6f),
            Mathf.Clamp(transform.position.y, -4.3f, 4.3f));


        float horizontallMove = joystick.Horizontal;
        float verticalMove = joystick.Vertical;

        if (horizontallMove >= 0.5f)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (horizontallMove <= -0.5f)
        {
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        }


        if (verticalMove >= 0.5f)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (verticalMove <= -0.5f)
        {
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            ScoreCount.countScore += 50;
            Instantiate(floatingScore, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            target.SpawnTarget();
        }
        if (collision.gameObject.tag == "Out")
        {
            warning.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Out")
        {
            warning.SetActive(false);
        }
    }
}
