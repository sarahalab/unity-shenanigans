using UnityEngine;
using Cinemachine;

/// <summary>
<<<<<<< HEAD:487-catrun/Assets/scripts/CameraLock.cs
/// An add-on module for Cinemachine Virtual Camera that locks the camera's Y co-ordinate
=======
/// An add-on module for Cinemachine Virtual Camera that locks the camera's X co-ordinate
>>>>>>> 3a1d5a9f7c5080d73c924a6fbb38cf1fb72a16e5:487 project 1/Assets/scripts/CameraLock.cs
/// </summary>
[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")] // Hide in menu
public class cameralock : CinemachineExtension
{
    [Tooltip("Lock the camera's Y position to this value")]
    public float m_YPosition = 0;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Finalize)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }
}