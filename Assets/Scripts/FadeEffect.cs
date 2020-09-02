using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour {

	public static IEnumerator FadeIn(Image image,float speed){
		for (float i = 0; i <= 1; i += Time.deltaTime*speed)
		{
			// set color with i as alpha
			if(image!=null)
			image.color = new Color(1, 1, 1, i);
			yield return null;
		}
	}
	public static IEnumerator FadeOut(Image image,float speed){
		for (float i = 1; i >= 0; i -= Time.deltaTime*speed)
		{
			// set color with i as alpha
			if(image!=null)
			image.color = new Color(1, 1, 1, i);
			yield return null;
		}
	}
	public static IEnumerator FadeIn(TextMesh textMesh,float speed){
		for (float i = 0; i <= 1; i += Time.deltaTime*speed)
		{
			// set color with i as alpha
			textMesh.color = new Color(textMesh.color.r, textMesh.color.b, textMesh.color.g, i);
			yield return null;
		}
	}
	public static IEnumerator FadeOut(TextMesh textMesh,float speed){
		for (float i = 1; i >= 0; i -= Time.deltaTime*speed)
		{
			// set color with i as alpha
			textMesh.color = new Color(textMesh.color.r, textMesh.color.b, textMesh.color.g, i);
			yield return null;
		}
	}
	public static IEnumerator FadeIn(Text text,float speed){
		for (float i = 0; i <= 1; i += Time.deltaTime*speed)
		{
			// set color with i as alpha
			text.color = new Color(text.color.r, text.color.b, text.color.g, i);
			yield return null;
		}
	}
	public static IEnumerator FadeOut(Text text,float speed){
		for (float i = 1; i >= 0; i -= Time.deltaTime*speed)
		{
			// set color with i as alpha
			text.color = new Color(text.color.r, text.color.b, text.color.g, i);
			yield return null;
		}
	}

    public static IEnumerator FadeIn(Material material, float speed)
    {
        for (float i = 0; i <= 1; i += Time.deltaTime * speed)
        {
            // set color with i as alpha
            material.color = new Color(material.color.r, material.color.b, material.color.g, i);
            yield return null;
        }
    }
    public static IEnumerator FadeOut(Material material, float speed)
    {
        for (float i = 1; i >= 0; i -= Time.deltaTime * speed)
        {
            // set color with i as alpha
            material.color = new Color(material.color.r, material.color.b, material.color.g, i);
            yield return null;
        }
    }

}
