using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using ThoriumMod;

namespace SkyblockThoriumHelper {
	class SkyblockThoriumHelper : Mod {
		public SkyblockThoriumHelper() {
		}
        public override void AddRecipeGroups() {
        }
        public override void AddRecipes() {
            //if (ModLoader.GetLoadedMods().Contains("ThoriumMod")) {
                // Get the Thorium mod
            //    Mod ThoriumMod = ModLoader.GetMod("ThoriumMod");


            // Make a recipe for Marine Rock
            ModRecipe recipe = new ModRecipe(ThoriumMod);
            recipe.AddIngredient(ItemID.GraniteBlock, 25);
            recipe.AddIngredient(ItemID.SandBlock, 25);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            reciple.needWater = true;
            recipe.SetResult(ThoriumMod, "MarineRock", 50);
            recipe.AddRecipe();
        }
    }
}
