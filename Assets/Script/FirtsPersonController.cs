using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset = new Vector3(0, 0.8f, 0);

    private void Update()
    {
        transform.position = Player.position + offset;
    }
}