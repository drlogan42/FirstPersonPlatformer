using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;                //The position and rotation of the player body
    float xRotation = 0f;                       //Rotation about x (up-down)
    public InputActionProperty Look;            //Look is defined for input actions in InputSystem_Actions
    public InputSystem_Actions playerControls;  //playerControls as the input system actions (assigning keybinds)
    Vector2 lookDirection = Vector2.zero;       //Empty vector 2 initialized for lookDirection
    public GameSettings settings; // Drag the same asset here in the Inspector

    private void Awake()
    {
        playerControls = new InputSystem_Actions();     //On load set player controls (part of player movement) to the InputSystem_Actions
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Locks cursor in game within window
    }

    private void OnEnable()
    {
        playerControls.Enable();    //Necessary for player input system
    }

    private void OnDisable()
    {
        playerControls.Disable();    //Necessary for player input system
    }
    private void Update()
    {
        lookDirection = Look.action.ReadValue<Vector2>() * settings.sensitivity * Time.deltaTime;        //lookDirection stores value of Vector2 which holds "horizontal" and "vertical" input (look) from "Look" within InputSystem_Actions

        xRotation -= lookDirection.y;                                                         //Invert Up-Down Axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);                                        //Clamp the vertical axis so player cant look upside down

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);                        //Use a quaternion.euler to apply vertical rotation to camera
        playerBody.Rotate(Vector3.up * lookDirection.x);                                      //Apply horizontal rotation to player body

    }
}
