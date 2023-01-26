using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayActivate : MonoBehaviour
{
    public GameObject awakenObject;

    private void Awake()
    {
        Invoke("AwakenGameObject", 1f);
    }
   void AwakenGameObject()
    {
        awakenObject.SetActive(true);
    }
}
