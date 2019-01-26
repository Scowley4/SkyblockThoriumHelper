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


            group = new RecipeGroup(() => Lang.misc[37] + " Ocean Material", new int[]
            {
                ItemID.Coral,
                ItemID.Seashell,
                ItemID.Starfish,
            });
            RecipeGroup.RegisterGroup("SkyblockThoriumHelper:OceanMaterial", group);

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

            // Recipe for Brackish Clump (BrackMud)
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("SkyblockThoriumHelper:BasicFish");
            recipe.AddIngredient(ItemID.SandBlock, 25);
            recipe.needWater = true;
            recipe.SetResult(thoriumMod, "BrackMud", 25);
            recipe.AddRecipe();

            // Should we try to add a Depth Chest or add recipes for the Depth
            // Chest items? For now, I will add Rain Stone, since it's useful
            // for fishing especially
            //
            // Rain Stone
            recipe = new ModRecipe(this);
            recipe.AddIngredient(thoriumMod.ItemType("DepthScale"), 10);
            recipe.AddIngredient(thoriumMod.ItemType("Aquaite"), 10);
            recipe.needWater = true;
            recipe.SetResult(thoriumMod, "RainStone");
            recipe.AddRecipe();

            // Recpie for the Blood Altar
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(thoriumMod.ItemType("Blood"), 10);
            recipe.AddIngredient(thoriumMod.ItemType("UnholyShards"), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(thoriumMod, "BloodAltar");
            recipe.AddRecipe();

            // Gold Chest
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GoldBrick, 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GoldChest);
            recipe.AddRecipe();

            // Ice Chest
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IceBrick, 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.IceChest);
            recipe.AddRecipe();

            // Ivy Chest
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.IvyChest);
            recipe.AddRecipe();

            // Water Chest
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("SkyblockThoriumHelper:OceanMaterial", 2);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WaterChest);
            recipe.AddRecipe();

            // Web Covered Chest
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Cobweb, 2);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WebCoveredChest);
            recipe.AddRecipe();

            // Living Wood Chest
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.LivingWoodChest);
            recipe.AddRecipe();

            // Spear
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 5);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Spear);
            recipe.AddRecipe();
    
        }
    }
}
