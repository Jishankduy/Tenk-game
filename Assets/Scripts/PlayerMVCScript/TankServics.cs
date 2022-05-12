using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankServics : MonoBehaviour
{
    public TankView tankView;

    private int BT;

    //public TankScriptableObjects[] tankConfigurations;

    public TankScriptableObjectsList tankList;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
        
    }

    private void CreateTank()
    {
        //TankScriptableObjects tankScriptableObjects = tankConfigurations[BT];
        TankScriptableObjects tankScriptableObjects = tankList.tanks[BT];
        TankModel tankModel = new TankModel(tankScriptableObjects);
        //TankModel tankModel = new TankModel(TankType.None, 30, 20);   //Reference tankModel script and make new Tank
        TankController tankController = new TankController(tankModel, tankView);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BT = 0;

            Debug.Log("0");

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            BT = 1;
            Debug.Log("1");
        }
    }
}