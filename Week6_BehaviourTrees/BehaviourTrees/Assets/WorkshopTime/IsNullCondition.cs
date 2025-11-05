using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "IsNull", story: "Is [Enemy] Null", category: "Conditions", id: "258d5fdb970eaef87a29743e562c0826")]
public partial class IsNullCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Enemy;

    public override bool IsTrue()
    {
        return (Enemy.Value == null);
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
