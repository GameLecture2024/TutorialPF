using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    ParticleSystem dust;
    Animator animator;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        dust = GetComponentInChildren<ParticleSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        // 플레이어가 시작할 때 내가 지정한 위치로 이동하라.
        transform.position = playerStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 입력을 받아와야 한다
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            SoundManager.Instance?.PlaySFX("Jump");
            CreateDust(); 
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }

        // 입력에 맞는 방향을 설정하는 법
        // 캐릭터가 방향
        // 시간 속력 움직인 거리
    }

    void CreateDust()
    {
        dust.Play();
    }
}
