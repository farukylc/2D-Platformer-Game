using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public EnemyHPBar enemybar;
    public GameObject body;

    [SerializeField] GameObject hpBar;

    public float enemyHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        enemybar.enemyMaxHP(enemyHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            enemyHealth -= 1;
            enemybar.enemyHP(enemyHealth);

            StartCoroutine(enemeyHPBarOnOff());
            

        }
        if (enemyHealth == -1)
        {
            Destroy(body);
            
        }

    }


    IEnumerator enemeyHPBarOnOff()
    {

        hpBar.SetActive(true);

        yield return new WaitForSeconds(3);

        hpBar.SetActive(false);

    }
}
