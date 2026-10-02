using AdventurersEra.Modding;
using ExampleMod.Resources;

namespace ExampleMod
{
    public sealed class ExampleMod : IGameModule
    {
        private IModuleContext? _context;

        public void Load(IModuleContext context)
        {
            ModContent.Register(context, new CrystalResource());
            _context = context;
            context.Log(ModuleLogLevel.Info, context.Localize("ui.example.initialized", "ExampleMod initialized"));
        }

        public void Dispose()
        {
            if (_context != null) _context.Log(ModuleLogLevel.Info, _context.Localize("ui.example.stopped", "ExampleMod stopped"));
            _context = null;
        }
    }
}
