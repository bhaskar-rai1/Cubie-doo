using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // public Transform is a type of data type like public int
    public Transform player;
    // Vector3 is a data type which stores 3 float values x, y, z
    public Vector3 offset;


    // Side Note - Watch the brackeys video on camera again to understand this better


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
