using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int bulletSpeed = 10;
    public Transform explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float amountToMove = bulletSpeed * Time.deltaTime;
        transform.Translate(Vector3.up*amountToMove);

	    if (transform.position.y > 6)
	    {
	        Destroy(gameObject);
	    }
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            PlayerScript.playerScore += 100;
            other.transform.position = new Vector3(Random.Range(-6,6), 7, other.transform.position.z);
            Instantiate(explosion, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
