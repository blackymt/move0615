using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enshu0608
{
    public partial class Form1 : Form
    {
        int time = 0;

        //const = 定数　/　初期化のみできて、実行中に変更できない
        const int LABEL_COUNT = 5;


        private static Random rand = new Random();
        int[] vx = new int[LABEL_COUNT];
        int[] vy = new int[LABEL_COUNT];
         // int vx1 = rand.Next(0, 20);
        //int vy1 = rand.Next(0, 20);

        //int vx2 = rand.Next(0, 30);
        //int vy2 = rand.Next(0, 30);

       // int vx3 = rand.Next(0, 10);
       // int vy3 = rand.Next(0, 10);

        Label[] labels = new Label[LABEL_COUNT];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < LABEL_COUNT; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "◆";
                Controls.Add(labels[i]);
                labels[i].Font = label1.Font;
                labels[i].ForeColor = label1.ForeColor;

                labels[i].Left = rand.Next(0, ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(0, ClientSize.Height - labels[i].Height);
                vx[i] = rand.Next(-10, 30);
                vy[i] = rand.Next(-10, 30);
            }

          /*  //1
            label1.Left = rand.Next(0, ClientSize.Width - label1.Width);
            label1.Top = rand.Next(0, ClientSize.Height - label1.Height);
            vx[0] = rand.Next(10, 20);
            vy[0] = rand.Next(10, 20);

            //2
            label2.Left = rand.Next(0, ClientSize.Width - label2.Width);
            label2.Top = rand.Next(0, ClientSize.Height - label2.Height);
            vx[1] = rand.Next(10, 20);
            vy[1] = rand.Next(10, 20);

            //3
            label3.Left = rand.Next(0, ClientSize.Width - label3.Width);
            label3.Top = rand.Next(0, ClientSize.Height - label3.Height);
            vx[2] = rand.Next(10, 20);
            vy[2] = rand.Next(10, 20);


            */



        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            time++;
            label2.Text = "Time" + time;
            Point cpos;
            cpos = MousePosition;
            cpos = PointToClient(cpos);

            label3.Left = cpos.X - label3.Width / 2;
            label3.Top = cpos.Y - label3.Height / 2;



            for (int i = 0; i < LABEL_COUNT;i++ )
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                   vx[i] = -vx[i];
                }
                if (labels[i].Left > ClientSize.Width - labels[i].Width)
                {
                    vx[i] = -vx[i];

                }
                if (labels[i].Top < 0)
                {
                    vy[i] = -vy[i];

                }
                if (labels[i].Top > ClientSize.Height - labels[i].Height)
                {
                    vy[i] = -vy[i];

                }

                if ((cpos.X >= labels[i].Left) && (cpos.X <= labels[i].Right) && (cpos.Y >= labels[i].Top) && (cpos.Y <= labels[i].Bottom))
                {
                    labels[i].Visible = false;

                    if (i == 0)
                    {
                        timer1.Enabled = false;
                    }
                }
                    
                   
                       
                        
                                

                    
                 
               
                            
                
            }

            
           

            /*    label1.Left += vx[0];
            label1.Top += vy[0];
            if (label1.Left < 0)
            {

                vx[0] = -vx[0];
             
            }
            if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx[0] = -vx[0];

            }
            if (label1.Top < 0)
            {
                vy[0] = -vy[0];
            
            }
            if (label1.Top > ClientSize.Height - label1.Height)
            {
               vy[0] = -vy[0];
            
            }

            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {

                vx[1] = -vx[1];
            }
            if (label2.Left > ClientSize.Width - label2.Width)
            {
                vx[1] = -vx[1];

            }
            if (label2.Top < 0)
            {
                vy[1] = -vy[1];

            }
            if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy[1] = -vy[1];
                
            }


            label3.Left += vx[2];
            label3.Top += vy[2];
            if (label3.Left < 0)
            {

                vx[2] = -vx[2];
            }
            if (label3.Left > ClientSize.Width - label3.Width)
            {
                vx[2] = -vx[2];

            }
            if (label3.Top < 0)
            {
                vy[2] = -vy[2];

            }
            if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy[2] = -vy[2];

            }


          
           // if ((cpos.X > label1.Left) && (cpos.X < label1.Right) && (cpos.Y > label1.Top) && (cpos.Y < label1.Bottom))
           // {

               // vx1 = 0;
               // vy1 = 0;

           // }
            //if ((cpos.X > label2.Left) && (cpos.X < label2.Right) && (cpos.Y > label2.Top) && (cpos.Y < label2.Bottom))
           // {

               // vx2 = 0;
               // vy2 = 0;

           // }
           // if ((cpos.X > label3.Left) && (cpos.X < label3.Right) && (cpos.Y > label3.Top) && (cpos.Y < label3.Bottom))
          //  {

             //   vx3 = 0;
              //  vy3 = 0;

           // }*/

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
