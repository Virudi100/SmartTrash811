using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;

public class TruckIA : MonoBehaviour
{
    [SerializeField] private NavMeshAgent camion;
    [SerializeField] private bool isAtDestination1 = false;
    [SerializeField] private bool isAtDestination2 = false;
    [SerializeField] private bool isAtDestination3 = false;

    [SerializeField] private GameObject trash1;
    [SerializeField] private GameObject trash2;
    [SerializeField] private GameObject trash3;

    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.parent = null;
        camion = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        /////////////////////////////////
        if(trash1 == null)
        {
            trash1 = GameObject.FindWithTag("Trash1");
        }
        if(trash2 == null)
        {
            trash2 = GameObject.FindWithTag("Trash2");
        }
        if(trash3 == null)
        {
            trash3 = GameObject.FindWithTag("Trash3");
        }
        /////////////////////////////////////

        if(trash1 != null)
        {
            if (camion.transform.position == trash1.transform.position)
            {
                isAtDestination1 = true;
            }
            else
                isAtDestination1 = false;
        }
        if(trash2 != null)
        {
            if (camion.transform.position == trash2.transform.position)
            {
                isAtDestination2 = true;
            }
            else
                isAtDestination2 = false;
        }
        if(trash3 != null)
        {
            if (camion.transform.position == trash3.transform.position)
            {
                isAtDestination3 = true;
            }
            else
                isAtDestination3 = false;
        }
        /////////////////////////////////////////////
        
        if(isAtDestination1)
        {

        }
        if(isAtDestination2)
        {

        }
        if(isAtDestination3)
        {

        }
    }

    public void GoTrash1()
    {
        
        if (trash1 != null)
        {
            camion.SetDestination(trash1.transform.position);
            print("going1");
        }
    }

    public void GoTrash2()
    {
        
        if (trash2 != null)
        {
            camion.SetDestination(trash2.transform.position);
            print("going2");
        }
    }

    public void GoTrash3()
    {
        
        if (trash3 != null)
        {
            camion.SetDestination(trash3.transform.position);
            print("going3");
        }
    }
}
