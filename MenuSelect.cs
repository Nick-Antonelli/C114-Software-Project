using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour {
    public GameObject gameobject;

    void Start()
    {
    }
    public void BlueBird()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.SetActive(false);

        }
    }
}
