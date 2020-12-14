using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour{

    public float moveSpeed;
    bool controlsActive;

    public Rigidbody rb; //for jump
    public bool playerIsOnTheGround = true; // for jump

    public float horizontalThrow;
    public float yPos = -15;
    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //for jump

        controlsActive = true; //at the start allow controls to be true
        //moveSpeed = 35f; //movement speed

        

    }

    // Update is called once per frame
    private void Update()
    {


        if (controlsActive)
        {
            Movement();
        }
        
    }

    private void Movement()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,0f);

        //input
        horizontalThrow = Input.GetAxis("Horizontal");
        //speed
        float xOffset = horizontalThrow / moveSpeed;
        //clamp to screen width
        float xPos = Mathf.Clamp(transform.localPosition.x + xOffset, -1.7f, 1.7f);
        float yPos = Mathf.Clamp(transform.localPosition.y, 0, 10);
        //update position
        transform.position = new Vector3(xPos,yPos, transform.position.z);


        //To clamp player range on x-axis
        //transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
       // transform.position = new Vector3(Mathf.Clamp(transform.position.x, xLeftValueLimit, xRightValueLimit));



        if (Input.GetButtonDown("Jump") && playerIsOnTheGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            playerIsOnTheGround = false;
        }
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "floor")
        {
            playerIsOnTheGround = true;
        }
    }

    private void PlayerHasDied()
    {
        print("player is dead");
        controlsActive = false; //stop player movement 

    }
}
