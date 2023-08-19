using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public bool jump = false;
    public float JumpForce;
    public bool flor = true;
    public bool wal;
    public bool wallleft;
    public bool walljump;
    public bool noWallJump;
    public bool fall;
    public bool walk;
    float horizontal;
    float vertical;
    public GameObject Player;
    private SpriteRenderer spi;
    //private Animation anim;
    //public Animation WalkAnim;
    void Start()
    {
        //anim = gameObject.GetComponent<Animation>();
        rb2d = GetComponent<Rigidbody2D>();
        spi = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.W)) {
            jump = true;
            fall = false;
        }
        if (jump && flor)
        {
            rb2d.AddForce(new Vector2(0f, JumpForce));
            jump = false;
            flor = false;
            //fall = true;
        }
        if (walljump && jump && noWallJump == false)
        {
            noWallJump = true;

            rb2d.AddForce(new Vector2(0f, JumpForce));
            rb2d.velocity = new Vector2(0, 0);
            jump = false;
            walljump = false;

            //fall = true;
        }
        if (flor == false && walljump == false && jump)
        {
            jump = false;
        }
        if (walljump == false)
        {
            rb2d.gravityScale = 2;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        //rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);

        /*if (wal)
        {
           rb2d.transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        
        if (wallleft)
        {
           rb2d.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        */
        //Try out this delta time method??
        if (Input.GetKey(KeyCode.D))
        {
            walk = true;
            //anim.Play("WalkAnim");
            //rb2d.AddForce(new Vector2(10f, 0f));
            rb2d.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            walk = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
            walk = true;
            spi.flipX = true;
        }
        else
        {
            spi.flipX = false;
        }
        if (Input.GetKey(KeyCode.A) && wallleft) {
            rb2d.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            walk = true;
        }
        if (Input.GetKey(KeyCode.D) && wal) {
            rb2d.transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            walk = true;
        }
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //rb2d.transform.position = new Vector3(horizontal * speed, 0f,0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            flor = true;
            noWallJump = false;
        }

        if (collision.gameObject.tag == "wall")
        {
            wal = true;
            walljump = true;
        }
        if (collision.gameObject.tag == "wallleft")
        {
            wallleft = true;
            walljump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            wal = false;
            walljump = false;
            noWallJump = false;
        }
        if (collision.gameObject.tag == "wallleft")
        {
            wallleft = false;
            walljump = false;
            noWallJump = false;
        }
    }
   
}
