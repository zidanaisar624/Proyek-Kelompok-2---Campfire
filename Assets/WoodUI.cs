using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WoodUI : MonoBehaviour
{
    public TextMeshProUGUI woodCountText;
    private PlayerInventory playerInventory;

    void Start()
    {
        // Temukan player dan ambil komponen PlayerInventory
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
    }

    void Update()
    {
        // Set teks sesuai jumlah kayu yang dimiliki player
        woodCountText.text = "Wood: " + playerInventory.woodCount;
    }
}