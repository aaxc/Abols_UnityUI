using UnityEngine;
using UnityEngine.UI;

public class FighterSwitcher : MonoBehaviour
{
    [SerializeField] private Image targetImage;
    [SerializeField] private Sprite robotSprite;
    [SerializeField] private Sprite humanSprite;

    private SFXScript sfxScript;

    private void Start()
    {
        sfxScript = FindFirstObjectByType<SFXScript>();
    }

    public void OnDropdownChanged(int index)
    {
        if (index == 0)
        {
            sfxScript.PlaySFX(1);
            targetImage.sprite = robotSprite;
        }

        if (index == 1)
        {
            sfxScript.PlaySFX(2);
            targetImage.sprite = humanSprite;
        }
    }
}