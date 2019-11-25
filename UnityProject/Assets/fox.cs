using UnityEngine;
using System.Collections;

public class fox : MonoBehaviour
{
    [Header("移動速度"), Range(1f, 100f), Tooltip("控制小雞移動速度")]
    public float speed = 10f;
    
    public Rigidbody2D Rig ;
    
    public bool sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }
    
}
