using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;


public class PlayerManager : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float horizontalInput, verticalInput;

    [SerializeField] private float speed = 3.0f;    // 歩行速度
    [SerializeField] private float jumpSpeed = 8.0F;      // ジャンプ力
    [SerializeField] private float gravity = 9.8f;    // 重力
    [SerializeField] private float rotateSpeed = 3.0F;    // 回転速度



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");    //左右矢印キーの値(-1.0~1.0)
        verticalInput = Input.GetAxis("Vertical");      //上下矢印キーの値(-1.0~1.0)

        if (controller.isGrounded)
        {
            gameObject.transform.Rotate(new Vector3(0, rotateSpeed * horizontalInput, 0));
            moveDirection = speed * verticalInput * gameObject.transform.forward;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
