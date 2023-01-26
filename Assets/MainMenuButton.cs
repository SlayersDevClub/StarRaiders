using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class MainMenuButton : MonoBehaviour
{
    public Vector3 punchScale = new Vector3(2, 2, 2);
    public float duration;
    RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = this.GetComponent<RectTransform>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        rect.DOPunchScale(punchScale, duration);
    }
}
