using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMov : MonoBehaviour
{

    [SerializeField]
    private Camera cam;
    private Vector3 velocity = Vector3.zero;
    private Vector3 velocityHorizontal = Vector3.zero;
    private Vector3 velocityVertical = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private float cameraRotationX = 0f;
    private float currentCameraRotationX = 0f;
    private bool OnGround;

    public bool isFrozen = false;
    [SerializeField]
    private float cameraRotationLimit = 30f;

    private Rigidbody rb;



    void Start()
    {
        OnGround = true;
        rb = GetComponent<Rigidbody>();
    }

    //Gets a movement vector
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }
    public void MoveHorizontal(Vector3 _velocityHorizontal)
    {
        velocityHorizontal = _velocityHorizontal;
    }
    public void MoveVertical(Vector3 _velocityVertical)
    {
        velocityVertical = _velocityVertical;
    }
    //Gets a rotational vector
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }

    //Gets a rotational vector for the camera
    public void Rotatecamera(float _cameraRotationX)
    {
        cameraRotationX = _cameraRotationX;
    }

    private void Update()
    {
        if (OnGround)
        {
            if (Input.GetButtonDown("Jump") && !isFrozen)
            {
                rb.velocity = new Vector3(0f, 6f, 0f);
                OnGround = false;
            }
        }
    }

    //Run every physics iteration
    void FixedUpdate()
    {
        PerFormMovement();
        PerFormVerticalMovement();
        PerFormRotation();

    }

    void PerFormVerticalMovement()
    {
        if (velocityVertical != Vector3.zero && !isFrozen)
        {      
           rb.MovePosition(rb.position + velocityVertical * Time.fixedDeltaTime);
        }    
    }

    //Preform movement based on velocity verable
    void PerFormMovement()
    {

        if (velocityHorizontal != Vector3.zero && !isFrozen)
        {
            rb.MovePosition(rb.position + velocityHorizontal * Time.fixedDeltaTime);
        }       
    }
    void PerFormRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        if (cam != null)
        {
            //Set our rotation and clamp it
            currentCameraRotationX -= cameraRotationX;
            currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
            //Apply our rotation to the transform of our camera
            cam.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.CompareTag("Terrain"))
        //{
        OnGround = true;
        //}
    }
}