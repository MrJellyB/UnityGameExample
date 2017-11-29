using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerSpeed = 5;
    public int playerLives = 3;
    public static int playerScore;

    public Rigidbody bullet;
    
	// Update is called once per frame
	void Update ()
	{
	    float amountToMove = playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(Vector3.right*amountToMove);

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        Instantiate(bullet, transform.position, Quaternion.identity);
            
	    }

        if(playerScore >= 500)
            print("You Won !");
	}

    public void OnGUI()
    {
        GUI.Label(new Rect(10,10,200,30), "Score: " + playerScore );
        GUI.Label(new Rect(10,30,200,50), "Player lives: " + playerLives );
    }

    public void OnTriggerEnter(Collider other)
    {
        playerLives--;
        other.gameObject.transform.position = new Vector3(Random.Range(-6, 6), 7);
    }
}
