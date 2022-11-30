using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    public GameObject startCanvas;
    // Start is called before the first frame update
    
    private void Start()
    {
        Time.timeScale = 0;
        startCanvas.SetActive(true);
        gameoverCanvas.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
        startCanvas.SetActive(false);
        Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    public void GameOver()
    {
        Time.timeScale = 0;
        gameoverCanvas.SetActive(true);
    }
}
