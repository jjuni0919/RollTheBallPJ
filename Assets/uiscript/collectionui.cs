using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collectionui : MonoBehaviour
{
    public Button collection;
    // Start is called before the first frame update
    void Start()
    {
        collection.onClick.AddListener(CollectionOpenButton);
    }

    // Update is called once per frame
    void CollectionOpenButton()
    {
        SceneManager.LoadScene("collection");
    }
}
