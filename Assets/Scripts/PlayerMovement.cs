using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public float moveSpeed;
    bool controlsActive;

    public Rigidbody rb; //for jump
    public bool playerIsOnTheGround = true; // for jump

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //for jump

        controlsActive = true; //at the start allow controls to be true
        moveSpeed = 35f; //movement speed

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
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

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
