using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//Tweening Engines(Animations)      To use your preferred Tweening Engine simply uncomment appropriate line.
//using DG.Tweening; //DOTween
//using ... //LeanTween
//using ... //iTween
[RequireComponent(typeof(EventTrigger))]
public class SliderController : MonoBehaviour
{
    #region variables
    [Space]
    [Header("Variables")]
    public RectTransform handle;
    public Slider slider;
    float decimalPart;
    float endValue;

    [Header("Animation settings")]
    public bool enableAnimations;
    [Range(0.1f, 1.5f)]
    public float duration;
    #endregion
    
    //This happens when you release LMB from slider handle.
    //Don't forget to add this function to Event Trigger for event type "Pointer Up"
    public void OnClickUp()
    {
        decimalPart = slider.value % 1;
        
        //I know that the code in this if statement is 1 line, and I don't need to use braces, but for me the code is more readable.
        
        //Round the number
        if (decimalPart >= 0.5f)
        {
            endValue = slider.value - decimalPart + 1;
        }
        else
        {
            endValue = slider.value - decimalPart;
        }
        //Check if animations are enabled and to the proper work
        if (enableAnimations)
        {
            //Again, Tweening Engines      To use your preferred Tweening Engine simply uncomment appropriate line and comment default one.
            //slider.DOValue(endValue, duration).SetEase(Ease.InOutCubic); //DOTween
            //slider. ... //LeanTween
            //slider. ... //iTween
        }
        else
        {
            slider.value = endValue;
        }
    }
}
