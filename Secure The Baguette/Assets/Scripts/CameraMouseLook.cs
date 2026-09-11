using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;

#pragma warning disable CS0618

public class CameraMouseLook : MonoBehaviour, AxisState.IInputAxisProvider
{
    public float xGain = 1f;
    public float yGain = 1f;

    public float GetAxisValue(int axis)
    {
        if (Mouse.current == null)
            return 0f;

        Vector2 delta = Mouse.current.delta.ReadValue();
        switch (axis)
        {
            case 0: return delta.x * xGain;
            case 1: return delta.y * yGain;
            default: return 0f;
        }
    }
}