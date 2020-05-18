using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
    //rigidbody
    Rigidbody2D rb;
    //player speed
    public float movementSpeed = 5f;
    public float jumpingSpeed = 5f;

    private bool isGrounded;
    public Transform groundCheck; 
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue; 

    //flipFace
    private bool facingRight = true; 

    //Dead caption
    public GameObject deadCaption;

    //camera Zoom
    public Camera cameraZoom;
    [SerializeField]
    private float viewDepth;

    //mom
    public GameObject mom;

    //speech bubble
    bool captionToggle;
    public GameObject speechBubble;
    public GameObject appleSpeechBubble; 
        



    void Start()
    {
        extraJumps = extraJumpsValue; 
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); 
        
    }


    private void Update()
    {
        //if grounded to jump again
        if (isGrounded == true)
        {
            extraJumps = 1;
        }

        // left and right movement
        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);

        //flipping players face
        if (facingRight == false && horizontal > 0)
        {
            Flip();
        }
        else if (facingRight == true && horizontal < 0)
        {
            Flip();
        }


        //jump
        if (Input.GetKeyDown(KeyCode.W) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpingSpeed;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpingSpeed;
        }

        //speech bubble 

        if (Input.GetKeyDown(KeyCode.K))
        {
            captionToggle = !captionToggle;
            if (captionToggle)
            {
                speechBubble.SetActive(true);
            }
            else
            {
                speechBubble.SetActive(false);
            }         
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            captionToggle = !captionToggle;
            if (captionToggle)
            {
                appleSpeechBubble.SetActive(true);
            }
            else
            {
                appleSpeechBubble.SetActive(false);
            }
        }
    }

    private void handleMovement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler; 
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "player2")
        //{
        //    collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
        //}

        if (collision.gameObject.tag == "destroy")
        {
            deadCaption.gameObject.SetActive(true);
            StartCoroutine(Dead());
        }

        if (collision.gameObject.name == "Layer Change")
        {
            Debug.Log("player sprite layer have been changed");
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == " apple")
        {
            Debug.Log("apple_hit");
            Destroy(collision.gameObject);
        }
    }


    IEnumerator Dead()
    { 
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}


// USING NON RIGIDBODY
//if (Input.GetAxis("Horizontal") > 0f)
//{
//    transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
//}
//else if (Input.GetAxis("Horizontal") < 0f)
//{
//    transform.position += new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
//}
//else
//{
//    transform.position += new Vector3(0, 0);

//}
//}
//void moveCharacter(Vector2 direction)
//{
//    rb.velocity = direction * movementSpeed; 
//}