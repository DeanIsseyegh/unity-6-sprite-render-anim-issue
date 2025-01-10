using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Sprite _otherShape;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void ChangeSprite()
    {
        _spriteRenderer.sprite = _otherShape;
    }
}
