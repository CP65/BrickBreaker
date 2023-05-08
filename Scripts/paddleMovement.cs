using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    float maxX = 2.4f;

    public UIManager ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("UI").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (!ui.gameWon && !ui.gameLost.lostGame)
        {
            if (x == 0)
            {
                rb.velocity = Vector2.zero;
            }

            else if (x > 0)
            {
                MoveRight();
            }

            else if (x < 0)
            {
                MoveLeft();
            }
        }
		else
		{
            rb.velocity = Vector2.zero;
		}

        //Restricting position
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
         
    }

    void MoveLeft()
    {
        rb.velocity = new Vector2(-moveSpeed, 0);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
    }

    

}
