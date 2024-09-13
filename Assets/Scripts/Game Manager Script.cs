using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    int score = 0;
    bool isGameOver = false;

    public static GameManagerScript Instance;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit") && isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void InitiateGameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
