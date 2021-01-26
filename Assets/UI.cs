using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{

    public GameObject Player;
    public GameObject StartPanel;
    private int score;
    public Text Points;
    float initialGravity=1;
    void Start()
    {
       FreezePlayer();
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ColorChanger")
        {
            score++;
            Points.text = "Score: " + score;
            return;

        }
        
    }
    
    public void pressButton()
    {
        StartPanel.SetActive(false);
    }

    public void FreezePlayer()
    {
        Rigidbody2D rb= Player.GetComponent<Rigidbody2D>();
        initialGravity=rb.gravityScale;
        rb.gravityScale=0;
        rb.isKinematic = true;
    
    }
    public void UnFreezePlayer()
    {
        Rigidbody2D rb =Player.GetComponent<Rigidbody2D>();
        rb.gravityScale = initialGravity;
        rb.isKinematic = false;
        
        
    }




}