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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmpTB1 = N.Text;
        }

        public static string tmpTB1 = "";

        private void N_TextChanged(object sender, EventArgs e)
        {
            if (N.Text == "0") N.Text = "";
            if (N.Text != "")
            {
                int numb = 0;
                if (!char.IsDigit(N.Text[N.Text.Length - 1]))
                {
                    N.Text = tmpTB1;
                    N.SelectionStart = N.Text.Length;
                }
                else
                {
                    if (Convert.ToInt32(N.Text) > 16)
                    {
                        tmpTB1 = "16";
                        N.Text = tmpTB1;
                        N.SelectionStart = N.Text.Length;
                    }
                    else
                        tmpTB1 = N.Text;
                    numb = Convert.ToInt32(tmpTB1);
                }
                if (numb != 0)
                {
                    bool chetn = false;
                    label2.Text = "cos(x) = 1";
                    for (int i = 2; i < 2 * numb; i += 2)
                    {
                        if (!chetn)
                        {
                            label2.Text += " - ";
                            chetn = true;
                        }
                        else
                        {
                            label2.Text += " + ";
                            chetn = false;
                        }
                        label2.Text += "x^(" + i.ToString() + ")/" + i.ToString() + "!";
                    }
                    if (!chetn)
                    {
                        label2.Text += " - ...";
                    }
                    else
                    {
                        label2.Text += " + ...";
                    }
                }
            }
            else
            {
                tmpTB1 = "";
                label2.Text = "cos(x) = ";
            }
        }
        float cos(double x) // разложение в ряд функции cosx
        {
            double chlen = 1; // 1ый член ряда 
            double y = chlen; // значение функции при разложении с точностью до 1 члена ряда
            for (int i = 1; i < int.Parse(N.Text); i++)
            {
                //вычисление члена ряда на основе предыдущего
                chlen = Math.Pow((-1), i) * (Math.Abs(chlen) * Math.Pow(x, 2)/ ((i * 2) * ((i * 2) - 1)));
                //прибавление к значению функции значения очередного члена ряда
                y += chlen; 
            }           
            return (float)y;
        }
        float func(double p1, double p2, double x, double b) // вычисление значения заданной функции
        {
            if (x <= p1)
            {
                return (float)Math.Abs(Math.Exp(-2 * x) * Math.Sin(b * x));
            }
            else
            {
                if (p1 <= x && x <= p2)
                {
                    return (float)cos(b * x);
                }
                else
                    return (float)(Math.Exp(-x) * cos(b * x));
            }             
        }      
        private void calc_Click(object sender, EventArgs e)
        {
            tableOfValues.Text = "";
            if (N.Text != "" && x3TB.Text != "0,")
            {
                label3.Visible = true;
                label4.Visible = true;
                double x1 = 0;
                double x2 = 2;
                double x3 = double.Parse(x3TB.Text.ToString());
                double b = -2.9;
                double p1 = 1;
                double p2 = 1.2;
                double itCount = ((x2 - x1) / x3)+1; //кол-во шагов
                Bitmap bitmap = new Bitmap(doc.Width, doc.Height); 
                Graphics g = Graphics.FromImage(bitmap); 
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //сглаживание
                Pen p = new Pen(Color.Green, 1); //чем рисуем
                g.DrawLine(p, 10, 10, 10, doc.Height - 10); // ось Х
                g.DrawLine(p, 5, 25, 10, 10); g.DrawLine(p, 15, 25, 10, 10); //направление оси X
                g.DrawLine(p, 0, (doc.Height - 20) / 2, doc.Width, (doc.Height - 20) / 2); // ось Y
                g.DrawLine(p, doc.Width - 15, (doc.Height - 20) / 2 + 5, doc.Width, (doc.Height - 20) / 2); g.DrawLine(p, doc.Width - 15, (doc.Height - 20) / 2 - 5, doc.Width, (doc.Height - 20) / 2); //направление оси Y
                PointF[] listOfPoints = new PointF[Convert.ToInt32(itCount)];
                double x = x1;
                for (int i=0; i< Convert.ToInt32(itCount); i++)
                {    
                    listOfPoints[i].X = (float)x;            
                    listOfPoints[i].Y= func(p1,p2,x,b); //вычисление значения функции                                                   
                    if (listOfPoints[i].Y >= 0)
                        tableOfValues.Text += String.Format("{0:0.00}\t {1:0.00000000}",listOfPoints[i].X,listOfPoints[i].Y) + Environment.NewLine;
                    else
                        tableOfValues.Text += String.Format("{0:0.00}\t{1:0.00000000}", listOfPoints[i].X, listOfPoints[i].Y) + Environment.NewLine;
                    x += x3;
                }
                for (int i = 0; i < listOfPoints.Length; i++) 
                {
                    listOfPoints[i].X = listOfPoints[i].X * ((doc.Width-10)/(float)2) +10; // масштабирование по оси Х 
                    listOfPoints[i].Y = ((-1) * listOfPoints[i].Y * (doc.Height-20)/(float)2 + (doc.Height-20) / 2); // масштабирование по оси Y и симметрия относительно этой оси
                }
                g.DrawLines(p, listOfPoints);               
                doc.Image = bitmap;
            }
            else
            {
                doc.Image = null;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void x3TB_TextChanged(object sender, EventArgs e)
        {
            if (x3TB.Text.Length <= 2)
            {
                x3TB.Text = "0,";
            }
            else
            {
                if (x3TB.Text.Length > 4 || !char.IsDigit(x3TB.Text[x3TB.Text.Length - 1]))
                {
                    x3TB.Text = x3TB.Text.Substring(0, x3TB.Text.Length - 1);
                }
            }
            x3TB.SelectionStart = x3TB.Text.Length;
        }

        private void N_Click(object sender, EventArgs e)
        {
            N.SelectionStart = N.Text.Length;
        }

        private void x3TB_Click(object sender, EventArgs e)
        {
            x3TB.SelectionStart = x3TB.Text.Length;
        }
    }
}