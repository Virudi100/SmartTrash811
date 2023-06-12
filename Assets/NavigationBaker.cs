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

    // Use this for initialization
    void Update()
    {
        surfaces.voxelSize = 0.01f;
        surfaces.BuildNavMesh();
        print("Navmesh calculated");
    }
}
