using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;

    public UIManager ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("UI").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyUp(KeyCode.Space) && !gameStarted)
		{
            transform.SetParent(null);
            rb.isKinematic = false;

            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }

        // Destroy ball if game is won
		if (ui.gameWon)
		{
            Destroy(gameObject);
		}
    }
}
