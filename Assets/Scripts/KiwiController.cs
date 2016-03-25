using UnityEngine;
using System.Collections;

public class KiwiController : MonoBehaviour {

    private Rigidbody2D rigidBody;
    public Vector2 forceUp = new Vector2(0, 12);
    public float maxSpeed = 10f;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameLogic.paused)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
//            UnityEngine.Debug.Log("22222222");
            rigidBody.AddForce(forceUp, ForceMode2D.Impulse);
        }
	}

    void GameStart()
    {
        rigidBody.gravityScale = 1f;
    }

//    void OnTriggerEnter2D(Collider2D other) {
//        UnityEngine.Debug.Log("collide");
//    }

    void FixedUpdate()
    {
        if (rigidBody.velocity.magnitude > maxSpeed)
        {
            rigidBody.velocity = rigidBody.velocity.normalized * maxSpeed;
        }
    }
}
