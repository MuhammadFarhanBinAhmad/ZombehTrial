﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int bullet_Speed = 2;

    private void FixedUpdate()
    {
        transform.position += transform.right * bullet_Speed;
    }
}
