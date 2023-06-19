using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    public float dirX = 0f;
  
    private BoxCollider2D coll;

    

    private enum MovementState {idle, running, jumping, falling };

    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    [SerializeField] private AudioSource jumpSoundEffect;

    public bool leftButtonCheck = false;
    public bool rightButtonCheck = false;






    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        // yatay alandan gelen inputun yönünüe verir +1 -1, get axis raw tuş bırakılır bırakılmaz hızı 0lar :
        dirX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown("space") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpSoundEffect.Play();

            
        }

        UpdateAnimationState();


        if(leftButtonCheck == true)
        {
            leftButton();

        }

        if(rightButtonCheck == true)
        {

            rightButton();
        }
        

        if(rightButtonCheck == true && leftButtonCheck == true)
        {
            dirX = 0;

        }


    }


    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0)
        {
            state = MovementState.running;
            sr.flipX = false;
            
            //transform.Rotate(0, 0, 0);

        }
        else if (dirX < 0)
        {

            state = MovementState.running;
            
            sr.flipX = true;
            
            //transform.Rotate(0, 180f, 0);
        }

        else
        {

            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;

        }
        else if(rb.velocity.y < -.1f)
        {

            state = MovementState.falling;
        }

        anim.SetInteger("state",(int) state);


    }

    private bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);




    }

    //Button control

    public void jumpButton()
    {
        Debug.Log("WARNING" + isGrounded());
        if (isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpSoundEffect.Play();


        }

    }

    
    
   
    
    public void leftButton()
    {

        dirX = -1;

        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        leftButtonCheck = true;

        UpdateAnimationState();


    }

    public void leftFalse()
    {

        leftButtonCheck = false;
    }


    public void rightButton()
    {

        dirX = 1;

        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        rightButtonCheck = true;

        UpdateAnimationState();

    }


    public void rightFalse()
    {

        rightButtonCheck = false;
    }
}
