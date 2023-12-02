using PulsarModLoader;

namespace Stormtrooper
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Significantly reduces the player's accuracy";

        public override string Name => "Stormtrooper";

        public override string ModID => "stormtrooper";

        public override string HarmonyIdentifier()
        {
            return "id107.stormtrooper";
        }
    }
}
