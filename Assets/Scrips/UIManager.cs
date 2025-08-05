using UnityEngine;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private List<Animator> _buttons;
    [SerializeField]
    private string _buttonAppear = "UIObjectAppear";
    [SerializeField]
    private string _buttonDesapear = "UIObjectDisappear";
    public void ShowButtons()
    {
        foreach (Animator button in _buttons)
        {
            button.Play(_buttonAppear);
        }
    }
    public void HideButtons()
    {
        foreach (Animator button in _buttons)
        {
            button.Play(_buttonDesapear);
        }
    }
    
}
