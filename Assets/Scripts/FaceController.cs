using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceController : MonoBehaviour
{
    [SerializeField] ARFaceManager faceManager;
    [SerializeField] GameObject nosePrefab;

    private GameObject noseTracker;

    private void Awake()
    {
        GameObject canvas = GameObject.Find("Canvas");
        noseTracker = Instantiate(nosePrefab, canvas.transform);
    }

    private void OnEnable()
    {
        faceManager.facesChanged += OnFaceChange;
    }

    private void OnDisable()
    {
        faceManager.facesChanged -= OnFaceChange;
    }

    private void OnFaceChange(ARFacesChangedEventArgs args)
    {
        if (args.updated.Count > 0)
        {
            ARFace face = args.updated[0];

            Vector3 nosePos = face.transform.TransformPoint(face.vertices[4]);

            noseTracker.transform.position = nosePos;
        }
    }
}
