using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GoalScript red;
    public GoalScript blue;
    public GoalScript green;
    public GoalScript orange;
    private bool isGameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (red.isSolved() && blue.isSolved() && orange.isSolved() && green.isSolved())
        {
            isGameOver = true;
        }
    }

    void OnGui()
    {
        if (isGameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75), "Game Over");
            GUI.Label(new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50), "Good Job!");
        }
    }
}
