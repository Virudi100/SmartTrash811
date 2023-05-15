using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class TrackedImage : MonoBehaviour
{
    [Header("AR Session Origin's Components")]
    [SerializeField] private ARTrackedImageManager manager;

    [Header("Tableau de map")]
    [SerializeField] private GameObject[] mapArray;

    [SerializeField] private GameObject[] prefabArray = new GameObject[9];

    private void OnEnable()
    {
        manager.trackedImagesChanged += OnTrackedImageChange;
    }

    private void OnDisable()
    {
        manager.trackedImagesChanged -= OnTrackedImageChange;
    }

    private void OnTrackedImageChange(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage trackedImage in args.added)         //Une image est détecté
        {
            if (trackedImage.referenceImage.name == "ParalleleTrain" && prefabArray[0] == null)
            {
                prefabArray[0] = Instantiate(mapArray[0], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "ParalleleTerrainJeu"&& prefabArray[1] == null)
            {
                prefabArray[1] = Instantiate(mapArray[1], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CroisementHopital" && prefabArray[2] == null)
            {
                prefabArray[2] = Instantiate(mapArray[2], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CroisementBatimentRouge" && prefabArray[3] == null)
            {
                prefabArray[3] = Instantiate(mapArray[3], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CentreVilleImmeuble" && prefabArray[4] == null)
            {
                prefabArray[4] = Instantiate(mapArray[4], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CentreVilleEcole" && prefabArray[5] == null)
            {
                prefabArray[5] = Instantiate(mapArray[5], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CentreVilleParc" && prefabArray[6] == null)
            {
                prefabArray[6] = Instantiate(mapArray[6], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CentreVilleFontaine" && prefabArray[7] == null)
            {
                prefabArray[7] = Instantiate(mapArray[7], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            if (trackedImage.referenceImage.name == "CentreVilleZoo" && prefabArray[8] == null)
            {
                prefabArray[8] = Instantiate(mapArray[8], trackedImage.transform.position, trackedImage.transform.rotation);
            }
        }
        foreach (ARTrackedImage trackedImage in args.updated)       //update de l'image
        {
            if (trackedImage.referenceImage.name == "ParalleleTrain")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[0].transform.position = position;
                prefabArray[0].transform.rotation = rotation;

            }
            if (trackedImage.referenceImage.name == "ParalleleTerrainJeu")
            { 
                Vector3 position = trackedImage.transform.position ;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[1].transform.position = position;
                prefabArray[1].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CroisementHopital")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[2].transform.position = position;
                prefabArray[2].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CroisementBatimentRouge")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[3].transform.position = position;
                prefabArray[3].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CentreVilleImmeuble")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[4].transform.position = position;
                prefabArray[4].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CentreVilleEcole")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[5].transform.position = position;
                prefabArray[5].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CentreVilleParc")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[6].transform.position = position;
                prefabArray[6].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CentreVilleFontaine")
            {

                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[7].transform.position = position;
                prefabArray[7].transform.rotation = rotation;
            }
            if (trackedImage.referenceImage.name == "CentreVilleZoo")
            {
                Vector3 position = trackedImage.transform.position;
                Quaternion rotation = trackedImage.transform.rotation;

                prefabArray[8].transform.position = position;
                prefabArray[8].transform.rotation = rotation;
            }
        }
        foreach (ARTrackedImage trackedImage in args.removed)           //Detruit l'object
        {
            if (trackedImage.referenceImage.name == "ParalleleTrain")
            {
                if (prefabArray[0] != null)
                {
                    Destroy(prefabArray[0]);
                }
            }
            if (trackedImage.referenceImage.name == "ParalleleTerrainJeu")
            {
                if (prefabArray[1] != null)
                {
                    Destroy(prefabArray[1]);
                }
            }
            if (trackedImage.referenceImage.name == "CroisementHopital")
            {
                if (prefabArray[2] != null)
                {
                    Destroy(prefabArray[2]);
                }
            }
            if (trackedImage.referenceImage.name == "CroisementBatimentRouge")
            {
                if (prefabArray[3] != null)
                {
                    Destroy(prefabArray[3]);
                }
            }
            if (trackedImage.referenceImage.name == "CentreVilleImmeuble")
            {
                if (prefabArray[4] != null)
                {
                    Destroy(prefabArray[4]);
                }
            }
            if (trackedImage.referenceImage.name == "CentreVilleEcole")
            {
                if (prefabArray[5] != null)
                {
                    Destroy(prefabArray[5]);
                }
            }
            if (trackedImage.referenceImage.name == "CentreVilleParc")
            {
                if (prefabArray[6] != null)
                {
                    Destroy(prefabArray[6]);
                }
            }
            if (trackedImage.referenceImage.name == "CentreVilleFontaine")
            {
                if (prefabArray[7] != null)
                {
                    Destroy(prefabArray[7]);
                }
            }
            if (trackedImage.referenceImage.name == "CentreVilleZoo")
            {
                if (prefabArray[8] != null)
                {
                    Destroy(prefabArray[8]);
                }
            }
        }
    }
}
