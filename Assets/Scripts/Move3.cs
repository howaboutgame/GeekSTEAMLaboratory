using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Move3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject stick2;     //拽入木条2
    public GameObject stick4;     //拽入木条4

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 angles_stick4 = stick2.transform.localEulerAngles;          //获取木条2的角度
        angles_stick4 = new Vector3((angles_stick4.x - 135), (angles_stick4.y), (angles_stick4.z + 12));//调整木条4的角度
        stick4.transform.localEulerAngles = angles_stick4;          //旋转木条4的角度

        Vector3 position_stick4 = stick2.transform.position;     //获取木条2的坐标
        position_stick4 = new Vector3((position_stick4.x - 0.02F), (position_stick4.y - 0.02F), (position_stick4.z - 0.06F));    //调整木条4的坐标
        stick4.transform.position = position_stick4;            //移动木条4的位置
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        print("抬起！！！！");
    }
}