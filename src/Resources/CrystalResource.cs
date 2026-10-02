using System.Collections.Generic;
using AdventurersEra.Modding;

namespace ExampleMod.Resources
{
    public sealed class CrystalResource : Resource
    {
        public override string Id => "test_crystal";
        public override string Name => "Тестовый кристалл (C#)";
        public override string Description => "Ресурс, добавленный C#-модом. Выпадает с тестового моба.";
        public override string Icon => "assets/icons/crystal.png";
        public override int MaxStack => 99;
        public override int Weight => 1;

        public override IEnumerable<ResourceLoot> Loot
        {
            get
            {
                yield return new ResourceLoot
                {
                    Table = "base:test-mob-loot",
                    Chance = 1f,
                    MinAmount = 1,
                    MaxAmount = 3,
                    Rarity = "uncommon"
                };
            }
        }
    }
}
