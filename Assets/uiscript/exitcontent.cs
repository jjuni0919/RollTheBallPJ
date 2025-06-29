using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitcontent : MonoBehaviour
{
    public Button exitbutton;
    // Start is called before the first frame update
    void Start()
    {
        exitbutton.onClick.AddListener(ExitButton);
    }

    // Update is called once per frame
    void ExitButton()
    {
        SceneManager.LoadScene("main"); 
    }
}
