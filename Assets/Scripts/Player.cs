using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            GameManager.Instance.RestartGame();
        }
        else if (collision.gameObject.tag == "Respawn")
        {
            GameManager.Instance.StartGame();
        }
        else
        {
            GameManager.Instance.GameOver();
        }
    }
}
