using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -15);
    private Vector3 offsetFPV = new Vector3(0, 3, 1);
    private bool viewFPV = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (viewFPV) { viewFPV = false; } else { viewFPV = true; }
        }

        if (viewFPV)
        {
            transform.position = player.transform.position + offsetFPV;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
