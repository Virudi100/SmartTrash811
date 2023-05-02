using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;
    private GameObject newPrefab0;
    private GameObject newPrefab1;
    private GameObject newPrefab2;
    private GameObject newPrefab3;
    private GameObject newPrefab4;
    private GameObject newPrefab5;
    private GameObject newPrefab6;
    private GameObject newPrefab7;
    private GameObject newPrefab8;

    [Header("Tableau du tapis")]
    [SerializeField] private GameObject[] boardArray;

    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage trackedImage in args.added)
        {
            //Creer l'objet
            if(trackedImage.referenceImage.name == "ParalleleTrain")
            {
                newPrefab0 = Instantiate(boardArray[0], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "ParalleleTerrainJeu")
            {
                newPrefab1 = Instantiate(boardArray[1], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CroisementHopital")
            {
                newPrefab2 = Instantiate(boardArray[2], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CroisementBatimentRouge")
            {
                newPrefab3 = Instantiate(boardArray[3], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleImmeuble")
            {
                newPrefab4 = Instantiate(boardArray[4], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleEcole")
            {
                newPrefab5 = Instantiate(boardArray[5], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleParc")
            {
                newPrefab6 = Instantiate(boardArray[6], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleFontaine")
            {
                newPrefab7 = Instantiate(boardArray[7], trackedImage.transform.position, trackedImage.transform.rotation);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleZoo")
            {
                newPrefab8 = Instantiate(boardArray[8], trackedImage.transform.position, trackedImage.transform.rotation);
            }

        }
        foreach (ARTrackedImage trackedImage in args.updated)
        {
            foreach(GameObject board in boardArray)
            {
                //L'objet suis l'image
                board.transform.position = trackedImage.transform.position;
                board.transform.rotation = trackedImage.transform.rotation;
            }
            

        }
        foreach (ARTrackedImage trackedImage in args.removed)           //Detruit l'object
        {
            if (trackedImage.referenceImage.name == "ParalleleTrain")
            {
                Destroy(newPrefab0.gameObject);
            }
            else if (trackedImage.referenceImage.name == "ParalleleTerrainJeu")
            {
                Destroy(newPrefab1.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CroisementHopital")
            {
                Destroy(newPrefab2.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CroisementBatimentRouge")
            {
                Destroy(newPrefab3.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleImmeuble")
            {
                Destroy(newPrefab4.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleEcole")
            {
                Destroy(newPrefab5.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleParc")
            {
                Destroy(newPrefab6.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleFontaine")
            {
                Destroy(newPrefab7.gameObject);
            }
            else if (trackedImage.referenceImage.name == "CentreVilleZoo")
            {
                Destroy(newPrefab8.gameObject);
            }
        }
    }
}

