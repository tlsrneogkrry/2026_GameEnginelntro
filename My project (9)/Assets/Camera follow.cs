using UnityEngine;

public class Camerafollow : MonoBehaviour
{

    public Transform player;

    float cameraoffset = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, cameraoffset);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }
}
