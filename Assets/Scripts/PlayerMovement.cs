using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    bool moveLeft = false;
    bool moveRight = false;

    void Update() {
        if (Input.GetKey("a")){
            moveLeft = true;
        } else {
            moveLeft = false;
        } 
        if (Input.GetKey("d")){
            moveRight = true;
        } else {
            moveRight = false;
        }
    }

    /*
     * We marked this as fixed update because we are
     * using it to mess with physics
     */
    void FixedUpdate() {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( moveLeft ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( moveRight ) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
