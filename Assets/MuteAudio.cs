using  UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] private Sprite audioOnSprite;    
    [SerializeField] private Sprite audioOffSprite;   
    private Image buttonImage;                         
    private void Start()
    {
        buttonImage = GetComponent<Image>(); 
        UpdateButtonSprite();                
    }

    public void OnMuteButtonClick()
    {
        SoundManager.Instance.ToggleMute();  
        UpdateButtonSprite();                
    }

    private void UpdateButtonSprite()
    {
        
        if (SoundManager.Instance.IsMuted())
        {
            buttonImage.sprite = audioOffSprite;  
        }
        else
        {
            buttonImage.sprite = audioOnSprite;   
        }
    }
}
