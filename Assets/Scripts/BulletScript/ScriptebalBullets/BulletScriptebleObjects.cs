using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BulletsScriptableOject", menuName = "ScriptableObjects/NewBulletsScriptableObject")]
public class BulletScriptebleObjects : ScriptableObject
{
    public BulletType BulletType;
    public string BulletName;
    public float BulletDamage;
    public float BulletSpeed;
}
