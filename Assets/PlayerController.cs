using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private PlayerInputs controller;
  private Rigidbody2D rbd;
  static public PlayerController player;

  // Start is called before the first frame update
  void Start()
  {
    controller = new PlayerInputs();
    controller.Enable();
    rbd = GetComponent<Rigidbody2D>();
    player = this;
  }

  // Update is called once per frame
  void Update()
  {
    rbd.velocity = controller.movements.move.ReadValue<Vector2>() * 2;
  }

  public void Disable()
  {
    controller.Disable();
  }

  public void Enable()
  {
    controller.Enable();
  }
}
