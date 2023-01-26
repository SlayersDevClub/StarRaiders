using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraLerp : MonoBehaviour
{
    public float lerpSpeed = 5f; // the speed of the lerp
    public float cameraDistance = 20;
    private CinemachineVirtualCamera virtualCamera;

    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // when the left mouse button is clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine(LerpToTarget(hit.point));
            }
        }
    }

    IEnumerator LerpToTarget(Vector3 target)
    {
        while (Vector3.Distance(virtualCamera.transform.position, target) > 0.1f)
        {
            Vector3 v = Vector3.Lerp(virtualCamera.transform.position, target, lerpSpeed * Time.deltaTime);
            v.y = cameraDistance;
            virtualCamera.transform.position = v;
            yield return null;
        }
    }
}