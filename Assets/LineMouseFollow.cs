using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LineMouseFollow : MonoBehaviour
{
    RectTransform rect;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();   
    }

    // Update is called once per frame
    void Update()
    {
        rect.DOMoveY(Input.mousePosition.y, speed);
    }
}
