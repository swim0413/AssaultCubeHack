
namespace AssaultCubeHack
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.position = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.bulletproof = new System.Windows.Forms.Label();
            this.ammo = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chageHealth = new System.Windows.Forms.Button();
            this.changeAmmo = new System.Windows.Forms.Button();
            this.setHealth = new System.Windows.Forms.TextBox();
            this.setAmmo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fixHealth = new System.Windows.Forms.CheckBox();
            this.fixAmmo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.setPistolAmmo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.setSniperAmmo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sniper = new System.Windows.Forms.Label();
            this.pistol = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(1, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(419, 64);
            this.title.TabIndex = 0;
            this.title.Text = "AssaultCube Hack";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // process
            // 
            this.process.FormattingEnabled = true;
            this.process.Location = new System.Drawing.Point(6, 20);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(155, 20);
            this.process.TabIndex = 1;
            this.process.SelectedIndexChanged += new System.EventHandler(this.process_SelectedIndexChanged);
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.position);
            this.groupBox1.Controls.Add(this.angle);
            this.groupBox1.Controls.Add(this.bulletproof);
            this.groupBox1.Controls.Add(this.health);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(387, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "플래이어 정보";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(139, 75);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(33, 12);
            this.position.TabIndex = 4;
            this.position.Text = "좌표:";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(139, 32);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(33, 12);
            this.angle.TabIndex = 3;
            this.angle.Text = "각도:";
            // 
            // bulletproof
            // 
            this.bulletproof.AutoSize = true;
            this.bulletproof.Location = new System.Drawing.Point(7, 179);
            this.bulletproof.Name = "bulletproof";
            this.bulletproof.Size = new System.Drawing.Size(45, 12);
            this.bulletproof.TabIndex = 2;
            this.bulletproof.Text = "방어구:";
            // 
            // ammo
            // 
            this.ammo.AutoSize = true;
            this.ammo.Location = new System.Drawing.Point(6, 17);
            this.ammo.Name = "ammo";
            this.ammo.Size = new System.Drawing.Size(45, 12);
            this.ammo.TabIndex = 1;
            this.ammo.Text = "라이플:";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Location = new System.Drawing.Point(7, 32);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(21, 12);
            this.health.TabIndex = 0;
            this.health.Text = "피:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(581, 309);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(109, 42);
            this.exit.TabIndex = 4;
            this.exit.Text = "종료";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chageHealth
            // 
            this.chageHealth.Location = new System.Drawing.Point(193, 35);
            this.chageHealth.Name = "chageHealth";
            this.chageHealth.Size = new System.Drawing.Size(75, 23);
            this.chageHealth.TabIndex = 5;
            this.chageHealth.Text = "적용";
            this.chageHealth.UseVisualStyleBackColor = true;
            this.chageHealth.Click += new System.EventHandler(this.chageHealth_Click);
            // 
            // changeAmmo
            // 
            this.changeAmmo.Location = new System.Drawing.Point(182, 20);
            this.changeAmmo.Name = "changeAmmo";
            this.changeAmmo.Size = new System.Drawing.Size(75, 23);
            this.changeAmmo.TabIndex = 6;
            this.changeAmmo.Text = "적용";
            this.changeAmmo.UseVisualStyleBackColor = true;
            this.changeAmmo.Click += new System.EventHandler(this.changeAmmo_Click);
            // 
            // setHealth
            // 
            this.setHealth.Location = new System.Drawing.Point(67, 36);
            this.setHealth.Name = "setHealth";
            this.setHealth.Size = new System.Drawing.Size(100, 21);
            this.setHealth.TabIndex = 7;
            this.setHealth.Text = "1000";
            // 
            // setAmmo
            // 
            this.setAmmo.Location = new System.Drawing.Point(56, 22);
            this.setAmmo.Name = "setAmmo";
            this.setAmmo.Size = new System.Drawing.Size(100, 21);
            this.setAmmo.TabIndex = 8;
            this.setAmmo.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "피";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "라이플";
            // 
            // fixHealth
            // 
            this.fixHealth.AutoSize = true;
            this.fixHealth.Location = new System.Drawing.Point(284, 39);
            this.fixHealth.Name = "fixHealth";
            this.fixHealth.Size = new System.Drawing.Size(48, 16);
            this.fixHealth.TabIndex = 11;
            this.fixHealth.Text = "고정";
            this.fixHealth.UseVisualStyleBackColor = true;
            this.fixHealth.CheckedChanged += new System.EventHandler(this.fixHealth_CheckedChanged);
            // 
            // fixAmmo
            // 
            this.fixAmmo.AutoSize = true;
            this.fixAmmo.Location = new System.Drawing.Point(273, 24);
            this.fixAmmo.Name = "fixAmmo";
            this.fixAmmo.Size = new System.Drawing.Size(48, 16);
            this.fixAmmo.TabIndex = 12;
            this.fixAmmo.Text = "고정";
            this.fixAmmo.UseVisualStyleBackColor = true;
            this.fixAmmo.CheckedChanged += new System.EventHandler(this.fixAmmo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.setHealth);
            this.groupBox2.Controls.Add(this.chageHealth);
            this.groupBox2.Controls.Add(this.fixHealth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 200);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조작 기능";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.setPistolAmmo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.changeAmmo);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.setAmmo);
            this.groupBox3.Controls.Add(this.setSniperAmmo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.fixAmmo);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 121);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "총알";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(273, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "고정";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "적용";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // setPistolAmmo
            // 
            this.setPistolAmmo.Location = new System.Drawing.Point(56, 86);
            this.setPistolAmmo.Name = "setPistolAmmo";
            this.setPistolAmmo.Size = new System.Drawing.Size(100, 21);
            this.setPistolAmmo.TabIndex = 18;
            this.setPistolAmmo.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "권총";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(273, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "고정";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "적용";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setSniperAmmo
            // 
            this.setSniperAmmo.Location = new System.Drawing.Point(56, 57);
            this.setSniperAmmo.Name = "setSniperAmmo";
            this.setSniperAmmo.Size = new System.Drawing.Size(100, 21);
            this.setSniperAmmo.TabIndex = 14;
            this.setSniperAmmo.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "스나";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "v-3.0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "ac_client를 찾으세요.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pistol);
            this.groupBox4.Controls.Add(this.sniper);
            this.groupBox4.Controls.Add(this.ammo);
            this.groupBox4.Location = new System.Drawing.Point(9, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 100);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "총알";
            // 
            // sniper
            // 
            this.sniper.AutoSize = true;
            this.sniper.Location = new System.Drawing.Point(6, 46);
            this.sniper.Name = "sniper";
            this.sniper.Size = new System.Drawing.Size(33, 12);
            this.sniper.TabIndex = 2;
            this.sniper.Text = "스나:";
            // 
            // pistol
            // 
            this.pistol.AutoSize = true;
            this.pistol.Location = new System.Drawing.Point(6, 71);
            this.pistol.Name = "pistol";
            this.pistol.Size = new System.Drawing.Size(33, 12);
            this.pistol.TabIndex = 3;
            this.pistol.Text = "권총:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.process);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(519, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 61);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "프로세스 선택";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 363);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "AssaultCube Hack - swim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox process;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label bulletproof;
        private System.Windows.Forms.Label ammo;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button chageHealth;
        private System.Windows.Forms.Button changeAmmo;
        private System.Windows.Forms.TextBox setHealth;
        private System.Windows.Forms.TextBox setAmmo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fixHealth;
        private System.Windows.Forms.CheckBox fixAmmo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox setSniperAmmo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox setPistolAmmo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label pistol;
        private System.Windows.Forms.Label sniper;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

