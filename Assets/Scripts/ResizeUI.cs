using UnityEngine;

public class ResizeUI : MonoBehaviour
{
    [SerializeField] private RectTransform target;

    private Vector3 originalScale;

    private void Awake()
    {
        originalScale = target.localScale;
    }

    public void ChangeX(float percent)
    {
        float scale = percent / 100f;

        target.localScale = new Vector3(
            originalScale.x * scale,
            target.localScale.y,
            originalScale.z
        );
    }

    public void ChangeY(float percent)
    {
        float scale = percent / 100f;

        target.localScale = new Vector3(
            target.localScale.x,
            originalScale.y * scale,
            originalScale.z
        );
    }
}
