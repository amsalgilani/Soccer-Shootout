using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameController : MonoBehaviour
{
    public Ball ball;
    public TextMesh infoText;

    private float endGameTimer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        infoText.text = "Shoot towards the goal!";
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.hitTarget)
        {
            if(ball.correctTarget == true)
            {
                infoText.text = "GOAL!!!";
            }
            else
            {
                infoText.text = "Try again!";
            }
            endGameTimer -= Time.deltaTime;
            if (endGameTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
