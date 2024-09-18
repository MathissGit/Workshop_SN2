using UnityEngine;

public class PickUpLaptop : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.ComparTag("Player"))
    {
        Destroy(gameObject);
    }
   }

}
