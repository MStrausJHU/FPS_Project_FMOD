
namespace Unity.FPS.Gameplay
{
    public class JetpackPickup : Pickup
    {
        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            var jetpack = byPlayer.GetComponent<Jetpack>();
            if (!jetpack)
                return;
            //goo goo ga ga
            if (jetpack.TryUnlock())
            {
                PlayPickupFeedback();
                Destroy(gameObject);
            }
        }
    }
}