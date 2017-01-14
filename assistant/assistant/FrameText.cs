using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace assistant
{
    class FrameText
    {
        string framedMessage;
        

        public FrameText(string framedMessage)
        {
            
            framedMessage = framedMessage;
        }

        public void sending()
        {
            bool permission = confirmation(framedMessage);
            if (permission == true)
            {

            }
        }
       public bool confirmation(string frMsg)
        {
            string ask = "Did you mean: ";
            ask = ask + frMsg;

            string caption = "Text Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result;
            result = MessageBox.Show(ask, caption, buttons);

            if (result == DialogResult.Yes)
            {
                string askSend = "Do you want to send this message \n" + frMsg;
                string captionSend = "Sending Confirmation";
                MessageBoxButtons buttonSend = MessageBoxButtons.YesNo;

                DialogResult resultSend;
                resultSend = MessageBox.Show(askSend, captionSend, buttonSend);

                if (resultSend == DialogResult.Yes)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}
