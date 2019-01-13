using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using ThoriumMod;

namespace SkyblockThoriumHelper {
    class SkyblockThoriumHelper : Mod {
        public SkyblockThoriumHelper() {
        }
        public override void AddRecipeGroups() {
            RecipeGroup group;

            group = new RecipeGroup(() => Lang.misc[37] + " Basic Fish", new int[]
            {
                ItemID.Bass,
                ItemID.Trout,
                ItemID.AtlanticCod,
                ItemID.RedSnapper,
                ItemID.Salmon,
                ItemID.Tuna,
            });
            RecipeGroup.RegisterGroup("SkyblockThoriumHelper:BasicFish", group);
        }
        public override void AddRecipes() {
            ModRecipe recipe;
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");

            // Make a recipe for Marine Rock
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Granite, 25);
            recipe.AddIngredient(ItemID.SandBlock, 25);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.needWater = true;
            recipe.SetResult(thoriumMod, "MarineRock", 50);
            recipe.AddRecipe();

            // Recipe for brackish clump
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("SkyblockThoriumHelper:BasicFish");
            recipe.AddIngredient(ItemID.SandBlock, 25);
            recipe.needWater = true;
            recipe.SetResult(thoriumMod, "BrackMud", 25);
            recipe.AddRecipe();

            // Recpie for the Blood Alter
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(thoriumMod.ItemType("Blood"), 10);
            recipe.AddIngredient(thoriumMod.ItemType("UnholyShards"), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(thoriumMod, "BloodAltar");
            recipe.AddRecipe();

        }
    }
}
