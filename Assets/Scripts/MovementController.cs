using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovePlayerTo(Vector3 targetPosition)
    {
        player.GetComponent<NavMeshAgent>().SetDestination(targetPosition);
    }
}
