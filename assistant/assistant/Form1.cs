using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assistant
{
    public partial class Form1 : Form
    {
        private bool button41WasClicked = false;
        private bool button42WasClicked = false;
        private bool button59WasClicked = false;
        public Form1()
        {
            InitializeComponent();
            moveHighlighter();
            moveHighlighterEmergency();
            moveHighlighterFrameText();
        }

       async Task PutTaskDelay()
        {
            await Task.Delay(3000);
        }


        public async void moveHighlighter()
        {
            PictureBox[] pics = new PictureBox[24];
            pics[0] = pic1;
            pics[1] = pic2;
            pics[2] = pic3;
            pics[3] = pic4;
            pics[4] = pic5;
            pics[5] = pic6;
            pics[6] = pic7;
            pics[7] = pic8;
            pics[8] = pic9;
            pics[9] = pic10;
            pics[10] = pic11;
            pics[11] = pic12;
            pics[12] = pic13;
            pics[13] = pic14;
            pics[14] = pic15;
            pics[15] = pic16;
            pics[16] = pic17;
            pics[17] = pic18;
            pics[18] = pic19;
            pics[19] = pic20;
            pics[20] = pic21;
            pics[21] = pic22;
            pics[22] = pic23;
            pics[23] = pic24;
            
            int i, j;
            for (i = 0; i < 24; i = i + 8) //loop for highlighting all tabs in slots of 8.
            { for (j = i; j < i + 8; j++) // highlight the selected 8.
                { pics[j].BackColor = System.Drawing.Color.SkyBlue;
                }
                await PutTaskDelay(); //delay after 8 highlighted.
                if (button41WasClicked == true) //if any of 8 clicked.
                {
                    button41WasClicked = false;
                    for (int k = i; k < i + 4; k++) //highlight the first four.
                    {
                        pics[k + 4].BackColor = System.Drawing.Color.Transparent; //make rest 4 transparent.
                    }
                    await PutTaskDelay(); //cause the delay of first four.
                    if (button41WasClicked == true) //if any of 4 selected
                    {
                        button41WasClicked = false; //variable reset
                        for (int h = i; h < i + 4; h++) //dehighlighting all
                        {
                            pics[h].BackColor = System.Drawing.Color.Transparent;
                        }
                        for (int g = i; g < i + 4; g++) //highlighting single tab
                        {
                            pics[g].BackColor = System.Drawing.Color.SkyBlue;
                            await PutTaskDelay(); //wait 
                            if (button41WasClicked == true) //if any of them clicked
                            {
                                button41WasClicked = false;
                                //Call pics of g ka onclick method
                                break;
                            }
                            pics[g].BackColor = System.Drawing.Color.Transparent;                           
                        } break;//end of for single tab
                    } //end of if 4 selected
                    for (int k = i + 4; k < i + 8; k++) //this loop is for the rest 4
                    {
                        pics[k - 4].BackColor = System.Drawing.Color.Transparent;//dehighlighting the earlier ones
                    }
                    for (int k = i + 4; k < i + 8; k++)
                    {
                        pics[k].BackColor = System.Drawing.Color.SkyBlue; //highlighting the rest four
                    }
                    await PutTaskDelay(); //wait if it has to select from the four
                    if (button41WasClicked == true)
                    {
                        button41WasClicked = false;
                        for (int h = i + 4; h < i + 8; h++) //dehighlighting all
                        {
                            pics[h].BackColor = System.Drawing.Color.Transparent;
                        }
                        for (int g = i + 4; g < i + 8; g++) //highlighting single tab
                        {
                            pics[g].BackColor = System.Drawing.Color.SkyBlue;
                            await PutTaskDelay(); //wait 
                            if (button41WasClicked == true) //if any of them clicked
                            {
                                button41WasClicked = false;
                                //Call pics of g ka onclick method
                                break;
                            }
                            pics[g].BackColor = System.Drawing.Color.Transparent;

                        } break;//end of for single tab
                    }
                }
                else
                {
                    for(int x=i;x<i+8;x++)
                    {
                        pics[x].BackColor = System.Drawing.Color.Transparent;
                    }
                }
            }
        }

        public async void moveHighlighterFrameText()
        {
            Button[] buttons = new Button[39];
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[9] = button10;
            buttons[10] = button11;
            buttons[11] = button13;
            buttons[12] = button14;
            buttons[13] = button15;
            buttons[14] = button16;
            buttons[15] = button17;
            buttons[16] = button18;
            buttons[17] = button19;
            buttons[18] = button20;
            buttons[19] = button21;
            buttons[20] = button22;
            buttons[21] = button23;
            buttons[22] = button24;
            buttons[23] = button25;
            buttons[24] = button26;
            buttons[25] = button27;
            buttons[26] = button29;
            buttons[27] = button28;
            buttons[28] = button39;
            buttons[29] = button12;
            buttons[30] = button31;
            buttons[31] = button32;
            buttons[32] = button33;
            buttons[33] = button34;
            buttons[34] = button35;
            buttons[35] = button36;
            buttons[36] = button37;
            buttons[37] = button38;
            buttons[38] = button30;
            int i, j;
            for (i = 0; i < 32; i = i + 8) //loop for highlighting all tabs in slots of 8.
            {
                for (j = i; j < i + 8; j++) // highlight the selected 8.
                {
                    buttons[j].BackColor = System.Drawing.Color.SkyBlue;
                }
                await PutTaskDelay(); //delay after 8 highlighted.
                if (button42WasClicked == true) //if any of 8 clicked.
                {
                    button42WasClicked = false;
                    for (int k = i; k < i + 4; k++) //highlight the first four.
                    {
                        buttons[k + 4].BackColor = System.Drawing.Color.Transparent; //make rest 4 transparent.
                    }
                    await PutTaskDelay(); //cause the delay of first four.
                    if (button42WasClicked == true) //if any of 4 selected
                    {
                        button42WasClicked = false; //variable reset
                        for (int h = i; h < i + 4; h++) //dehighlighting all
                        {
                            buttons[h].BackColor = System.Drawing.Color.Transparent;
                        }
                        for (int g = i; g < i + 4; g++) //highlighting single tab
                        {
                            buttons[g].BackColor = System.Drawing.Color.SkyBlue;
                            await PutTaskDelay(); //wait 
                            if (button42WasClicked == true) //if any of them clicked
                            {
                                button42WasClicked = false;
                                //Call pics of g ka onclick method
                                break;
                            }
                            buttons[g].BackColor = System.Drawing.Color.Transparent;
                        }
                        break;//end of for single tab
                    }
                    for (int k = i + 4; k < i + 8; k++) //this loop is for the rest 4
                    {
                        buttons[k - 4].BackColor = System.Drawing.Color.Transparent;//dehighlighting the earlier ones
                    }
                    for (int k = i + 4; k < i + 8; k++)
                    {
                        buttons[k].BackColor = System.Drawing.Color.SkyBlue; //highlighting the rest four
                    }
                    await PutTaskDelay(); //wait if it has to select from the four
                    if (button42WasClicked == true)
                    {
                        button42WasClicked = false;
                        for (int h = i + 4; h < i + 8; h++) //dehighlighting all
                        {
                            buttons[h].BackColor = System.Drawing.Color.Transparent;
                        }
                        for (int g = i + 4; g < i + 8; g++) //highlighting single tab
                        {
                            buttons[g].BackColor = System.Drawing.Color.SkyBlue;
                            await PutTaskDelay(); //wait 
                            if (button42WasClicked == true) //if any of them clicked
                            {
                                button42WasClicked = false;
                                //Call pics of g ka onclick method
                                break;
                            }
                            buttons[g].BackColor = System.Drawing.Color.Transparent;

                        }
                        break;//end of for single tab
                    }
                }
                else
                    {
                        for (int x = i; x < i + 8; x++)
                        {
                            buttons[x].BackColor = System.Drawing.Color.Transparent;
                        }
                    }
                }
            }

        private async void moveHighlighterEmergency()
        {
            Button[] buttonE = new Button[16];
            buttonE[0] = button43;
            buttonE[1] = button44;
            buttonE[2] = button45;
            buttonE[3] = button46;
            buttonE[4] = button50;
            buttonE[5] = button49;
            buttonE[6] = button48;
            buttonE[7] = button47;
            buttonE[8] = button54;
            buttonE[9] = button53;
            buttonE[10] = button52;
            buttonE[11] = button51;
            buttonE[12] = button55;
            buttonE[13] = button56;
            buttonE[14] = button57;
            buttonE[15] = button58;
            int i, j;
            for (i = 0; i < 16; i = i + 4) //loop for highlighting all tabs in slots of 8.
            {
                for (j = i; j < i + 4; j++) // highlight the selected 8.
                {
                    buttonE[j].BackColor = System.Drawing.Color.SkyBlue;
                }
                await PutTaskDelay();
                if (button59WasClicked == true)
                {
                    button59WasClicked = false;
                    for(int k=i;k<i+4;k++)
                    {
                        buttonE[k+1].BackColor = System.Drawing.Color.Transparent;                       
                    }
                    for(int g=i;g<i+4;g++)
                    {
                        buttonE[g].BackColor = System.Drawing.Color.SkyBlue;
                        await PutTaskDelay();                      
                        if(button59WasClicked==true)
                        {
                                button59WasClicked = false;
                                //Call pics of g ka onclick method
                                break;
                        }
                        buttonE[g].BackColor = System.Drawing.Color.Transparent;
                    } break;
                }
                else
                {                    
                        for (int x = i; x < i + 4; x++)
                        {
                            buttonE[x].BackColor = System.Drawing.Color.Transparent;
                        }                    
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tab = "I want to shave.";
            string tabName = "sahve";
            DailyRoutine d = new DailyRoutine(tabName, 3, tab);
            d.onClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string tab = "Time";
            string tabName = "time";
            DailyRoutine d = new DailyRoutine(tabName, 6, tab);
            d.onClick();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string letter = "m";
            textBox13.AppendText(letter);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string tab = "I want water";
            string tabName = "water";
            DailyRoutine d = new DailyRoutine(tabName,1,tab);
            d.onClick();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string letter = "3";
            textBox13.AppendText(letter);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string letter = "4";
            textBox13.AppendText(letter);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string letter = "7";
            textBox13.AppendText(letter);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string letter = "8";
            textBox13.AppendText(letter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = "a";
            textBox13.AppendText(letter);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string letter = "b";
            textBox13.AppendText(letter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string letter = "c";
            textBox13.AppendText(letter);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string letter = "d";
            textBox13.AppendText(letter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string letter = "e";
            textBox13.AppendText(letter);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string letter = "f";
            textBox13.AppendText(letter);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string letter = "g";
            textBox13.AppendText(letter);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string letter = "h";
            textBox13.AppendText(letter);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string letter = "i";
            textBox13.AppendText(letter);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string letter = "j";
            textBox13.AppendText(letter);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string letter = "k";
            textBox13.AppendText(letter);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string letter = "l";
            textBox13.AppendText(letter);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string letter = "n";
            textBox13.AppendText(letter);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string letter = "o";
            textBox13.AppendText(letter);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string letter = "p";
            textBox13.AppendText(letter);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string letter = "q";
            textBox13.AppendText(letter);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string letter = "r";
            textBox13.AppendText(letter);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string letter = "s";
            textBox13.AppendText(letter);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string letter = "t";
            textBox13.AppendText(letter);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string letter = "u";
            textBox13.AppendText(letter);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string letter = "v";
            textBox13.AppendText(letter);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string letter = "w";
            textBox13.AppendText(letter);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string letter = "x";
            textBox13.AppendText(letter);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string letter = "y";
            textBox13.AppendText(letter);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string letter = "z";
            textBox13.AppendText(letter);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string letter = ",";
            textBox13.AppendText(letter);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string letter = ".";
            textBox13.AppendText(letter);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string letter = " ";
            textBox13.AppendText(letter);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string letter = "1";
            textBox13.AppendText(letter);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string letter = "2";
            textBox13.AppendText(letter);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string letter = "5";
            textBox13.AppendText(letter);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string letter = "6";
            textBox13.AppendText(letter);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string letter = "9";
            textBox13.AppendText(letter);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string letter = "0";
            textBox13.AppendText(letter);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string framedMsg = textBox13.Text;
            FrameText ft = new FrameText(framedMsg);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            string tab = "I want hot food.";
            string tabName = "hot food";
            DailyRoutine d = new DailyRoutine(tabName, 2, tab);
            d.onClick();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            string tab = "Turn on/off the fan.";
            string tabName = "fan";
            DailyRoutine d = new DailyRoutine(tabName, 4, tab);
            d.onClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string tab = "I want tea.";
            string tabName = "tea";
            DailyRoutine d = new DailyRoutine(tabName, 5, tab);
            d.onClick();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            string tab = "I want coffee";
            string tabName = "coffee";
            DailyRoutine d = new DailyRoutine(tabName, 6, tab);
            d.onClick();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string tab = "Phone";
            string tabName = "Phone";
            DailyRoutine d = new DailyRoutine(tabName, 7, tab);
            d.onClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string tab = "Hand wash";
            string tabName = "hand wash";
            DailyRoutine d = new DailyRoutine(tabName, 8, tab);
            d.onClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string tab = "Get wheel chair";
            string tabName = "wheel chair";
            DailyRoutine d = new DailyRoutine(tabName, 9, tab);
            d.onClick();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string tab = "TV";
            string tabName = "TV";
            DailyRoutine d = new DailyRoutine(tabName, 10, tab);
            d.onClick();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string tab = "News on TV";
            string tabName = "news";
            DailyRoutine d = new DailyRoutine(tabName, 11, tab);
            d.onClick();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string tab = "Music on TV";
            string tabName = "music";
            DailyRoutine d = new DailyRoutine(tabName, 12, tab);
            d.onClick();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string tab = "I need towel";
            string tabName = "towel";
            DailyRoutine d = new DailyRoutine(tabName, 13, tab);
            d.onClick();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string tab = "Stranger man";
            string tabName = "man";
            DailyRoutine d = new DailyRoutine(tabName, 14, tab);
            d.onClick();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string tab = "Stranger woman";
            string tabName = "woman";
            DailyRoutine d = new DailyRoutine(tabName, 15, tab);
            d.onClick();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string tab = "I need hair wash";
            string tabName = "hair wash";
            DailyRoutine d = new DailyRoutine(tabName, 16, tab);
            d.onClick();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string tab = "I need medicine";
            string tabName = "medicine";
            DailyRoutine d = new DailyRoutine(tabName, 17, tab);
            d.onClick();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string tab = "Doctor";
            string tabName = "doctor";
            DailyRoutine d = new DailyRoutine(tabName, 18 ,tab);
            d.onClick();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string tab = "I need injection";
            string tabName = "injection";
            DailyRoutine d = new DailyRoutine(tabName, 19, tab);
            d.onClick();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string tab = "Volume Down";
            string tabName = "Volume Down";
            DailyRoutine d = new DailyRoutine(tabName, 20, tab);
            d.onClick();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string tab = "Volume Up";
            string tabName = "Volume Up";
            DailyRoutine d = new DailyRoutine(tabName, 21, tab);
            d.onClick();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string tab = "Mute";
            string tabName = "mute";
            DailyRoutine d = new DailyRoutine(tabName, 22, tab);
            d.onClick();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string tab = "Sleep";
            string tabName = "sleep";
            DailyRoutine d = new DailyRoutine(tabName, 23, tab);
            d.onClick();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41WasClicked = true;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42WasClicked = true;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            button59WasClicked = true;
        }
    }
}
