using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.AddOrdi(1);
            Destroy(gameObject); // Détruit l'objet auquel ce script est attaché
        }
    }
}
