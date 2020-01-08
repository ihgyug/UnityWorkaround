using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numberOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }
        if (health < 0)
        {
            health = 0;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }

        /*if (Input.GetKeyDown(KeyCode.M))
        {
            health++;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            health--;
        } */
    }
}
