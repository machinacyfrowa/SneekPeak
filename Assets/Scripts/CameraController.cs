using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // pozycja gracza
    Transform player;
    // offset kamery
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        // znajdz gracza i pod³¹cz jego pozycjê do zmiennej transform
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // pobierz domyœlny offset kamery
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //pozycja kamery to pozyja gracza + offset
        transform.position = player.position + cameraOffset;
    }
}
