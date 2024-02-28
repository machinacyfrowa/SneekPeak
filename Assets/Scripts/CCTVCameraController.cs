using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    //modyfikator prêdkoœci obrotu
    public float turnSpeed = 5f;

    //zakres obrotu kamery w stopniach
    public float turnAngle = 90;

    //czy kamera krêci siê w prawo
    bool turningRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(turningRight)
            TurnRight();
        else
            TurnLeft();
        CheckAngle();
        Debug.Log("y: " + transform.eulerAngles.y);
    }
    void TurnRight()
    {
        //obróc o 1 stopieñ na sekunde * mno¿nik w prawo
        transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
    }
    void TurnLeft()
    {
        //obróc o 1 stopieñ na sekunde * mno¿nik w lewo
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
    void CheckAngle()
    {
        //TODO: zwracaj kamerê kiedy osi¹gnie wychylenie turnangle/2
    }
}
