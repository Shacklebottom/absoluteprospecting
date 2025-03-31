using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace AbsoluteProspecting
{
    public class AbsoluteProspectingModSystem : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            api.RegisterItemClass("ItemProspectingPick", typeof(ItemAbsoluteProspecting));
        }
    }
}
