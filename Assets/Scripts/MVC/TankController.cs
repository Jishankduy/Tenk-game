using UnityEngine;

public class TankController
{
    private TankModel tankModel;  //referencse of TankModel Script

    private TankView tankView;    //referencse of TankView Script

    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)  //Constrocter for References other Script
    { 
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        

    }

    public void Move(float movement, float MovementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement *MovementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
    
    public float getMovementSpeed()
    {
        return tankModel.movementSpeed;
    }
}
