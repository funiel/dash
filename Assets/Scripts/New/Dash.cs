﻿using System.Collections;
using UnityEngine;

public class Dash : MonoBehaviour
{

    public float speed = 10f;
    public DashState dashState;
    public float dashTimer;
    public float maxDash = 3f;
    private Rigidbody2D rigidbdy;
    private Vector3 worldMousePosition;
    private Vector3 direction;
    private Vector3 directionnorm;


    public Vector2 savedVelocity;

    private void Start()
    {
        rigidbdy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, rigidbdy.transform.position.z));
        direction = (worldMousePosition - rigidbdy.transform.position);
        directionnorm = direction * 100;

        switch (dashState)
        {
            case DashState.Ready:
                //var isDashKeyDown = Input.GetMouseButtonDown(0);
                //var isDashKeyDown2 = Input.GetMouseButtonDown(1);
                var isDashKeyDown3 = Input.GetKeyDown("escape");
                if (Input.anyKeyDown && !isDashKeyDown3)
                {
                    rigidbdy.AddForce(new Vector3(directionnorm.x * 3f * speed, directionnorm.y * speed, directionnorm.z));
                    dashState = DashState.Dashing;

                }
                break;

            case DashState.Dashing:
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    dashState = DashState.Cooldown;
                }

                break;

            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }


    public enum DashState
    {
        Ready,
        Dashing,
        Cooldown
    }

}

