using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Begin : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject welcome;
    public GameObject begin;

    public void OnPointerDown(PointerEventData eventData)
    {
        print("按下！！！！");
        welcome.SetActive(false);
        begin.SetActive(false);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        print("抬起！！！！");
    }
}