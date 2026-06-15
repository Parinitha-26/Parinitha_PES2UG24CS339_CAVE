using UnityEngine;

public class ScreenToggle : MonoBehaviour
{
    public Vector3 openPosition;
    public Vector3 closedPosition;

    private bool isOpen = false;

    public void ToggleScreen()
    {
        if (isOpen)
        {
            transform.position = closedPosition;
        }
        else
        {
            transform.position = openPosition;
        }

        isOpen = !isOpen;
    }
}
