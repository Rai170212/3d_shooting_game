using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float forwardSpeed = 500f;   // ��ɑO�i���鑬�x
    public float rotationSpeed = 10000f;  // ��]���x
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // **��s�@�͏�ɑO�ɐi��**
        rb.linearVelocity = transform.forward * forwardSpeed;

        // **�L�[�������Ă���Ԃ�����]**
        float yawInput = (Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0);
        float pitchInput = (Input.GetKey(KeyCode.DownArrow) ? 1 : 0) - (Input.GetKey(KeyCode.UpArrow) ? 1 : 0);
        float rollInput = (Input.GetKey(KeyCode.E) ? 1 : 0) - (Input.GetKey(KeyCode.Q) ? 1 : 0);

        if (yawInput == 0 && pitchInput == 0 && rollInput == 0)
        {
            // **�L�[�𗣂������]���~�߂�**
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            // **�L�[���͂�����Ƃ�������]**
            Vector3 rotation = new Vector3(pitchInput, yawInput, -rollInput) * rotationSpeed * Time.fixedDeltaTime;
            rb.AddTorque(rotation);
        }
    }
}
