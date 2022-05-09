using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankServics : MonoBehaviour
{
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(30, 20);   //Reference tankModel script and make new Tank
        TankController tankController = new TankController(tankModel, tankView);

    }
}
