
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTank;
    public Vector3 offset;
    public Camera cam;
    private float CameraZoomOutSpeed = 0.0001f;
    public DestroyPlatform destroyPlatform;


    public void Start()
    {
        playerTank = FindObjectOfType<TankView>().transform;
    }

    void Update()
    {
        CheckPlayer();
        //transform.position = playerTank.transform.position + offset;
    }

    private void CheckPlayer()
    {
        if (playerTank != null)
        {
            //playerTank = transform;
            transform.position = playerTank.transform.position;
            return;   
        }
        else if (playerTank == null)
        {
            ZoomOutCamera();
            destroyPlatform.DestroyGD();

        }

    }

    public IEnumerator ZoomOutCamera()  
    {
        Debug.Log("zoom out hoja yaar");
        float lerp = 0.01f;
        //camera.transform.SetParent(null);
        while (cam.orthographicSize < 30)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 30, lerp);
            lerp = lerp + CameraZoomOutSpeed;
            yield return new WaitForSeconds(0.01f);
        }

    }


}
