using System.Collections;
using UnityEngine;

public class Mummy : MonoBehaviour
{
    public int enemyHealth = 10;

    void DeductDamage(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }


    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
