using UnityEngine;

namespace RoyTheunissen.GPUSplineDeformation
{
    public interface IDisplacementProvider
    {
        bool IsLooping { get; }

        Vector3 GetPositionAt(float fraction);
        Quaternion GetRotationAt(float fraction);
        Vector3 GetScaleAt(float fraction);
    }
}
