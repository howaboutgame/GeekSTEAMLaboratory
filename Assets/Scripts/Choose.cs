using UnityEngine;
using System.Collections;

public class Choose : MonoBehaviour {
    public Camera carmera;     //拽入相机

    public GameObject ball1;     //拽入球1
    public GameObject stick1;     //拽入木条1

    public GameObject state_stick1;     //拽入说明按钮
    public GameObject state_stick2;     //拽入说明按钮
    public GameObject state_stick3;     //拽入说明按钮
    public GameObject state_stick4;     //拽入说明按钮
    public GameObject state_glue;     //拽入说明按钮
    public GameObject state_rubber;     //拽入说明按钮
    public GameObject state_basket;     //拽入说明按钮
    public GameObject state_ball1;     //拽入说明按钮
    public GameObject state_ball2;     //拽入说明按钮
    public GameObject state_ball3;     //拽入说明按钮
    public GameObject state_glass1;     //拽入说明按钮
    public GameObject state_glass2;     //拽入说明按钮
    public GameObject state_glass3;     //拽入说明按钮
    public GameObject state_glass4;     //拽入说明按钮
    public GameObject state_glass5;     //拽入说明按钮
    public GameObject state_glass6;     //拽入说明按钮
    void Start()
    {
        state_stick1.SetActive(false);    //隐藏物品属性按钮
        state_stick2.SetActive(false);    //隐藏物品属性按钮
        state_stick3.SetActive(false);    //隐藏物品属性按钮
        state_stick4.SetActive(false);    //隐藏物品属性按钮
        state_glue.SetActive(false);    //隐藏物品属性按钮
        state_rubber.SetActive(false);    //隐藏物品属性按钮
        state_basket.SetActive(false);    //隐藏物品属性按钮
        state_ball1.SetActive(false);    //隐藏物品属性按钮
        state_ball2.SetActive(false);    //隐藏物品属性按钮
        state_ball3.SetActive(false);    //隐藏物品属性按钮
        state_glass1.SetActive(false);    //隐藏物品属性按钮
        state_glass2.SetActive(false);    //隐藏物品属性按钮
        state_glass3.SetActive(false);    //隐藏物品属性按钮
        state_glass4.SetActive(false);    //隐藏物品属性按钮
        state_glass5.SetActive(false);    //隐藏物品属性按钮
        state_glass6.SetActive(false);    //隐藏物品属性按钮
    }
    void Update()
    {
        if (Input.GetMouseButton(0))    //判断鼠标是否按下
        {
            Vector3 camera = Camera.main.WorldToScreenPoint(transform.position);             // 相机的世界坐标转换为屏幕坐标
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.z);
            Ray ray = carmera.GetComponent<Camera>().ScreenPointToRay(pos);//从摄像机发出到点击坐标的射线
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))          //判断射线是否碰到该物品
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red);//划出射线，只有在scene视图中才能看到
                Debug.Log(hit.collider.name);       //打印射线选中的物体名称；
                state_stick1.SetActive(false);    //隐藏物品属性按钮
                state_stick2.SetActive(false);    //隐藏物品属性按钮
                state_stick3.SetActive(false);    //隐藏物品属性按钮
                state_stick4.SetActive(false);    //隐藏物品属性按钮
                state_glue.SetActive(false);    //隐藏物品属性按钮
                state_rubber.SetActive(false);    //隐藏物品属性按钮
                state_basket.SetActive(false);    //隐藏物品属性按钮
                state_ball1.SetActive(false);    //隐藏物品属性按钮
                state_ball2.SetActive(false);    //隐藏物品属性按钮
                state_ball3.SetActive(false);    //隐藏物品属性按钮
                state_glass1.SetActive(false);    //隐藏物品属性按钮
                state_glass2.SetActive(false);    //隐藏物品属性按钮
                state_glass3.SetActive(false);    //隐藏物品属性按钮
                state_glass4.SetActive(false);    //隐藏物品属性按钮
                state_glass5.SetActive(false);    //隐藏物品属性按钮
                state_glass6.SetActive(false);    //隐藏物品属性按钮
                if (hit.collider.name == "Glue") state_glue.SetActive(true);
                if (hit.collider.name == "Rubber") state_rubber.SetActive(true);
                if (hit.collider.name == "Stick1") state_stick1.SetActive(true);   //当木条1被选中时显示木条1说明
                if (hit.collider.name == "Stick2") state_stick2.SetActive(true);
                if (hit.collider.name == "Stick3") state_stick3.SetActive(true);
                if (hit.collider.name == "Stick4") state_stick4.SetActive(true);
                if (hit.collider.name == "Basket") state_basket.SetActive(true);
                if (hit.collider.name == "Ball1") state_ball1.SetActive(true);      //当球1被选中时显示球1说明
                if (hit.collider.name == "Ball2") state_ball2.SetActive(true);
                if (hit.collider.name == "Ball3") state_ball3.SetActive(true);
                if (hit.collider.name == "Glass1") state_glass1.SetActive(true);
                if (hit.collider.name == "Glass2") state_glass2.SetActive(true);
                if (hit.collider.name == "Glass3") state_glass3.SetActive(true);
                if (hit.collider.name == "Glass4") state_glass4.SetActive(true);
                if (hit.collider.name == "Glass5") state_glass5.SetActive(true);
                if (hit.collider.name == "Glass6") state_glass6.SetActive(true);

            }
        }
    }
}
