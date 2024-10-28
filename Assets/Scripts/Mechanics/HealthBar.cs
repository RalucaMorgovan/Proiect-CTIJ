using UnityEngine;
using UnityEngine.UI;
using Platformer.Mechanics;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;


public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {
        currentHealthBar.fillAmount = (float)playerHealth.CurrentHP / playerHealth.maxHP/10;
    }

    private void Update()
    {
        currentHealthBar.fillAmount = (float)playerHealth.CurrentHP / playerHealth.maxHP / 10;
    }
}
