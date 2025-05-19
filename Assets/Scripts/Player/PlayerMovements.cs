using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    //Player Controller
    public CharacterController controller;      //controller as CharacterController
    public float playerSpeed = 10.0f;           //current player speed
    public float defaultSpeed = 10.0f;          //Default speed to fall back on
    public float sprintMultiplier = 1.5f;       //Adjustable multiplier 
    Vector2 moveDirection = Vector2.zero;       //Empty vector 2 initialized for moveDirection
    public InputSystem_Actions playerControls;  //playerControls as the input system actions (assigning keybinds)
    public InputActionProperty Move;            //Move is defined for input actions in InputSystem_Actions
    public InputActionProperty Jump;
    public InputActionProperty Sprint;

    //General Player
    public float gravity = -9.81f;              //Gravity set to -9.81 as on Earth
    Vector3 velocity;                           //Initalize the players vertical velocity
    public Transform groundCheck;               //groundCheck as a Transform to find if pos is touching ground
    public float groundDistance = 0.4f;         //set groundDistance to be 0.4 incase of any weird height issues on surface of ground
    public LayerMask groundMask;                //specify ground to be a layer for raycast
    bool isGrounded;                            //simple bool for grounded or not
    public float jumpHeight = 3.0f;             //Specify jumping height
    bool isSprinting;                           //simple bool for sprinting or not


    // =-=-=-=-= Start =-=-=-=-=
    private void Awake()
    {
        playerControls = new InputSystem_Actions();     //On load set player controls (part of player movement) to the InputSystem_Actions
    }

    private void OnEnable()
    {
        playerControls.Enable();    //Necessary for player input system.
    }

    private void OnDisable()
    {
        playerControls.Disable();    //Necessary for player input system
    }

    // =-=-=-=-= Update =-=-=-=-=
    private void Update()
    {
        DoGroundCheck();
        handleSprint();
        jumpCheck();
        applyGravity();
        handleMovement();
    }

    //=-=-=-=-= Functions =-=-=-=-=
    private void handleMovement()
    {
        moveDirection = Move.action.ReadValue<Vector2>();                                                 //moveDirection stores value of Vector2 which holds "horizontal" and "vertical" input (WASD) from "Move" within InputSystem_Actions
        Vector3 movePlayer = transform.right * moveDirection.x + transform.forward * moveDirection.y;     //Initialize and declare movePlayer as Vector3 which holds "Red Arrow" (x component) as unit vector of 1 multiplied by Input of either 0 or 1, same for forward axis
        controller.Move(movePlayer * playerSpeed * Time.deltaTime);                                       //use controller of "Move" from InputSystem_Actions using Vector 3 "movePlayer" (already normalized) multiplied by speed and deltatime
    }
    private void playerJump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);     //Apply vertical velocity to the jumpHeight against gravity
    }
    private void handleSprint()                                 //If sprint button pressed or held, multiply speed by multiplier else regular speed
    {
        isSprinting = (Sprint.action.IsPressed());
        if (isSprinting)
        {
            playerSpeed = sprintMultiplier * defaultSpeed;
        }
        else
        {
            playerSpeed = defaultSpeed;
        }
    }
    private void DoGroundCheck()
    {
       isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);               //Casts sphere beneath player and if sphere collides with ground, then isGrounded = true
       if (isGrounded && velocity.y < 0)
       {            
            velocity.y = -2f;                                                                             //Prevents player from floating when isGrounded is triggered, thus apply small vertical velocity to keep on ground
       }
    }
    private void jumpCheck()
    {
        if (Jump.action.WasPressedThisFrame() && isGrounded)
        {
            playerJump();
        }
    }
    private void applyGravity()
    {
        velocity.y += gravity * Time.deltaTime;                                                           //Set y component of velocity to gravity time deltatime every frame
        controller.Move(velocity * Time.deltaTime);                                                       //Every frame move the player by velocity times deltatime to match units of gravity
    }
}
