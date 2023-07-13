using UnityEngine;

public class ModeComponent : MonoBehaviour, IModeComponent
{
    [SerializeField] private Renderer render;

    private float temp=1f;
    private bool isStop = false;

    public void Mode()
    {
//на однократсность нажатия
        if (isStop)
        {
            isStop = false;
            return;
        }
        else
        {
            isStop = true;
        }

        StMash();
    }

    private void StMash()
    {
        if (render.material.GetFloat("_Alfa") != 0)
        {
            render.material.SetFloat("_Alfa", 0);
        }
        else
        {
            render.material.SetFloat("_Alfa", 1);
        }
    }

}
