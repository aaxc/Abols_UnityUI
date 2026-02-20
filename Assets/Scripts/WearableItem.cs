using UnityEngine;
using UnityEngine.UI;

public class WearableItem : MonoBehaviour
{
    [SerializeField] private WearableSlot targetSlot;

    private Image previewImage;

    private void Awake()
    {
        previewImage = GetComponent<Image>();
    }

    public void Apply()
    {
        targetSlot.SetSprite(previewImage.sprite);
    }
}
