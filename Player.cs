using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace KGLB1
{
    internal class Player
    {
        public Image anim;
        public int x, y;
        public Size scale;
        public int currentFrame = 2;
        public int currentAnim = 5;
        //public Image part;
        public int speed;
        public Player(Size scale, int x, int y, Image anim)
        {
            this.scale = scale;
            this.x = x;
            this.y = y;
            this.anim = anim;
        }

        public void Left()
        {
            x -= speed;
        }

        public void Right()
        {
            x += speed;
        }
        public void Up()
        {
            y -= speed;
        }
        public void Down()
        {
            y += speed;
        }

        public void PlayAnimation(Graphics graphics, bool isPressed)
        {
            if (isPressed)
            {
                if (currentAnim != -1 && currentAnim <= 4)
                {
                    graphics.DrawImage(anim, x, y, new Rectangle(new Point(75 * currentFrame, 170 * currentAnim), new Size(75, 170)), GraphicsUnit.Pixel);
                }
            }
            else
            {
                if (currentAnim >= 5)
                {
                    graphics.DrawImage(anim, x, y, new Rectangle(new Point(75 * currentFrame, 170 * (currentAnim - 5)), new Size(75, 170)), GraphicsUnit.Pixel);
                }
            }
        }
    }
}
