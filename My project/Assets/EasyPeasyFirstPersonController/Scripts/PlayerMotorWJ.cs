using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
public class PlayerMotorWJ : MonoBehaviour
{
    private Vector3 moveVector;
    private Vector3 lastMove;
    private float speed = 8;
    private float jumpforce = 8;
    private float gravity = 25;
    private float verticalVelocity;
    private CharacterController controller;

    //private void Start()
    //{
    //    controller = GetComponent<CharacterController>();
    //}
    //private void Update()
    //{
    //    moveVector = Vector3.zero;
    //    moveVector.x = PlayerInput.
    //    moveVector.y = PlayerInputManager .MainVertical();

    //    if (controller.isGrounded)
    //    {
    //        verticalVelocity = -1;

    //        if (InputManager.AButton())
    //        {
    //            verticalVelocity = jumpforce;
    //        }
    //    }
    //    else
    //    {
    //        verticalVelocity -= gravity * Time.deltaTime;
    //        MoveVector = lastMove;
    //    }

    //    moveVector.y = 0;
    //    moveVector.Normalize();
    //    moveVector *= speed;
    //    moveVector.y = verticalVelocity;

    //    controller.Move(moveVector * Time.deltaTime);
    //    lastMove = moveVector;
    //}

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    Debug.DrawRay(hit.point, hit.normal, colour.red);
    //}
}
