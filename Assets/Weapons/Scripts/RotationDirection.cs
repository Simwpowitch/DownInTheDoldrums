﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDirection
{
    public Vector3 direction;
    public Quaternion rotation;

    public RotationDirection(Direction inputDirection)
    {
        switch (inputDirection)
        {
            case Direction.Left:
                direction = Vector3.left * 1f;
                rotation = Quaternion.Euler(0, 0, 180);
                break;

            case Direction.Right:
                direction = Vector3.right * 1f;
                rotation = Quaternion.Euler(0, 0, 0);
                break;

            case Direction.Up:
                direction = Vector3.up * 1f;
                rotation = Quaternion.Euler(0, 0, 90);
                break;

            case Direction.Down:
                direction = Vector3.down * 1f;
                rotation = Quaternion.Euler(0, 0, 270);
                break;

            default:
                break;
        }
    }
}
