
using UnityEngine;

public class RandomStartAnimation : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        var state = _animator.GetCurrentAnimatorStateInfo(layerIndex: 0);
        _animator.Play(state.fullPathHash, layer: 0, normalizedTime: Random.Range(0f, 1f));
    }

    
}
