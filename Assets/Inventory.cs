using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Ordicount;
    public static Inventory instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("Il y a plus d'une instance d'Inventory dans la scène.");
            Destroy(gameObject); // Détruire le duplicata pour s'assurer qu'il n'y a qu'une seule instance
            return;
        }
        instance = this;
    }

    public void AddOrdi(int count)
    {
        Ordicount += count;
    }
}
