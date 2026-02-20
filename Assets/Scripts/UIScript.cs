using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject beans;
    public GameObject teddy;
    public GameObject granny;
    public GameObject car;

    public GameObject toggleLeft;
    public GameObject toggleRight;

    public GameObject imageField;
    public Sprite[] sprites;

    public GameObject rotationSlider;
    public GameObject scaleSlider;


    public void ChangeSprite(int val)
    {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void Rotate()
    {
        float currentValue = rotationSlider.GetComponent<Slider>().value;
        imageField.transform.rotation = Quaternion.Euler(0, 0, currentValue * 360);
    }

    public void Scale()
    {
        float currentValue = scaleSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f * currentValue, 1f * currentValue);
    }
}
