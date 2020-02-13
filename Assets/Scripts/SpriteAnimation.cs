﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Left, Right, Up, Down }

public class SpriteAnimation : MonoBehaviour
{
    SpriteRenderer spriteRenderer = null;

    //Open for input through inspector, can also be set through methods below
    [SerializeField] Sprite[] left = null;
    [SerializeField] Sprite[] up = null;
    [SerializeField] Sprite[] down = null;

    [SerializeField] float framesPerSecond = 8;
    float updateFrequency = 0f;
    float updateTimer = 0f;
    int spriteIndex = 0;


    [SerializeField] Direction myDirection;
    bool isWalking = false;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        updateFrequency = 1f / framesPerSecond;
    }

    private void Update()
    {

        if (isWalking)
        {
            updateTimer += Time.deltaTime;

            if (updateTimer >= updateFrequency)
            {
                updateTimer -= updateFrequency;
                spriteIndex++;

                switch (myDirection)
                {
                    case Direction.Left:
                        if (spriteIndex >= left.Length)
                        {
                            spriteIndex = 0;
                        }
                        spriteRenderer.sprite = left[spriteIndex];
                        break;
                    case Direction.Right:
                        if (spriteIndex >= left.Length)
                        {
                            spriteIndex = 0;
                        }
                        spriteRenderer.sprite = left[spriteIndex];
                        break;
                    case Direction.Up:
                        if (spriteIndex >= up.Length)
                        {
                            spriteIndex = 0;
                        }
                        spriteRenderer.sprite = up[spriteIndex];
                        break;
                    case Direction.Down:
                        if (spriteIndex >= down.Length)
                        {
                            spriteIndex = 0;
                        }
                        spriteRenderer.sprite = down[spriteIndex];
                        break;
                }
            }
        }
    }

    public void SetDirection(Direction movingDirection)
    {
        if (movingDirection != myDirection)
        {
            myDirection = movingDirection;

            updateTimer = 0f;
            spriteIndex = 0;

            switch (myDirection)
            {
                case Direction.Left:
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    spriteRenderer.sprite = left[0];
                    break;
                case Direction.Right:
                    transform.localScale = new Vector3(-1f, 1f, 1f);
                    spriteRenderer.sprite = left[0];
                    break;
                case Direction.Up:
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    spriteRenderer.sprite = up[0];
                    break;
                case Direction.Down:
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    spriteRenderer.sprite = down[0];
                    break;
            }
        }
    }

    public void SetIsWalking(bool newState)
    {
        if (newState != isWalking)//if character changed between standing still and moving or vice versa
        {
            isWalking = newState;

            //If stopping
            if (!newState)
            {
                switch (myDirection)
                {
                    case Direction.Left:
                        spriteRenderer.sprite = left[0];
                        break;
                    case Direction.Right:
                        spriteRenderer.sprite = left[0];
                        break;
                    case Direction.Up:
                        spriteRenderer.sprite = up[0];
                        break;
                    case Direction.Down:
                        spriteRenderer.sprite = down[0];
                        break;
                }
            }
        }
    }

    public void SetSpriteLeft(Sprite[] sprites)
    {
        left = sprites;
    }

    public void SetSpriteUp(Sprite[] sprites)
    {
        up = sprites;
    }

    public void SetSpriteDown(Sprite[] sprites)
    {
        down = sprites;
    }
}
