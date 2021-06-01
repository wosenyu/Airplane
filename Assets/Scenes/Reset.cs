using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Text NameBox;
    // Start is called before the first frame update
    void Start()
    {
        if(NameBox != null)
        {
        NameBox.text = PlayerPrefs.GetString("name");
        }
    }

    public void ResetSavedGame()
    {
        PlayerPrefs.DeleteKey("name");
        SceneManager.LoadScene("Menu");
    }

}
