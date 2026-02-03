using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }
}
