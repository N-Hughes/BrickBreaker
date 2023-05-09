using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace BrickBreaker
{
    public partial class Form1 : Form
    {

        public static  int totalScore = 0;

        public static float size = 16;


        // Creating a custom font (16p)
        #region
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();
        // Accessing the minecraft font on all forms
        public static Font myFont;
        #endregion


        public Form1()
        {
            InitializeComponent();
            // adding the custom font (16p)
            #region 

            FontChange();
            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }


        public static void FontChange()
        {
            byte[] fontData = Properties.Resources.Minecraft;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Minecraft.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Minecraft.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], size);
        }




    }
}
