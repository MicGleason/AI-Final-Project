using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /// <summary>
    /// Class currently being used by button1_Click for the arrays of x and y coordinates
    /// Change as needed to fit whatever implementation you may need
    /// Remember, whatever you change here will need to translate over to Form1.cs
    ///     You will need to change the class instance creation on line 16,
    ///     The reference to a.xCords.Length in lines 35, 38 and 43
    ///     and the inputs for the drawArea.DrawLine in lines 40 and 45
    /// </summary>

    public class inputs
    {
        public int[] xCords = new int[10];
        public int[] yCords = new int[10];

        public inputs()
        {
            xCords[0] = 100;
            yCords[0] = 100;
            xCords[1] = 200;
            yCords[1] = 200;
            xCords[2] = 300;
            yCords[2] = 200;
            xCords[3] = 350;
            yCords[3] = 300;
            xCords[4] = 350;
            yCords[4] = 250;
            xCords[5] = 400;
            yCords[5] = 225;
            xCords[6] = 350;
            yCords[6] = 200;
            xCords[7] = 300;
            yCords[7] = 175;
            xCords[8] = 200;
            yCords[8] = 150;
            xCords[9] = 150;
            yCords[9] = 100;
        }


        //Function to draw a red line over the already created black polygon
        //can be used to show the path the AI takes along the polygon
        public void drawRedLine(Graphics d, int x1, int y1, int x2, int y2)
        {
            //Defines a pen to draw with
            Pen redPen = new Pen(Color.Red);

            d.DrawLine(redPen, x1, y1, x2, y2);

        }
        
    }
}
