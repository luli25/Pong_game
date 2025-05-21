using UnityEngine;

public class MatchConfig : MonoBehaviour
{
    public void SelectMatch(string selection)
    {
        PlayerPrefs.SetString("MatchSelection", selection);
        PlayerPrefs.Save();
    }
}
