using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 3;
    private UIManager uiManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void LoseLife(int amount = 1)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            uiManager = uiManager ?? FindObjectOfType<UIManager>();
            uiManager?.ShowGameOverScreen();
        }
    }

    public int GetHealth()
    {
        return health;
    }
}
