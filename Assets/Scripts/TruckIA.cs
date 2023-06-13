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

    [SerializeField] private bool trash1Empty = false;
    [SerializeField] private bool trash2Empty = false;
    [SerializeField]private bool trash3Empty = false;

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
            if (new Vector3(camion.transform.position.x, 0,camion.transform.position.z) == new Vector3 (trash1.transform.position.x,0,trash1.transform.position.z))
            {
                isAtDestination1 = true;
                trash2Empty = false;
                trash3Empty = false;
            }
            else
                isAtDestination1 = false;
        }
        if(trash2 != null)
        {
            if (new Vector3(camion.transform.position.x, 0, camion.transform.position.z) == new Vector3(trash2.transform.position.x, 0, trash2.transform.position.z))
            {
                isAtDestination2 = true;
                trash1Empty = false;
                trash3Empty = false;
            }
            else
                isAtDestination2 = false;
        }
        if(trash3 != null)
        {
            if (new Vector3(camion.transform.position.x, 0, camion.transform.position.z) == new Vector3(trash3.transform.position.x, 0, trash3.transform.position.z))
            {
                isAtDestination3 = true;
                trash1Empty = false;
                trash2Empty = false;
            }
            else
                isAtDestination3 = false;
        }
        /////////////////////////////////////////////
        
        if(isAtDestination1 && !trash1Empty)
        {
            trash1.GetComponent<Animator>().SetTrigger("Isvider");
            trash1Empty = true;
        }
        if(isAtDestination2 && !trash2Empty)
        {
            trash2.GetComponent<Animator>().SetTrigger("Isvider");
            trash2Empty = true;
        }
        if(isAtDestination3 && !trash3Empty)
        {
            trash3.GetComponent<Animator>().SetTrigger("Isvider");
            trash3Empty = true;
        }
    }

    public void GoTrash1()
    {
        
        if (trash1 != null)
        {
            camion.destination = trash1.transform.position;
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
