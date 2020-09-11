using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Move2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject stick1;     //拽入木条1
    public GameObject stick3;     //拽入木条3

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 angles_stick3 = stick1.transform.localEulerAngles;          //获取木条1的角度
        angles_stick3 = new Vector3((angles_stick3.x - 135), (angles_stick3.y), (angles_stick3.z - 12));//调整木条3的角度
        stick3.transform.localEulerAngles = angles_stick3;          //旋转木条3的角度

        Vector3 position_stick3 = stick1.transform.position;     //获取木条1的坐标
        position_stick3 = new Vector3((position_stick3.x + 0.02F), (position_stick3.y - 0.02F), (position_stick3.z - 0.06F));    //调整木条3的坐标
        stick3.transform.position = position_stick3;            //移动木条3的位置
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        print("抬起！！！！");
    }
}