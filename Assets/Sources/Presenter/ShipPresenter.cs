using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;
    public int lives = 3;

    public void Init(Root init)
    {
        _init = init;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;
            if (lives == 0)
            {
                _init.DisableShip();
            }
        }
    }
}
