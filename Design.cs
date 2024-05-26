using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyKrestikiNoliki
{
    public class Design
    {
        public static Color Red = Color.FromArgb(220, 20, 20);
        public static Color Blue = Color.FromArgb(40, 20, 220);

        public static Color DarkWhite = Color.FromArgb(227, 227, 227);

        public static Color LightRed = Color.FromArgb(230, 10, 25);
        public static Color LightBlue = Color.FromArgb(0, 160, 255);

        public static Color DarkGray = Color.FromArgb(33, 33, 33);
        public static Color Gray = Color.FromArgb(56, 56, 56);
        public static Color LightGray = Color.FromArgb(180, 180, 180);

        public static Font Font18pt = new Font("Arial", 18.0f);
        public static Font Font18ptBold = new Font("Arial", 18.0f, FontStyle.Bold);

        public static Font Font16pt = new Font("Arial", 16.0f);
        public static Font Font16ptBold = new Font("Arial", 16.0f, FontStyle.Bold);

        public static Font Font14pt = new Font("Arial", 14.0f);
        public static Font Font14ptBold = new Font("Arial", 14.0f, FontStyle.Bold);

        public static Font Font12pt = new Font("Arial", 12.0f);
        public static Font Font12ptBold = new Font("Arial", 12.0f, FontStyle.Bold);

        public static void setRoundButton(Button btn)
        {
            GraphicsPath gpath = new GraphicsPath();

            gpath.AddRectangle(new Rectangle(0, 0, btn.Width, btn.Height));

            btn.Region = new Region(gpath);
        }

        public static void setLabelDesign(Label lbl, Color clr, Font fnt)
        {
            lbl.ForeColor = clr;
            lbl.Font = fnt;
        }

        public static void setButtonDesign(Button btn, Color fclr, Color bclr, Font fnt)
        {
            btn.ForeColor = fclr;
            btn.BackColor = bclr;
            btn.Font = fnt;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Design.DarkGray;
        }

        public static void setHoverButton(Button btn)
        {
            Color temp = btn.BackColor;
            btn.BackColor = btn.ForeColor;
            btn.ForeColor = temp;
        }

        public static void setLeaveButton(Button btn)
        {
            Color temp = btn.BackColor;
            btn.BackColor = btn.ForeColor;
            btn.ForeColor = temp;
        }


    }
}
