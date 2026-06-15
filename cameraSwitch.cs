using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    private int currentCamera = 0;

    void Start()
    {
        ShowCamera(0);
    }

    public void SwitchCamera()
    {
        currentCamera++;

        if (currentCamera > 2)
        {
            currentCamera = 0;
        }

        ShowCamera(currentCamera);
    }

    void ShowCamera(int index)
    {
        camera1.gameObject.SetActive(index == 0);
        camera2.gameObject.SetActive(index == 1);
        camera3.gameObject.SetActive(index == 2);
    }
}