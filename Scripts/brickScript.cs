using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickScript : MonoBehaviour
{
    public UIManager ui;
    public Rigidbody2D rb;

    public float fallSpeed = 1f;

    // Get access to bricks
    Rigidbody2D blueBrick;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("UI").GetComponent<UIManager>();
    //    blueBrick = GameObject.FindWithTag("BlueBrick").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // blueBrick.velocity = new Vector2(0, -fallSpeed);

        rb.velocity = new Vector2(0, -fallSpeed);

    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
            ui.IncreaseScore();
            Destroy(gameObject);
		}
	}

}
