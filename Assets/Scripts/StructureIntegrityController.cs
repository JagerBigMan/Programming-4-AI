using UnityEngine;
using NodeCanvas.Framework;

public class StructureIntegrityController : MonoBehaviour
{
    public Blackboard droneBlackboard;
    void Update()
    {
        if (droneBlackboard == null) return;
        float integrity = droneBlackboard.GetVariableValue<float>("StructuralIntegrity");

    }
}
