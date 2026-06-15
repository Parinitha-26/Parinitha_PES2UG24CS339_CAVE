using UnityEngine;

public class LightToggle : MonoBehaviour
{
    public Light[] roomLights;

    void Start()
    {
        foreach (Light lightObj in roomLights)
        {
            lightObj.enabled = false;
        }
    }

    public void ToggleLights()
    {
        foreach (Light lightObj in roomLights)
        {
            lightObj.enabled = !lightObj.enabled;
        }
    }
}