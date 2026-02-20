using UnityEngine;
using UnityEngine.UI;

public class FighterSwitcher : MonoBehaviour
{
    [SerializeField] private Image targetImage;
    [SerializeField] private Sprite robotSprite;
    [SerializeField] private Sprite humanSprite;

    [SerializeField] private GameObject contentRobot;
    [SerializeField] private GameObject contentHuman;

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

            contentRobot.SetActive(true);
            contentHuman.SetActive(false);
        }

        if (index == 1)
        {
            sfxScript.PlaySFX(2);
            targetImage.sprite = humanSprite;

            contentHuman.SetActive(true);
            contentRobot.SetActive(false);
        }
    }
}
