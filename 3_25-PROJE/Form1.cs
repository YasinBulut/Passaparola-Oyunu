﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_25_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlıs = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney kısmındaki Kıyı Bölgesi ?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz ?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz ?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı olduğu metin ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne ?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi ?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi ?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festival ?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Yılın 3. ayı ?";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Üflemeli müzik aleti ?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Halk şairi ?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Çoçukların pek sevmedği pirinç havuç gibi sebzelerle yapılan yemek ?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "11 ayın sultanı ?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "İngilizcede yılan ?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = " Ümit kelimesinin eş anlamlısı?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı ?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı ?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan kahvaltı besini ?";
                button23.BackColor = Color.Yellow;
            }
        }
                private void textBox1_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        switch (soruno)
                        {
                            //cevap 1
                            case 1:
                                if (textBox1.Text == "akdeniz")
                                {
                                    button1.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button1.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //ceap 2
                            case 2:
                                if (textBox1.Text == "bursa")
                                {
                                    button2.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button2.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap3
                            case 3:
                                if (textBox1.Text == "cuma")
                                {
                                    button3.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button3.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap4
                            case 4:
                                if (textBox1.Text == "diyarbakır")
                                {
                                    button4.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button4.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap5
                            case 5:
                                if (textBox1.Text == "eski")
                                {
                                    button5.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button5.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap6
                            case 6:
                                if (textBox1.Text == "ferman")
                                {
                                    button6.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button6.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap7
                            case 7:
                                if (textBox1.Text == "güneş")
                                {
                                    button7.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button7.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap8
                            case 8:
                                if (textBox1.Text == "halı")
                                {
                                    button8.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button8.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            //cevap9
                            case 9:
                                if (textBox1.Text == "ısparta")
                                {
                                    button9.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button9.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            case 10:
                                if (textBox1.Text == "içel")
                                {
                                    button10.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button10.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                            case 11:
                                if (textBox1.Text == "jandarma")
                                {
                                    button11.BackColor = Color.Green;
                                    dogru++;
                                    lbldogru.Text = dogru.ToString();
                                }
                                else
                                {
                                    button11.BackColor = Color.Red;
                                    yanlıs++;
                                    lblyanlıs.Text = yanlıs.ToString();
                                }
                                break;
                                
                        }
                textBox1.Text = "";
            }
                }       
        }
    }

