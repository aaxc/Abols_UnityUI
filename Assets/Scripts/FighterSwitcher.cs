using UnityEngine;
using UnityEngine.UI;

public class FighterSwitcher : MonoBehaviour
{
    [SerializeField] private Image targetImage;
    [SerializeField] private Sprite robotSprite;
    [SerializeField] private Sprite humanSprite;

    public void OnDropdownChanged(int index)
    {
        if (index == 0)
        {
            targetImage.sprite = robotSprite;
        }

        if (index == 1)
        {
            targetImage.sprite = humanSprite;
        }
    }
}