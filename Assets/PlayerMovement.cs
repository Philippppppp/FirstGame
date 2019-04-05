using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Rigidbody2D _rgbd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (_rgbd != null)
            {
                _rgbd.position += new Vector2(_speed, 0);
                //_rgbd.AddForce(new Vector2(100, -100));
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (_rgbd != null)
            {
                _rgbd.position += new Vector2(-_speed, 0);
                //_rgbd.AddForce(new Vector2(100, -100));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //_rgbd.position = new Vector2(0, 0);
        Health health = collision.gameObject.GetComponent<Health>();

        if(health)
        {
            health.AddDamage(10);
        }
    }
}
