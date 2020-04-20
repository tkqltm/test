using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
   void Update()
    {
        if(Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무키를 눌렀습니다.");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입하였습니다.");
                    }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동중");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
            {
            Debug.Log("오른쪽으로 이동중");
            }
        if(Input.GetKey(KeyCode.UpArrow))
            {
            Debug.Log("위로 이동중");
            }
    }
}
