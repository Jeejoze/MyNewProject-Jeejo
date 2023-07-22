using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isground = true;
    public float speed = 10.0f;
    public float movex;
    public float jumpforce = 30.0f;
    private Rigidbody2D rb2d;
    private Animator an;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(movex * speed, rb2d.velocity.y, 0);
        rb2d.velocity = movement;
        if (Input.GetKeyDown(KeyCode.Space) && isground)
        {
            Jump();
        }

        if (movement.x != 0)
        {
            if (movex < 0)
            {
                transform.localRotation = Quaternion.AngleAxis(180, Vector3.up);
            }
            else if (movex > 0)
            {
                transform.localRotation = Quaternion.AngleAxis(0, Vector3.up);
            }
            an.SetBool("IsRunning", true);

        }

        else
        {
            an.SetBool("IsRunning", false);
        }
        if (!isground)
        {
            an.SetBool("IsJumping", true);
        }
        else
        {
            an.SetBool("IsJumping", false);
        }
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            isground = true;

        }
    }

    private void Jump()
    {
        rb2d.AddForce(new Vector3(0, jumpforce, 0), ForceMode2D.Impulse);
        isground = false;
        Debug.Log(isground);
    }

}
