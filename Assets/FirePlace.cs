//using UnityEngine;

//public class FirePlace : MonoBehaviour
//{
//    private bool hasWood = false;

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            if (!hasWood)
//            {
//                Debug.Log("Press E to place the wood");
//            }
//            else
//            {
//                Debug.Log("Press F to light the fire");
//            }
//        }
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.E) && !hasWood)
//        {
//            var player = GameObject.FindGameObjectWithTag("Player");
//            var inventory = player.GetComponent<PlayerInventory>();

//            if (inventory != null && inventory.RemoveWood(out WoodInteraction wood))
//            {
//                wood.Drop(transform); // Letakkan kayu di api unggun
//                hasWood = true;
//                Debug.Log("Wood placed in the fireplace.");
//            }
//            else
//            {
//                Debug.Log("No wood available in inventory.");
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.F) && hasWood)
//        {
//            //LightFire();
//        }
//    }

//    private void LightFire()
//    {
//        Debug.Log("The fire is lit!");
//        var fireEffect = transform.Find("FireEffect").gameObject;
//        fireEffect.SetActive(true);
//    }
//}
