using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // creating an array of checkbox values.
        public CheckBox[] chkArray = new CheckBox[8];
        public Form1()
        {
            InitializeComponent();

            // initalizing the virtual LED's on the Windows form to red backgrounds i.e. off.
            led1.BackColor = Color.Red;
            led2.BackColor = Color.Red;
            led3.BackColor = Color.Red;
            led4.BackColor = Color.Red;
            led5.BackColor = Color.Red;
            led6.BackColor = Color.Red;
            led7.BackColor = Color.Red;
            led8.BackColor = Color.Red;

            // telling the chkarray which led is which.
            chkArray[0] = led1;
            chkArray[1] = led2;
            chkArray[2] = led3;
            chkArray[3] = led4;
            chkArray[4] = led5;
            chkArray[5] = led6;
            chkArray[6] = led7;
            chkArray[7] = led8;

        }

        private void update(int i)
        {
            int newValue = 0;

            // polling through the array and adding the value and chaning the on screen color.
            for (int p = 0; p < chkArray.Length; p++)
            {
                

                if (chkArray[p].Checked != true)
                {
                    chkArray[p].BackColor = Color.Red;
                    newValue += Convert.ToInt32(Math.Pow(2, p));
                }
                else 
                {
                    chkArray[p].BackColor = Color.Green;
                    
                }
            }

            label1.Text = newValue.ToString();
            try
            {

                using (Task ledUpdate = new Task())
                {
                    //  Create an Digital Output channel and name it.
                    ledUpdate.DOChannels.CreateChannel(textBox1.Text, "", ChannelLineGrouping.OneChannelForAllLines);


                    //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                    //  of digital data on demand, so no timeout is necessary.
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(ledUpdate.Stream);
                    writer.WriteSingleSamplePort(true, (UInt32)newValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Quit_Click(object sender, EventArgs e)
        {
            // if the user hits quit then turn all of the led's off.
            led1.BackColor = Color.Red;
            led2.BackColor = Color.Red;
            led3.BackColor = Color.Red;
            led4.BackColor = Color.Red;
            led5.BackColor = Color.Red;
            led6.BackColor = Color.Red;
            led7.BackColor = Color.Red;
            led8.BackColor = Color.Red;

            // clearing out the array.
            try
            {

                using (Task ledUpdate = new Task())
                {
                    //  Create an Digital Output channel and name it.
                    ledUpdate.DOChannels.CreateChannel(textBox1.Text, "", ChannelLineGrouping.OneChannelForAllLines);


                    //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                    //  of digital data on demand, so no timeout is necessary.
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(ledUpdate.Stream);
                    writer.WriteSingleSamplePort(true, (UInt32)255);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.Exit();
        }

        #region mouseclick?

        private void led1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void led8_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
        #region checkChanged

        private void led8_CheckedChanged(object sender, EventArgs e)
        {
            update(7);
        }

        private void led7_CheckedChanged(object sender, EventArgs e)
        {
            update(6);
        }

        private void led6_CheckedChanged(object sender, EventArgs e)
        {
            update(5);
        }

        private void led5_CheckedChanged(object sender, EventArgs e)
        {
            update(4);
        }

        private void led4_CheckedChanged(object sender, EventArgs e)
        {
            update(3);
        }

        private void led3_CheckedChanged(object sender, EventArgs e)
        {
            update(2);
        }

        private void led2_CheckedChanged(object sender, EventArgs e)
        {
            update(1);
        }

        private void led1_CheckedChanged(object sender, EventArgs e)
        {
            update(0);
        }
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // clearing out the array.
            try
            {

                using (Task ledUpdate = new Task())
                {
                    //  Create an Digital Output channel and name it.
                    ledUpdate.DOChannels.CreateChannel(textBox1.Text, "", ChannelLineGrouping.OneChannelForAllLines);


                    //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                    //  of digital data on demand, so no timeout is necessary.
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(ledUpdate.Stream);
                    writer.WriteSingleSamplePort(true, (UInt32)255);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}