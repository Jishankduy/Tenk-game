using UnityEngine;

public class TankModel
{
    private TankController tankController;
    
    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(TankScriptableObjects tankScriptableObjects)
    {
        TankType = tankScriptableObjects.TankType;
        movementSpeed = tankScriptableObjects.MovementSpeed;
        rotationSpeed = tankScriptableObjects.MotationSpeed;
    }
    //public TankModel(TankType tankType, float _movement, float _rotation)     //Constrocter
   // {
        //TankType = TankScriptableObjects.Tanktype;
     //   movementSpeed = _movement;
       // rotationSpeed = _rotation;
   // }

    public TankType TankType { get; } //??????
   

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }


}
