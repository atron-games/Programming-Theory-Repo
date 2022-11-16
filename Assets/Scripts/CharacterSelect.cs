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

    // Start is called before the first frame update
    void Start()
    {
        cat.onClick.AddListener(loadCat);
        kitten.onClick.AddListener(loadKitten);
        go.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void loadCat()
    {
        Debug.Log("i load the cat");
    }

    void loadKitten()
    {
        Debug.Log("i load the kitten");
    }

    void StartGame()
    {
        Debug.Log("i start the game");
    }
}
