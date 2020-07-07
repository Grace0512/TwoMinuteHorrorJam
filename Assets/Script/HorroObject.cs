using UnityEngine;

public class HorroObject : MonoBehaviour, ITiggerEvent
{
    /// <summary>
    /// 允許子類別覆寫觸發事件
    /// </summary>
    /// <param name="other"></param>
    public virtual void TriggerEvent()
    {

    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();
    }

}
