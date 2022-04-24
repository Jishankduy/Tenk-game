using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    public Joystick joystick;
    private float movement;
    private float rotation;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("TankCamera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0.34f, 2.343f, -1.24f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
       
        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = joystick.Horizontal;
    }


    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
