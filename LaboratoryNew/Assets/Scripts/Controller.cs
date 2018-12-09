using UnityEngine;

public class Controller : MonoBehaviour {
    public float moveSpeed = 6f;   // Player's speed when walking. 
    Animator animator;
    Vector3 moveDirection; 
    Rigidbody rb; 

    void Start() 
    { 
        rb = GetComponent<Rigidbody>(); 
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.LeftShift))
        {
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(hAxis, 0f, vAxis);
            rb.position += movement * (moveSpeed + 5) * Time.deltaTime;
            animator.SetBool("Walking", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {		 
            float hAxis = Input.GetAxis("Horizontal"); 
            float vAxis = Input.GetAxis("Vertical"); 

            Vector3 movement = new Vector3(hAxis, 0f, vAxis); 
            rb.position += movement * moveSpeed * Time.deltaTime; 
            animator.SetBool("Walking", true);
		}
    }
}