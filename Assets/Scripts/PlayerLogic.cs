using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Rigidbody2D rb;
    private bool canJump = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal") * playerSpeed;
        rb.linearVelocity = new Vector2(xAxis, rb.linearVelocityY);

        if(Input.GetKeyDown(KeyCode.Space) && canJump) {
            canJump = false;
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        canJump = true;
    }
}
