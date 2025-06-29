using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shopui : MonoBehaviour
{
    public Button shop;
    // Start is called before the first frame update
    void Start()
    {
        shop.onClick.AddListener(ShopOpenButton);
    }

    // Update is called once per frame
    void ShopOpenButton()
    {
        SceneManager.LoadScene("rank");
    }
}
