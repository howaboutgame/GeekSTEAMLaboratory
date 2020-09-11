using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Move4 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject stick1;     //拽入木条1
    public GameObject glue;     //拽入胶水

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 angles_glue = stick1.transform.localEulerAngles;          //获取木条1的角度
        angles_glue = new Vector3((angles_glue.x +240), (angles_glue.y +250), (angles_glue.z + 140));//调整胶水的角度
        glue.transform.localEulerAngles = angles_glue;          //旋转胶水的角度

        Vector3 position_glue = stick1.transform.position;     //获取木条1的坐标
        position_glue = new Vector3((position_glue.x + 0.05F), (position_glue.y + 0.08F), (position_glue.z + 0.036F));    //调整胶水的坐标
        glue.transform.position = position_glue;            //移动胶水的位置
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        print("抬起！！！！");
    }
}