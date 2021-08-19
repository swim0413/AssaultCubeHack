using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProcessMemoryReaderLib;

namespace AssaultCubeHack
{
    public partial class Form1 : Form
    {
        Process[] Myprocess;
        ProcessMemoryReader mem = new ProcessMemoryReader();
        bool attach = false;
        bool healHack = false;
        bool ammoHack = false;
        bool sniperAmmoHack = false;
        bool pistolAmmoHack = false;

        PlayerData mainPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        private void process_Click(object sender, EventArgs e)
        {
            process.Items.Clear();
            Myprocess = Process.GetProcesses();

            for(int i = 0; i < Myprocess.Length; i++)
            {
                string text = Myprocess[i].ProcessName + "-" + Myprocess[i].Id;
                process.Items.Add(text);
            }
        }

        private void process_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (process.SelectedIndex != -1)
                {
                    string selecteditem = process.SelectedItem.ToString();
                    int pid = int.Parse(selecteditem.Split('-')[selecteditem.Split('-').Length - 1]);
                    Process attachProc = Process.GetProcessById(pid);


                    mem.ReadProcess = attachProc;
                    mem.OpenProcess();
                    attach = true;

                    MessageBox.Show("프로세스 열기 성공!" + attachProc.ProcessName);

                    mainPlayer = new PlayerData(attachProc, 0x00109B74, mem);
                }
            }
            catch (Exception ex)
            {
                attach = false;
                MessageBox.Show("프로세스 열기 실패!"+ex.Message);
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (attach)
            {
                try
                {
                    /*if ()
                    {
                    }
                    else
                    {
                        MessageBox.Show("정수만 입력하세요, 제발.");
                    }*/

                    if (healHack)
                    {
                        mainPlayer.hackHealth(mem, int.Parse(setHealth.Text));
                    }

                    if (ammoHack)
                    {
                        mainPlayer.hackAmmo(mem, int.Parse(setAmmo.Text));
                    }

                    if (sniperAmmoHack)
                    {
                        mainPlayer.hackSniper(mem, int.Parse(setSniperAmmo.Text));
                    }

                    if (pistolAmmoHack)
                    {
                        mainPlayer.hackPistol(mem, int.Parse(setPistolAmmo.Text));
                    }

                     

                    mainPlayer.SetPlayerData(mem);
                    health.Text = "피:" + mainPlayer.health;
                    ammo.Text = "라이플:" + mainPlayer.ammo;
                    sniper.Text = "스나:"+mainPlayer.sniper;
                    pistol.Text = "권총:" + mainPlayer.pistol;
                    bulletproof.Text = "방어구:" + mainPlayer.bullet_proof;
                    angle.Text = "각도:" + mainPlayer.x_angle + ", " + mainPlayer.y_angle;
                    position.Text = "좌표:" + mainPlayer.x_pos + "\n" + mainPlayer.y_pos + "\n" + mainPlayer.z_pos;
                }
                catch (Exception ex) { }
            }
        }

        private void chageHealth_Click(object sender, EventArgs e)
        {
            mainPlayer.hackHealth(mem, int.Parse(setHealth.Text));
        }

        private void changeAmmo_Click(object sender, EventArgs e)
        {
            mainPlayer.hackAmmo(mem, int.Parse(setAmmo.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainPlayer.hackSniper(mem, int.Parse(setSniperAmmo.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPlayer.hackPistol(mem, int.Parse(setPistolAmmo.Text));
        }
        private void fixHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (healHack)
            {
                healHack = false;
            }
            else
            {
                healHack = true;
            }
        }

        private void fixAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (ammoHack)
            {
                ammoHack = false;
            }
            else
            {
                ammoHack = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sniperAmmoHack)
            {
                sniperAmmoHack = false;
            }
            else
            {
                sniperAmmoHack = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pistolAmmoHack)
            {
                pistolAmmoHack = false;
            }
            else
            {
                pistolAmmoHack = true;
            }
        }

     
    }
}
