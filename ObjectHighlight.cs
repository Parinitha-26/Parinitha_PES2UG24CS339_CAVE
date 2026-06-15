using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    public Material highlightMaterial;

    private Material originalMaterial;
    private Renderer rend;

    private bool highlighted = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalMaterial = rend.material;
    }

    void OnMouseDown()
    {
        highlighted = !highlighted;

        if (highlighted)
        {
            rend.material = highlightMaterial;
        }
        else
        {
            rend.material = originalMaterial;
        }
    }
}
