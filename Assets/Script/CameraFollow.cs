using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 追いかける対象（飛行機）
    public Vector3 offset = new Vector3(0, 5, -10); // カメラの位置オフセット
    public float followSpeed = 5f;  // 追従速度
    public float rotationSpeed = 3f; // 回転速度

    void LateUpdate()
    {
        if (target == null) return;

        // **飛行機の後ろ & 上のオフセット位置を直接計算**
        Vector3 desiredPosition = target.position + target.rotation * offset;

        // **カメラの位置を「完全に」固定**
        transform.position = desiredPosition;

        // **飛行機の方を向く**
        transform.LookAt(target.position + Vector3.up * 2);
    }

}
