﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        Rectangle Raumschiff;
        bool RaumschiffBewegenLinks = false;
        bool RaumschiffBewegenRechts = false;
        int xRaumschiff = 35;
        int yRaumschiff = 35;

        public Form1()
        {
            //gametimer
            timer = new Timer();
            timer.Start();
            timer.Interval = 1;          //150 Standard
            timer.Enabled = true;
            timer.Tick += Timer_tick;
            DoubleBuffered = true;

            InitializeComponent();
        }
        private void Timer_tick(object sender, EventArgs e)
        {
            if (RaumschiffBewegenLinks)
            {
                xRaumschiff += 20;
            }

            if (RaumschiffBewegenRechts)
            {
                xRaumschiff -= 20;
            }



            Invalidate();
        }


        Timer timer;

        public void MoveRaumschiff()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Raumschiff = new Rectangle();
            Pen stiftSchwarz = new Pen(Color.Black);
            Graphics graphics = e.Graphics;
            graphics.DrawRectangle(stiftSchwarz, this.ClientSize.Width / 2 - xRaumschiff / 2, this.ClientSize.Height - 50, 50, 50);
            base.OnPaint(e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                RaumschiffBewegenLinks = true;

            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
                RaumschiffBewegenRechts = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                RaumschiffBewegenLinks = false;

            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
                RaumschiffBewegenRechts = false;
        }
    }
}