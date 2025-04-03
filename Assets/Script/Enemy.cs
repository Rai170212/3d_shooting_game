using UnityEngine;

public class Enemy : MonoBehaviour
{
    private HealthManager healthManager;

    void Start()
    {
        // 非推奨のメソッドを使用している箇所を修正
        healthManager = Object.FindFirstObjectByType<HealthManager>();
        if (healthManager == null)
        {
            Debug.LogError("HealthManager が見つかりませんでした。");
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
