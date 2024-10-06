using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_4
{
    public partial class Form1 : Form
    {
        int jumpcnt;//可跳躍次數
        int jumpstr;//跳躍強度
        int jumpspeed;
        bool jump,on;
        bool l,r;
        int speed;
        int a;
        int foot;
        public Form1()
        {
            InitializeComponent();
            player.BringToFront();
            DoubleBuffered = true;
            jump = false;
            on = true;
            l = false;
            r = false;
            jumpcnt = 3;
            a = 5;
            speed = 10;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumpstr == 0)
            {
                jumpstr = 1; ;
            }
            if (e.KeyCode == Keys.Left)
            {
                l = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                r = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumpcnt>0)
            {
                jump = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                l = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                r = false;
            }
        }
        private void resetjump()
        {
            jumpspeed = 0;
            jumpcnt = 3;
            on = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jumpstr > 0 && jumpstr <= 40)
            {
                jumpstr += 10;
            }
            if(jump)
            {
                on = false;
                jumpcnt--;
                jumpspeed = -jumpstr;
                jumpstr = 0;
                jump = false;
            }
            if(l)
            {
                if (player.Left >= speed)
                    player.Left -= speed;
                else
                    player.Left = 0;
            }
            if (r)
            {
                if (player.Left + player.Width + speed <= 560)
                    player.Left += speed;
                else
                    player.Left = 560 - player.Width;
            }
            foot = player.Top + player.Height;
            if(jumpspeed>=0)//只在下墜時判斷
            {
                if (foot <= ground.Top && foot + jumpspeed >= ground.Top)
                {
                    player.Top = ground.Top - player.Height;
                    resetjump();
                }
                else if (foot <= plat1.Top && foot + jumpspeed >= plat1.Top)
                {
                    if (player.Left + player.Width - 5  >= plat1.Left && player.Left <= plat1.Left + plat1.Width - 5)
                    {
                        player.Top = plat1.Top - player.Height;
                        resetjump();
                    }
                    else
                        on = false;
                }
                else if(foot<=plat2.Top && foot + jumpspeed >= plat2.Top)
                {
                    if (player.Left + player.Width - 5 >= plat2.Left && player.Left <= plat2.Left + plat2.Width - 5)
                    {
                        player.Top = plat2.Top - player.Height;
                        resetjump();
                    }
                    else
                        on = false;
                }
                else if(foot<=plat3.Top && foot + jumpspeed >= plat3.Top)
                {
                    if (player.Left + player.Width - 5 >= plat3.Left && player.Left <= plat3.Left + plat3.Width - 5)
                    {
                        player.Top = plat3.Top - player.Height;
                        resetjump();
                    }
                    else
                        on = false;
                }
                else if (foot <= plat4.Top && foot + jumpspeed >= plat4.Top)
                {
                    if (player.Left + player.Width - 5 >= plat4.Left && player.Left <= plat4.Left + plat4.Width - 5)
                    {
                        player.Top = plat4.Top - player.Height;
                        resetjump();
                    }
                    else
                        on = false;
                }
            }
            if (!on)
            {
                player.Top += jumpspeed;
                jumpspeed += a;
                
            }
        }
    }
}
