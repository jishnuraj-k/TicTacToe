using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    public Sprite[] images;
    bool unplayed = true;
    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    private void OnMouseDown()
    {
        if (unplayed)
        {
            int index = gameBoard.GetComponent<GameScript>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            unplayed = false;
        }
    }
/*    void WinnerCheck(int index)
    {
        int s1 = images[0] + images[1] + images[2];
        int s2 = images[3] + images[4] + images[5];
        int s3= images[6] + images[7] + images[8];
        int s4 = images[0] + images[3] + images[6];
        int s5 = images[1] + images[4] + images[7];
        int s6= images[0] + images[1] + images[2];
        int s7 = images[2] + images[5] + images[8];
        int s8 = images[0] + images[4] + images[8];
        int s9 = images[0] + images[4] + images[6];
        var solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8, s9 };
        for(int i = 0; i < solutions.Length; i++)
        {
            if(solutions[i] == )
        }
        
    }*/

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("GameBoard");
    } 
}
