using UnityEngine;

public class Enemy : MonoBehaviour
{
    private HealthManager healthManager;

    void Start()
    {
        // �񐄏��̃��\�b�h���g�p���Ă���ӏ����C��
        healthManager = Object.FindFirstObjectByType<HealthManager>();
        if (healthManager == null)
        {
            Debug.LogError("HealthManager ��������܂���ł����B");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.TakeDamage(10);
        }
    }
}
