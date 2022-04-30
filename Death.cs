using UnityEngine;

public class Death : MonoBehaviour
{
    public float movementSpeed = 5;
    public float JumpForce = 5;
    private Rigidbody2D _rigidBody;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if(Input.GetKeyDown(KeyCode.W) && Mathf.Abs(_rigidBody.velocity.y) < 0.001f)
        {
            _rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }


    }
}
