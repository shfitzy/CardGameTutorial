using UnityEngine;

public class DebugTest : MonoBehaviour
{
    void Start()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;

        // Set resolution
        Screen.SetResolution(1920, 1080, false);
    }
}