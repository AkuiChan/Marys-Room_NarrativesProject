using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndChoice : MonoBehaviour
{
    public Text changeText;

    public void Yes()
    {
        changeText.text = "I might know a lot about colors, all the physical aspects \n" +
            "How to describe the emotions others may have while seing colors \n" +
            "\n" +
            "Today i learned what it is like to exeprience color";

            /*"Upon experiencing the world of color, it will become obvious that,\n " +
            "inside her room,\n " +
            "she did not know what it is like for both herself or others to see colors \n " +
            "\n " +
            "There are truths about other people that escape the physicalist world view";*/
    }

    public void No()
    {
        changeText.text = "I already knew what is experienced when seeing colors\n" +
            "I know all the physical aspects\n" +
            "I know how to describe the emotions one may feel while seing colors\n" +
            "\n" +
            "This just proves what i already know";
    }

    public void DissableButton(GameObject yes)
    {
        yes.SetActive(false);
//        no.SetActive(false);
    }
}
