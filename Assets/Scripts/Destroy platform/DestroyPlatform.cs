using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{

    private GameObject Platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyGD()
    {
        Platform = GameObject.FindGameObjectWithTag("Ground");
        DestroyObject(Platform, 0.3f);
        Platform = GameObject.FindGameObjectWithTag("Enemy");
        DestroyObject(Platform, 0.3f);
    }
}
