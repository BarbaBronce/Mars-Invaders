using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{

    public float Lifes = 3f;
    public Transform EnemyArmy;
    private Transform Respawntransformpos;
    public Sprite lifeSprite_0;
    public Sprite lifeSprite_1;
    public Sprite lifeSprite_2;
    public Sprite lifeSprite_3;
   
    public SpriteRenderer Healthbar;

    private void FixedUpdate()
    {
        if (EnemyArmy.position.y < -3f)
        {
            EnemyArmy.position = new Vector3(-6.62f, 1.3f, 0);
            Lifes--;
            Debug.Log(Lifes);
            if (Lifes == 2)
            {
                Healthbar.sprite = lifeSprite_2;

            }
            if (Lifes == 1)
            {
                Healthbar.sprite = lifeSprite_1;

            }
            if (Lifes == 0)
            {
                Healthbar.sprite = lifeSprite_0;

            }

        }
       
        if (Lifes < 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    
    }

