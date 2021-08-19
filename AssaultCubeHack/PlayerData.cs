using ProcessMemoryReaderLib;
using System;
using System.Diagnostics;

namespace AssaultCubeHack
{
    internal class PlayerData
    {
        int base_addr;

        int health_offset = 0xF8;
        int bullet_proof_offset = 0xFC;
        int ammo_offset = 0x150;
        int sniper_offset = 0x14C;
        int pistol_offset = 0x13C;
        int x_pos_offset = 0x34;
        int y_pos_offset = 0x38;
        int z_pos_offset = 0x3C;
        int x_angle_offset = 0x40;
        int y_angle_offset = 0x44;
        

        public int health;
        public int bullet_proof;
        public int ammo;
        public int sniper;
        public int pistol;
        public int x_pos;
        public float y_pos;
        public float z_pos;
        public float x_angle;
        public float y_angle;

        public PlayerData(Process proc, int offset, ProcessMemoryReader mem)
        {
            int base_ptr = proc.MainModule.BaseAddress.ToInt32() + offset;

            base_addr = mem.ReadInt(base_ptr);

            health = 0;
            bullet_proof = 0;
            ammo = 0;
            sniper = 0;
            pistol = 0;
            x_pos = 0;
            y_pos = 0;
            z_pos = 0;
            x_angle = 0;
            y_angle = 0;
        }

        internal void SetPlayerData(ProcessMemoryReader mem)
        {
            health = mem.ReadInt(base_addr+health_offset);
            bullet_proof = mem.ReadInt(base_addr + bullet_proof_offset);
            ammo = mem.ReadInt(base_addr + ammo_offset);
            sniper = mem.ReadInt(base_addr + sniper_offset);
            pistol = mem.ReadInt(base_addr + pistol_offset);
            x_pos = mem.ReadInt(base_addr + x_pos_offset);
            y_pos = mem.ReadInt(base_addr + y_pos_offset);
            z_pos = mem.ReadInt(base_addr + z_pos_offset);
            x_angle = mem.ReadInt(base_addr + x_angle_offset);
            y_angle = mem.ReadInt(base_addr + y_angle_offset);
        }

        internal void hackHealth(ProcessMemoryReader mem, int ammount)
        {
            mem.WriteInt(base_addr + health_offset, ammount);
        }

        internal void hackAmmo(ProcessMemoryReader mem, int ammount)
        {
            mem.WriteInt(base_addr + ammo_offset, ammount);
        }

        internal void hackSniper(ProcessMemoryReader mem, int ammount)
        {
            mem.WriteInt(base_addr + sniper_offset, ammount);
        }

        internal void hackPistol(ProcessMemoryReader mem, int ammount)
        {
            mem.WriteInt(base_addr + pistol_offset, ammount);
        }
    }
}