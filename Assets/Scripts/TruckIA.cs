using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TruckIA : MonoBehaviour
{
    [SerializeField] private bool isAtDestination1 = false;
    [SerializeField] private NavMeshAgent camion;
    [SerializeField] private GameObject TrashCan1;
    [SerializeField] private GameObject TrashCan2;
    [SerializeField] private GameObject TrashCan3;

    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        camion = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        /*if (isAtDestination1 == false)
        {
            camion.SetDestination( new Vector3(destination1.transform.position.x,0,0));

        }
        if (camion.gameObject.transform.position == destination1.transform.position)
        {
            isAtDestination1 = true;
        }
        if (isAtDestination1)
        {
            camion.SetDestination(new Vector3(destination2.transform.position.x, 0, 0));
        }
        if (camion.gameObject.transform.position == destination2.transform.position)
        {
            isAtDestination1 = false;
        }*/
    }
}
