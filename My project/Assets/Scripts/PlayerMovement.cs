using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMovement, verticalMovement;
    public Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        

    }
    private void FixedUpdate()
    {
        /*this.transform.position = new Vector3(horizontalMovement, 0, 0) * Time.deltaTime;
        this.transform.position = new Vector3(0, verticalMovement * 5f, 0) * Time.deltaTime;*/

        rb2d.velocity = new Vector2(horizontalMovement * 5.0f, rb2d.velocity.y);

    }
}
