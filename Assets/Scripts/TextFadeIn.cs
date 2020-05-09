using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFadeIn : MonoBehaviour
{
    private bool mFaded = false;

    public float Duration = 0.4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fade()
    {
        var canvGroup = GetComponent<CanvasGroup>();

        //Toggle the end value depending on the faded state
        StartCoroutine(Dofade(canvGroup, canvGroup.alpha, mFaded ? 1 : 0));

        //Toggle the faded state
        mFaded = !mFaded;
    }

    public IEnumerator Dofade(CanvasGroup canvGroup, float start, float end)
    {
        float counter = 0f;
        while (counter < Duration)
        {
            counter += Time.deltaTime;
            canvGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

            yield return null;
        }
    }
}
