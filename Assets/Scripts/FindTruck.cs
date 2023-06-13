using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTruck : MonoBehaviour
{
    [SerializeField] private GameObject truck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (truck == null)
        {
            truck = GameObject.FindWithTag("Player");
        }
    }

    public void Gotrash1v2()
    {
        truck.GetComponent<TruckIA>().GoTrash1();
    }

    public void Gotrash2v2()
    {
        truck.GetComponent<TruckIA>().GoTrash2();
    }

    public void Gotrash3v2()
    {
        truck.GetComponent<TruckIA>().GoTrash3();
    }
}
