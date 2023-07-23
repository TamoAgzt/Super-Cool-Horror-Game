using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_PlayerController : MonoBehaviour
{
  #region Variables

  [Header("Assignable")]
  public CharacterController characterController;
  public Transform camera;

  //###############################################

  [Header("Values")]
  public float movementSpeed = 8; //Default 8
  public float cameraSensitivity; //Max 10
  public float verticalLookLimit = 85; //Default 85
  float gravity = -9f; //Default -9
  float xViewRotation = 0;

  //###############################################

  [Header("Checks")]
  public float gravityForce;
  public bool isGrounded;
  Vector3 V3locity;

  //###############################################


  #endregion

  //###############################################

  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;

  }

  void Update()
  {
    Look();
    Move();
  }

  private void Move()
  {
    float VerticalAxis = (Input.GetAxisRaw("Vertical")) * movementSpeed;
    float HorizontalAxis = (Input.GetAxisRaw("Horizontal")) * movementSpeed;
    Vector3 V3Move = (transform.forward * VerticalAxis) + (transform.right * HorizontalAxis);

    if (V3locity.y > gravity)
    {
        V3locity.y += (gravity * Time.deltaTime) * 3;
    }
    
    Vector3 pyshics = V3Move + V3locity;
    characterController.Move(pyshics * Time.deltaTime);
    
    isGrounded = characterController.isGrounded;
    gravityForce = V3locity.y;

  }

  private void Look()
  {
    xViewRotation += -Input.GetAxis("Mouse Y") * cameraSensitivity;
    xViewRotation = Mathf.Clamp(xViewRotation, -verticalLookLimit, verticalLookLimit);
    camera.transform.localRotation = Quaternion.Euler(xViewRotation, 0, 0);
    transform.localRotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * cameraSensitivity, 0);

  }

}
