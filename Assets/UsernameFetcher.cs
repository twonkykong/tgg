using UnityEngine;
using TMPro;

public class UsernameFetcher : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;

    public void FetchName(string name)
    {
        nameText.text = name;
    }
}
