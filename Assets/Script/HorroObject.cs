using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HorroObject : MonoBehaviour, ITiggerEvent
{
    private Rigidbody rig;
    /// <summary>
    /// 允許子類別覆寫觸發事件
    /// </summary>
    /// <param name="other"></param>
    public virtual void TriggerEvent()
    {
       
    }

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;
        rig.constraints = RigidbodyConstraints.FreezeAll; //凍結全部

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();
    }

}
