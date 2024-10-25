using UnityEngine;
using TMPro;
using PlayerAttackNS;
using System;
namespace DamageTextNS
{
public class DamageText : MonoBehaviour
{
    public TMP_Text damageText;
    public float fadeOut = 1f;
    private Color startColour;

    private void Start()
    {
        startColour = damageText.color;
    }
    public void DisplayDamage(int damage)
    {
        damageText.text = "-"+damage.ToString();
        StartCoroutine(FadeAway());
    }
    private System.Collections.IEnumerator FadeAway()
    {
        float time = 0f;
        damageText.color = startColour;
        while (time < fadeOut)
        {
            time += Time.deltaTime;
            float newAlpha = Mathf.Lerp(1f, 0f, time/fadeOut);
            damageText.color = new Color(startColour.r, startColour.g, startColour.b, newAlpha);
            yield return null;
        }
        damageText.color = new Color(startColour.r, startColour.g, startColour.b, 0f);
    }
}
}
