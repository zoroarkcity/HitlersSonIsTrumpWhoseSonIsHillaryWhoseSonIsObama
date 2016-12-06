using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Thrown {
public class FireGrenade : ModItem
{
	
    public override void SetDefaults()
    {
        item.name = "Fire Grenade";
        item.damage = 30;
        item.thrown = true;
		item.noMelee = true;
		item.noUseGraphic = true;
        item.width = 22;
        item.height = 22;
        item.useTime = 44;
        item.useAnimation = 44;
        item.useStyle = 1;
		item.shootSpeed = 5.5f;
		item.shoot = mod.ProjectileType("FireGrenadeProj");
        item.knockBack = 1;
		item.scale = 1f;
        item.value = 75;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
        item.autoReuse = false;
        item.consumable = true;
        item.maxStack = 999;
    }
}}