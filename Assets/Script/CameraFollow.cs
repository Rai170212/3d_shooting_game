using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // �ǂ�������Ώہi��s�@�j
    public Vector3 offset = new Vector3(0, 5, -10); // �J�����̈ʒu�I�t�Z�b�g
    public float followSpeed = 5f;  // �Ǐ]���x
    public float rotationSpeed = 3f; // ��]���x

    void LateUpdate()
    {
        if (target == null) return;

        // **��s�@�̌�� & ��̃I�t�Z�b�g�ʒu�𒼐ڌv�Z**
        Vector3 desiredPosition = target.position + target.rotation * offset;

        // **�J�����̈ʒu���u���S�Ɂv�Œ�**
        transform.position = desiredPosition;

        // **��s�@�̕�������**
        transform.LookAt(target.position + Vector3.up * 2);
    }

}
