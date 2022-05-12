using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameArea")
        {
            Destroy(this.gameObject);
            Debug.Log("yes ");
        }
    }
}
