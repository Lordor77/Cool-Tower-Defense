using UnityEngine;

[RequireComponent(typeof(PlayerMov))]
public class PlayerController : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    private Rigidbody rb;

    public static Transform myTransform;
    private PlayerMov motor;



    void Start()
    {
        motor = GetComponent<PlayerMov>();

        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Calc movement velocity as a 3D vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _MovHorizontal = transform.right * _xMov;
        Vector3 HorizontalMov = _MovHorizontal.normalized * speed;
        motor.MoveHorizontal(HorizontalMov);
        Vector3 _MovVertical = transform.forward * _zMov;
        Vector3 VerticalMov = _MovVertical.normalized * speed;
        motor.MoveVertical(VerticalMov);
        // Ainal movement vector
        Vector3 _velocity = (_MovHorizontal + _MovVertical).normalized * speed;
        // Apply movement
        motor.Move(_velocity);

        //Calc rotation as a 3D vector(turnning around)
        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0F) * lookSensitivity;

        //Apply rotation
        motor.Rotate(_rotation);

        //Calc rotation as a 3D vector(turnning around)
        float _xRot = Input.GetAxisRaw("Mouse Y");

        float _cameraRotationX = _xRot * lookSensitivity;

        //Apply camera rotation
        motor.Rotatecamera(_cameraRotationX);


    }


}
