using UnityEngine;
using UnityEngine.UI;

public class WearableSlot : MonoBehaviour
{
    [SerializeField] private Image mainImage;

    public void SetSprite(Sprite newSprite)
    {
        mainImage.sprite = newSprite;
    }
}
