﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover
{
    public Vector3 moveVector { get; private set; }

    const float distancePerSec = 5f;

    // 引数にlastPositionを追加して、状態変数をpositionにしてもいいかも
    public void Move(Vector2 input, Vector3 direction)
    {
        // todo NavMesh仕様にしたい
        var inputVector3 = new Vector3(input.x, 0, input.y);
        moveVector = Quaternion.LookRotation(direction) * inputVector3 * Time.deltaTime * distancePerSec;
    }
}
