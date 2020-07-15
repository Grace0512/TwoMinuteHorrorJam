using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorRotate : HorroObject
{
    [Header("旋轉物件")]
    public Transform rota;
    [Header("旋轉角度"),Range(90,270)]
    public float angle = 120;
    [Header("旋轉速度"), Range(1, 100)]
    public float speed = 10;


    public override void TriggerEvent()
    {
        StartCoroutine(Roatate());
    }

    private IEnumerator Roatate()
    {
        GetComponentInChildren<BoxCollider>().enabled = false;

        float y = rota.localEulerAngles.y;
        float targetY = y + angle;

        while (y<targetY)
        {
            rota.localEulerAngles += Vector3.up * Time.deltaTime * speed;
            y -= Time.deltaTime * speed; 
            yield return null;
        }
       
    }
}
