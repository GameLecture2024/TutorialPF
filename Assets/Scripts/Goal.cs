using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 스테이지를 클리어했습니다.
        Debug.Log("스테이지를 클리어했습니다.");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("충돌 지점에서 벗어났습니다.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("충돌 진행 중입니다.");
    }
}