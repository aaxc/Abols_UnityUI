using UnityEngine;

public class WearableToggle : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;

    private void Start()
    {
        targetObject.SetActive(false);
    }

    public void Toggle(bool state)
    {
        Debug.Log($"Toggle called: {state} | Target: {targetObject.name}");
        targetObject.SetActive(state);
    }
}
