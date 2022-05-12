using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableOject", menuName = "ScriptableObjects/NewTankScriptableObject")]
public class TankScriptableObjects : ScriptableObject
{
    public TankType TankType;
    public string TankName;
    public float MovementSpeed;
    public float MotationSpeed;
    public float BulletSpeed;
   // public BulletType BulletType;
    //public float BulletForce;
}

