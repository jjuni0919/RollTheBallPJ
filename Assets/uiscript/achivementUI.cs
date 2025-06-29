using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class achivementUI : MonoBehaviour
{
    public Button achievement;
    // Start is called before the first frame update
    void Start()
    {
        achievement.onClick.AddListener(AchievementOpenButton);
    }

    // Update is called once per frame
    void AchievementOpenButton()
    {
        SceneManager.LoadScene("achievement");
    }
}
