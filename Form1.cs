using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Creates an instance of type inputs called a
        inputs a = new inputs();
        //Creates a Graphics called drawArea
        Graphics drawArea;

        //Constructor for Form1
        public Form1()
        {
            InitializeComponent();
            //Sets the target of drawArea to pictureBox1
            drawArea = pictureBox1.CreateGraphics();
        }

        //Button to draw the polygon labeled Draw Polygon
        private void button1_Click(object sender, EventArgs e)
        {
            //Defines a pen to draw with
            Pen blackPen = new Pen(Color.Black);

            //For loop to draw the polygon, drawing an edge from current vertex to the next vertex in the list
            for (int i = 0; i < a.xCords.Length; i++)
            {
                //if the current vertex is not the last vertex in the list, draw an edge from current vertex to next vertex
                if (i < a.xCords.Length - 1)
                {
                    drawArea.DrawLine(blackPen, a.xCords[i], a.yCords[i], a.xCords[i+1], a.yCords[i+1]);
                }
                //if the current vertex is the last vertex in the list, draw an edge from last vertex to first vertex
                if (i == a.xCords.Length - 1)
                {
                    drawArea.DrawLine(blackPen, a.xCords[i], a.yCords[i], a.xCords[0], a.yCords[0]);
                }


            }
        }

        //Default function creation for pictureBox1
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
