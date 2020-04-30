
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerpos; //reference to player is provided from editor
    public Vector3 cameraoffset;
    // Update is called once per frame
    void Update()
    {
        //Follows the player
        transform.position = playerpos.position + cameraoffset;
    }
}
