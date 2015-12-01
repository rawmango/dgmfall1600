using UnityEngine;
using System.Collections;

public class tankcontroller : MonoBehaviour {
		
		[HideInInspector]
		public bool jump = false;			
		
		public float moveForce = 365f;			
		public float maxSpeed = 5f;			
		public float jumpForce = 1000f;			
		
		private Transform groundDetector;		
		private bool grounded = false;			
		
		void Awake()
		{
			 //Setting up references.
			groundDetector = transform.Find("GroundDetector");
		}
		
		void Update()
		{
			// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
			grounded = Physics2D.Linecast(transform.position, groundDetector.position, 1 << LayerMask.NameToLayer("Terrain"));  
			
			// If the jump button is pressed and the player is grounded then the player should jump.
			if(Input.GetButtonDown("Jump") && grounded)
				jump = true;
		}
		
		void FixedUpdate ()
		{
			// Cache the horizontal input.
			float h = Input.GetAxis("Horizontal");
			
			if(h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed) 			
				//rigidbody2D.AddForce(Vector2.right * h * moveForce); 		 		
			 if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
			
		    // If the player should jump...
			if(jump)
			{	
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
				jump = false; 
			}
}
	}



// http://www.unit3y.com/unity-2d-tank-game-part-iii-making-tank-move/ 




