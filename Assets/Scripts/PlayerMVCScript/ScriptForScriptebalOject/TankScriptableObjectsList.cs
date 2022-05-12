using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableOjectList", menuName = "ScriptableObjects/NewTankScriptableObjectList")]
public class TankScriptableObjectsList : ScriptableObject
{
    public TankScriptableObjects[] tanks;
}