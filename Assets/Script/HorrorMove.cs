using System;
using UnityEngine;
using System.Collections;

public class HorrorMove : HorroObject
{
    [Header("移動物件")]
    public Transform move;
    [Header("前往位置")]
    public Transform target;
    [Header("移動速度"),Range(1,100)]
    public float speed;


    public override void TriggerEvent()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        float dis = Vector3.Distance(move.position, target.position);

        while (dis >= 0.2f)
        {
            move.position = Vector3.Lerp(move.position, target.position, Time.deltaTime * 0.5f * speed);
            yield return null;
        }
    }
}
