using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Transform spawnPoint = GameObject.FindGameObjectWithTag("PlayerSpawn")?.transform;
            if (spawnPoint != null)
            {
                collision.transform.position = spawnPoint.position;
            }
            else
            {
                Debug.LogError("PlayerSpawn tag not found or PlayerSpawn object missing.");
            }
        }
    }
}
