using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghostmouse_Looper
{
    public partial class GhostmouseLooper : Form
    {

        // Backing field for making sure the program exits successfully
        bool _still_running;

        public GhostmouseLooper()
        {
            InitializeComponent();
        }

        /********************************************************
         * Event Handler for the Ghostmouse Link
         * Description: Takes the user to the Ghostmouse webpage using default browser
         * Arguments: None
         * Preconditions/Requirements: None
         * Returns: None
         *******************************************************/
        private void ghostmouseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ghost-mouse.com/");
        }

        /********************************************************
         * Event Handler for the Loop Button
         * Description: Runs the main loop, until it runs out of iterations
         * Arguments: None
         * Preconditions/Requirements: None
         * Returns: None
         *******************************************************/
        private void loopButton_Click(object sender, EventArgs e)
        {
            const long MAX_LOOPS = 100000;
            const int MAX_LENGTH = 3600;

            long remIters = 0;
            long initIters = 0;
            int loopLen = 0;
            string ghostKey = "{" + ghostMouseKeyTextbox.Text + "}";
            bool errorsExist = false;
            string errMessage = "";
            long secsLeft = 0;

            // If the loop is already running, stop it.
            if (loopButton.Text == "Stop")
            {
                loopButton.Text = "Loop";
                this.loopButton.BackColor = System.Drawing.Color.PaleGreen;

                // Set fonts back to default
                completionTimeLabel.Font = new Font(completionTimeLabel.Font, FontStyle.Regular);
                remainingIterationsLabel.Font = new Font(remainingIterationsLabel.Font, FontStyle.Regular);
                remainingTimeLabel.Font = new Font(remainingTimeLabel.Font, FontStyle.Regular);

                _still_running = false;
            }
            else
            {

                //Check for the length of loops; must be between 1 - MAX_LENGTH.
                if (int.TryParse(loopLengthTextbox.Text, out loopLen) && loopLen > 0)
                {
                    if (loopLen > MAX_LENGTH)
                    {
                        if (errorsExist)
                        {
                            errMessage += "\n";
                        }
                        errMessage += "The iteration length cannot be longer than 3,600 (1 hour).";
                        errorsExist = true;
                    }
                }
                else
                {
                    if (errorsExist)
                    {
                        errMessage += "\n";
                    }
                    errMessage += "The iteration length (in seconds) is invalid.";
                    errorsExist = true;

                }

                //Check for the number of loops. must be between 1 - MAX_LOOPS.
                if (long.TryParse(loopCountTextbox.Text, out remIters) && remIters > 0)
                {
                    if (remIters > MAX_LOOPS)
                    {
                        if (errorsExist)
                        {
                            errMessage += "\n";
                        }
                        errMessage += "The maximum number of loops is " + MAX_LOOPS.ToString() + ".";
                        errorsExist = true;
                    }
                    else
                    {
                        initIters = remIters;
                    }
                }
                else
                {
                    if (errorsExist)
                    {
                        errMessage += "\n";
                    }
                    errMessage += "The number of loops is invalid.";
                    errorsExist = true;

                }

                //Check for the Ghostmouse key -- it doesn't have to be correct, but it cannot be blank.
                if (ghostKey == "")
                {
                    if (errorsExist)
                    {
                        errMessage += "\n";
                    }
                    errMessage += "Please enter the key which activates Ghostmouse (\"F6\" for example.)";
                    errorsExist = true;
                }

                //If errors happened, deal with those. Otherwise, let's loop!
                if (errorsExist)
                {
                    MessageBox.Show(errMessage);
                }
                else
                {

                    _still_running = true;

                    loopButton.Text = "Stop";
                    this.loopButton.BackColor = System.Drawing.Color.MistyRose;

                    completionTimeLabel.Text = "";

                    // Make fonts bold
                    completionTimeLabel.Font = new Font(completionTimeLabel.Font, FontStyle.Bold);
                    remainingIterationsLabel.Font = new Font(remainingIterationsLabel.Font, FontStyle.Bold);
                    remainingTimeLabel.Font = new Font(remainingTimeLabel.Font, FontStyle.Bold);


                    while (remIters > 0)
                    {
                        Application.DoEvents();
                        //Checks to see if the user stopped the loop
                        if (loopButton.Text == "Loop")
                        {
                            DialogResult dr = MessageBox.Show("Stopped. Would you like to subtract the completed iterations from the remaining total?","",MessageBoxButtons.YesNo);

                            // Sets the iterations textbox to the remaining iterations so the user can pick right back up where they left off.
                            if(dr == DialogResult.Yes)
                            {
                                loopCountTextbox.Text = remIters.ToString();
                            }

                            break;
                        }
                        else
                        {
                            if(!_still_running)
                            {
                                break;
                            }
                        }

                        // Sets the completion time, the number of iterations remaining, and the countdown
                        TimeSpan addTime = new TimeSpan(0, 0, (int)remIters * loopLen);
                        completionTimeLabel.Text = DateTime.Now.Add(addTime).ToString("hh:mm");
                        remainingIterationsLabel.Text = remIters.ToString();

                        SendKeys.Send(ghostKey);

                        secsLeft = remIters * (long)loopLen;

                        // The actual countdown loop
                        for (int i = loopLen; i >= 0; i--)
                        {
                            Application.DoEvents();
                            remainingTimeLabel.Text = (secsLeft / 60).ToString("00") + ":" + (secsLeft - ((secsLeft / 60) * 60)).ToString("00");
                            Thread.Sleep(1000);
                            secsLeft -= 1;
                        }

                        remIters -= 1;
                        remainingIterationsLabel.Text = remIters.ToString();
                        
                    }

                    // Set fonts back to default
                    completionTimeLabel.Font = new Font(completionTimeLabel.Font, FontStyle.Regular);
                    remainingIterationsLabel.Font = new Font(remainingIterationsLabel.Font, FontStyle.Regular);
                    remainingTimeLabel.Font = new Font(remainingTimeLabel.Font, FontStyle.Regular);

                    completionTimeLabel.Text = "";
                    if (_still_running)
                    {
                        MessageBox.Show("Finished looping after " + (initIters - remIters).ToString() + " iterations.");
                        _still_running = false;
                    }
                }
            }

        }

        /********************************************************
         * Event Handler for the Close Button
         * Description: Closes the form
         * Arguments: None
         * Preconditions/Requirements: None
         * Returns: None
         *******************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            _still_running = false;
            Application.Exit();
        }

        /********************************************************
         * Event Handler for the Measure Time Button
         * Description: Customizes the time of the loop for unknown lengths.
         *              Runs the loop, changes the button's text, and then
         *              waits for the user to click "Stop". Sets the time accordingly.
         * Arguments: None
         * Preconditions/Requirements: User SHOULD have their ghosting program open, ready to run,
         *                              but technically not required
         * Returns: None
         *******************************************************/
        private void timeButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Coming Soon!!");
            /*
            bool timeRunning = false;
            StreamReader fileReader;

            MessageBox.Show("This will create a custom time, based on the length of your GhostMouse recording an playback speed. Once you click \"Ok\"," +
                " the recording will play. When it finishes, click \"Stop\" to complete the custom time. It will be rounded up to the nearest second.");
            DateTime start = DateTime.Now;
            
            SendKeys.Send(ghostMouseKeyTextbox.Text);
            */
        }

        /********************************************************
         * Event Handler for loading the form
         * Description: Reads in the text files for the iteration time and ghost key,
         *              then populates the form controls appropriately.
         * Arguments: None
         * Preconditions/Requirements: Saved files in the proper format
         * Returns: None
         *******************************************************/
        private void GhostmouseLooper_Load(object sender, EventArgs e)
        {

            loopCountTextbox.Focus();

            //Read the textfile for the last Ghostmouse Key
            try
            {
                StreamReader fileReader = new StreamReader("ghostkey.txt");
                ghostMouseKeyTextbox.Text = fileReader.ReadLine();
                fileReader.Close();
            }
            catch (Exception exc)
            {
                // Don't bother the user with an error. It's annoying.
            }

            //Read the textfile for the last iteration length
            try
            {
                StreamReader fileReader = new StreamReader("looplen.txt");
                loopLengthTextbox.Text = fileReader.ReadLine();
                fileReader.Close();
            }
            catch (Exception exc)
            {
                // Don't bother the user with an error. It's annoying.
            }
        }

        /********************************************************
         * Event Handler for the ghostmouse key textbox
         * Description: saves the ghostmouse key to a text file so the user doesn't have to enter it each time
         * Arguments: None
         * Preconditions/Requirements: 
         * Returns: None
         *******************************************************/
        private void ghostMouseKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            // Save the key in a textfile
            try
            {
                StreamWriter fileWriter = new StreamWriter("ghostkey.txt");
                fileWriter.WriteLine(ghostMouseKeyTextbox.Text);
                fileWriter.Close();
            }
            catch (Exception exc)
            {
                // Don't bother the user with an error. It's annoying.
            }
        }

        /********************************************************
         * Event Handler for the loop length textbox
         * Description: saves the iteration length to a text file, in case the user wants to reuse it.
         * Arguments: None
         * Preconditions/Requirements: None
         * Returns: None
         *******************************************************/
        private void loopLengthTextbox_TextChanged(object sender, EventArgs e)
        {
            // Save the loop length in a textfile
            try
            {
                StreamWriter fileWriter = new StreamWriter("looplen.txt");
                fileWriter.WriteLine(loopLengthTextbox.Text);
                fileWriter.Close();
            }
            catch (Exception exc)
            {
                // Don't bother the user with an error. It's annoying.
            }
        }
    }
}
