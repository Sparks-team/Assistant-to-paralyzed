using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace assistant
{
    class DailyRoutine
    {
        private string tabName;
        public int number;
        public string tabMessage;

        //defining constructor
        public DailyRoutine(string tabName,int serialNum, string tabMsg)
        {
            tabName = tabName; //the name of tab
            number = serialNum; //serial no. of tab
            tabMessage = tabMsg; //the msg tab will contain
        }

       
        public void onClick() //click event called on clicking
        {
            confirmations(tabMessage); 
        }

        public bool confirmations(string tabMsg)
        {
            //preparing parameters to be passed in dialogueBox
            string ask = "Did you mean: ";
            ask = ask + tabMsg;
            string caption = "Text Confirmaition";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result; //stores result of dialogue box.

            //dialogue box created
           result =  MessageBox.Show(ask,caption,buttons);

            if (result == DialogResult.Yes) //message confirmed.
            {
                //ask for sending confirmaiton.
                string askSend = "Do you want to send this message \n" + tabMsg;
                string captionSend = "Sending Confirmation";
                MessageBoxButtons buttonsSend = MessageBoxButtons.YesNo;
                DialogResult resultSend;
                resultSend = MessageBox.Show(askSend, captionSend, buttonsSend);

                if (resultSend == DialogResult.Yes)
                {
                    return true;
                } //sending confirmed

                else
                {
                    return false; //do not send
                }
            }

            else
            {
                return false; //did not mean that message.
            }

        } //end confirmations

    } //end class Daily Routine
}
