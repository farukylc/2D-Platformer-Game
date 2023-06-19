using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource deathSound;
    

    public float o2Level = 5;

    public float hpLevel = 5;

    public O2Bar o2bar;

    public HealthBar HPbar;
    
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        o2bar.setMaxo2(o2Level);

        HPbar.setMaxHP(hpLevel);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            hpLevel = 0;
            HPbar.SetHP(hpLevel);
            Die();
             
        }

        else if (collision.gameObject.CompareTag("EnemyBullet"))
        {

            hpLevel -= 1;
            HPbar.SetHP(hpLevel);
            
            if(hpLevel <= 0)
            {

                Die();
            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) //can doldurma
    {
        if (collision.gameObject.CompareTag("Hearth"))
        {
            if(hpLevel < 5)
            {
                hpLevel += 1;
                HPbar.SetHP(hpLevel);
                Destroy(collision.gameObject);
                Debug.Log("<3");


            }
            


        }
    }

    private void OnTriggerStay2D(Collider2D collision) //su
    {
        if (collision.gameObject.CompareTag("WaterDeath"))
        {
            o2Level -= 1f * Time.deltaTime;
            o2bar.Seto2(o2Level);
            Invoke("DestroyPlayer", 5f);

        }
    }

    private void DestroyPlayer()//su
    {
        rb.bodyType = RigidbodyType2D.Static;
        rb.gameObject.SetActive(false);

    }
    
    
    private void Die() //ölüm
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        deathSound.Play();

    }

    public void RestarLevel() // restart
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
