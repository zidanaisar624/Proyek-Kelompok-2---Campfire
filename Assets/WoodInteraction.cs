using UnityEngine;

public class WoodInteraction : MonoBehaviour
{
    private bool isTaken = false;
    public float maxPickupDistance = 2.0f; // Jarak maksimal untuk mengambil kayu

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTaken)
        {
            Debug.Log("Press E to collect wood");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTaken)
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            var distance = Vector3.Distance(player.transform.position, transform.position);

            if (distance <= maxPickupDistance)
            {
                var inventory = player.GetComponent<PlayerInventory>();
                if (inventory != null)
                {
                    inventory.woodCount++;
                    Debug.Log("Wood collected! Total wood: " + inventory.woodCount);
                    isTaken = true;
                    Destroy(gameObject); // Menghilangkan kayu dari scene
                }
            }
            else
            {
                Debug.Log("Too far away to pick up the wood.");
            }
        }
    }
}