using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NavigationBaker : MonoBehaviour
{

    private NavMeshSurface surfaces;

    private void Start()
    {
        surfaces = gameObject.GetComponent<NavMeshSurface>();
    }

    private void FixedUpdate()
    {
        surfaces.BuildNavMesh();
        print("Navmesh calculated");
    }
}
