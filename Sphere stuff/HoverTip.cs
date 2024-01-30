using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("HOVERED");
    }

public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}

//void Start()
//{
//    Cursor.visible = true;
//    GameObject.SetActive(false);
//}
//void Update()
//{
//    Transform.position = Input.mousePosition;
//}
//public void SetAndShowToolTIP(string message)
//{
//    GameObject.SetActie
//}