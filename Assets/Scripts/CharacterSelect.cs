using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{


    public Button cat, kitten, go;
    public GameObject catPrefab, kittenPrefab;
    public int selection = 0;
    public float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        cat.onClick.AddListener(loadCat);
        kitten.onClick.AddListener(loadKitten);
        go.onClick.AddListener(StartGame);

        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (-8 > t && t > -9)
        {
            LoadCharacter(selection);
        }
    }


    void loadCat()
    {
        Debug.Log("i load the cat");
        selection = 1;
    }

    void loadKitten()
    {
        Debug.Log("i load the kitten");
        selection = 2;
    }

    public void StartGame()
    {
        Debug.Log("i start the game");
        if(selection == 0)
        {
            Debug.Log("You must select a character!");
        }
        else
        {
            SceneManager.LoadScene(1);
            t = -10;
        }
    }

    void LoadCharacter(int i)
    {
        if (i == 1)
        {
            Instantiate(catPrefab);
            t = 10;
        }
        else
        {
            Instantiate(kittenPrefab);
            t = 10;
        }
    }
    
}
