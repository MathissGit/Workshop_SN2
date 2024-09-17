
using UnityEngine;



Public float moveSpeed;

public rigidbody2D rb;
private Vector3 velocity = Vector3.zero
 
public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("horizontal") * Moveplayerspeed * Time.deltaTime; 
    }


   void MovePlayer(float _horizontalMovement)
   {
      vector3 targetVelocity = new vector2(_horizontalMovement, rb.velocity.y);
      rb.velocity = Vector3.smoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
   }

}
