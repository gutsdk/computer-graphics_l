using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGLB1
{
    public partial class Form1 : Form
    {
        Image playerImg, grassImg, dirtImg, npcImg;
        bool isPressed = false;
        Player player, npc;

        const int width = 10, height = 15;

        int[,] map;
        public Form1()
        {
            InitializeComponent();

            Bitmap bitmap = new Bitmap("E:\\projects\\CG\\KGLB1\\npc.png");

            playerImg = new Bitmap("E:\\projects\\CG\\KGLB1\\character.png");
            grassImg = new Bitmap("E:\\projects\\CG\\KGLB1\\grass.png");
            dirtImg = new Bitmap("E:\\projects\\CG\\KGLB1\\dirt.png");
            bitmap = ChangeColor(bitmap, 0, 0);
            npcImg = ChangeColor(bitmap, 1, 0);
            player = new Player(new Size(25, 50), 80, 0, playerImg);
            npc = new Player(new Size(30, 60), 1040, 560, npcImg);

            timer2.Interval = 17;
            timer1.Interval = 17;

            timer2.Tick += new EventHandler(UpdateMove);
            timer1.Tick += new EventHandler(Update);

            timer1.Start();
            timer2.Start();

            map = new int[width, height] {
            {9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 },
            {9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 },
            };

            this.KeyDown += new KeyEventHandler(Keyboard);
            this.KeyUp += new KeyEventHandler(FreeKeyboard);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public Bitmap ChangeColor(Bitmap scrBitmap, int num, int percent)
        {
            if(num == 1)
            {
                Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
                for (int i = 0; i < scrBitmap.Width; i++)
                {
                    for (int j = 0; j < scrBitmap.Height; j++)
                    {
                        if (scrBitmap.GetPixel(i, j).B == 255)//if (scrBitmap.GetPixel(i, j).A > 100 && ColorWithinRange(scrBitmap.GetPixel(i, j), Color.FromArgb(20, 80, 0), Color.FromArgb(40, 130, 255)))
                            newBitmap.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(255 - 255 * (percent / 100.0)), 0, 0, 255));
                        else
                            newBitmap.SetPixel(i, j, scrBitmap.GetPixel(i, j));
                    }
                }
                return newBitmap;
            }
            else
            {
                Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
                for (int i = 0; i < scrBitmap.Width; i++)
                {
                    for (int j = 0; j < scrBitmap.Height; j++)
                    {
                        if (ColorWithinRange(scrBitmap.GetPixel(i, j), Color.FromArgb(20, 80, 0), Color.FromArgb(40, 140, 255)))
                            newBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 255));
                        else
                            newBitmap.SetPixel(i, j, scrBitmap.GetPixel(i, j));
                    }
                }
                return newBitmap;
            }
        }

        bool ColorWithinRange(Color color, Color from, Color to)
        {
            return (from.R <= color.R && color.R <= to.R) && (from.G <= color.G && color.G <= to.G) && (from.B <= color.B && color.B <= to.B);
        }

        private void UpdateMove(object sender, EventArgs e)
        {
            switch (player.currentAnim)
            {
                default:
                    break;
                case 0:
                    player.Right();
                    npc.Left();
                    break;
                case 1:
                    player.Left();
                    npc.Right();
                    break;
                case 3:
                    player.Up();
                    npc.Down();
                    break;
                case 2:
                    player.Down();
                    npc.Up();
                    break;
            }
            player.speed = (int)numericSpeed.Value;
            npc.speed = (int)numericSpeed.Value;
            Invalidate();
        }

        private void numeriсTransparent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            npc.anim = ChangeColor(new Bitmap(npcImg), 1, (int)numeriсTransparent.Value);
        }

        private void numeriсTransparent_Enter(object sender, EventArgs e)
        {
            if (!numeriсTransparent.Focused) numeriсTransparent.Focus();
        }

        private void numeriсTransparent_Leave(object sender, EventArgs e)
        {
            if (numeriсTransparent.Focused) numeriсTransparent.Parent.Focus();
        }

        private void numericSpeed_Enter(object sender, EventArgs e)
        {
            if (!numericSpeed.Focused) numericSpeed.Focus();
        }

        private void numericSpeed_Leave(object sender, EventArgs e)
        {
            if (numericSpeed.Focused) numeriсTransparent.Parent.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            isPressed = false;
            switch (e.KeyCode.ToString())
            {
                default:
                    break;
                case "D":
                    player.currentAnim = 5;
                    npc.currentAnim = 6;
                    break;
                case "A":
                    player.currentAnim = 6;
                    npc.currentAnim = 5;
                    break;
                case "W":
                    player.currentAnim = 8;
                    npc.currentAnim = 7;
                    break;
                case "S":
                    player.currentAnim = 7;
                    npc.currentAnim = 8;
                    break;
            }
            player.currentFrame = 0;
            npc.currentFrame = 0;
        }

        private void Keyboard(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode.ToString())
            {
                default:
                    break;
                case "D":
                    player.currentAnim = 0;
                    npc.currentAnim = 1;
                    break;
                case "A":
                    player.currentAnim = 1;
                    npc.currentAnim = 0;
                    break;
                case "W":
                    player.currentAnim = 3;
                    npc.currentAnim = 2;
                    break;
                case "S":
                    player.currentAnim = 2;
                    npc.currentAnim = 3;
                    break;
            }
            isPressed = true;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            CreateMap(graphics);
            player.PlayAnimation(graphics, isPressed);
            npc.PlayAnimation(graphics, isPressed);
        }

        private void Update(object sender, EventArgs e)
        {
            if (isPressed)
            {
                timer1.Interval = 17;
                if (player.currentFrame == 11) player.currentFrame = 2;
                if (npc.currentFrame == 11) npc.currentFrame = 2;
            }
            else
            {
                timer1.Interval = 300;
                if (player.currentFrame == 2) player.currentFrame = 0;
                if (npc.currentFrame == 2) npc.currentFrame = 0;
            }
            player.currentFrame++;
            npc.currentFrame++;
            numeriсTransparent.Enabled = true;
            Invalidate();
        }

        private void CreateMap(Graphics graphics)
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(map[i, j] == 1)
                    {
                        graphics.DrawImage(grassImg, j * 80, i * 80, new Rectangle(new Point(0, 0), new Size(80, 80)), GraphicsUnit.Pixel);
                    }
                    else if(map[i, j] == 9)
                    {
                        graphics.DrawImage(dirtImg, j * 80, i * 80, new Rectangle(new Point(0, 0), new Size(80, 80)), GraphicsUnit.Pixel);
                    }
                }
            }
        }
    }
}