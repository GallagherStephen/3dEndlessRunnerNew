using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public float moveSpeed;
    bool controlsActive;

    // Start is called before the first frame update
    private void Start()
    {

        controlsActive = true; //at the start allow controls to be true
        moveSpeed = 25f; //movement speed

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
    }


    private void PlayerHasDied()
    {
        print("player is dead");
        controlsActive = false; //stop player movement 

    }
}
