using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Move1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject stick1;     //拽入球1
    public GameObject stick2;     //拽入木条1

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 angles_stick2 = stick1.transform.localEulerAngles;          //获取木条1的角度
        stick2.transform.localEulerAngles = angles_stick2;          //旋转木条2的角度

        Vector3 position_stick2 = stick1.transform.position;     //获取木条1的坐标
        position_stick2 = new Vector3((position_stick2.x + 0.1F), position_stick2.y, position_stick2.z );    //调整球1的坐标
        stick2.transform.position = position_stick2;            //移动球1的位置
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        print("抬起！！！！");
    }
}