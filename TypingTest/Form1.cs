using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTest
{
    public partial class Form1 : Form
    {
        List<string> sampleSentences = new List<string>(11);
        private Random randomSample = new Random(DateTimeOffset.UtcNow.Millisecond);
        private double wordsPerMinute;

        public int wordTally = 0, targetCharCount, inputCharCount, timerTicks = 0;
        public event EventHandler textEntered;
        public Boolean testStarted = false, testFinished = false;

        public Form1()
        {
            InitializeComponent();
            this.AutoSize.Equals(true);

            //populate sampleSentences with sentences and paragraphs
            PopulateSampleSentences();

            //Randomly select one of the sentences/paragraphs and pass into the textbox (rather than a label because word-wrap is just beautiful)
            int randSelection = randomSample.Next(sampleSentences.Count);
            typingSample.Text = sampleSentences[randSelection];

            //set target number of characters to the length of the string chosen above
            targetCharCount = typingSample.Text.Length;

            //set each tick to be equivalent to one second
            timer1.Interval = 1000;

            //run countTextLength whenever the text in userInput is changed
            this.userInput.TextChanged += new System.EventHandler(this.CountTextLength);

            //Call clock on each tick
            timer1.Tick += new System.EventHandler(this.Clock);
            
        }

        //The int that tracks the number of ticks increments
        //wordCountText is updated accordingly.
        protected void Clock(object sender, EventArgs e)
        {
            timerTicks++;
            wordCountText.Text = "Word Count:" + wordTally + "\nTime: " + timerTicks;
        }

        protected void CountTextLength (object sender, EventArgs e)
        {
            //Don't do any of this if the test is finished
            if(testFinished)
            {
                return;
            }

            //only do this once--if the user hasn't started the test yet
            if (!testStarted)
            {
                //track that the test has started
                testStarted = true;
                //start up the timer
                timer1.Start();
            }

            //update character count
            inputCharCount = userInput.Text.Length;
            //check character count against number of characters in sample text
            CheckWordCount();

            //stop the test when the user inputs the same number of characters
            //as the sample text
            if (inputCharCount >= targetCharCount)
            {
                EndTest();      
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        //Finish test, clean things up, and tie up some loose ends
        public void EndTest()
        {
            timer1.Stop();
            testStarted = false;
            testFinished = true;

            //calculate words per minute (divide by 60 because ticks = seconds)
            //cast as a double to prevent weirdness like 0 WPM
            wordsPerMinute = (double)typingSample.Text.Length / 60;
            //update label on right pane to display WPM
            wordCountText.Text += "\nWords per minute: " + wordsPerMinute;

            //Check for and hightlight errors
            ErrorCheck();

            //user should no longer be able to edit text after test is finished
            userInput.ReadOnly = true;

        }

        //This will highlight all characters that don't match the sample.
        /*
            This means that, if, for example, the user types an extra space somewhere, it is very likely that the rest of the text will be counted as wrong, which, technically, it is.
        */
        public void ErrorCheck()
        {
            //create an iterator and set to 0
            int charIterator = 0;

            //keep track of how many errors have been found
            double numErrors = 0;

            //a foreach loop to go through each character in the user's text
            foreach(char c in userInput.Text)
            {
                //check that character against the character at the same index in the sample
                if (c != typingSample.Text[charIterator])
                {
                    //Choose a color for selected character - Ideally, one that should be visible to users who may be color blind. Blue, in this case.
                    userInput.SelectionColor = Color.Blue;

                    //highlight selected character, to a length of one (basically, only highlight that one character
                    userInput.Select(charIterator, 1);

                    //We've found an error, so we add it to the number of errors we have found
                    numErrors++;

                }

                //increment charIterator so that the loop checks the next character
                charIterator++;

            }

            //Calculate the Error Percentage:
            //get percentage that each character is worth
            double errorValue = 100 / targetCharCount;
            //multiply that value by the number of errors
            double errorPercentage = numErrors * errorValue;

            wordCountText.Text += "\nError Percentage: " + errorPercentage + "%";

        }
        

        //So, I need to get the count of words in a string...
        public void CheckWordCount()
        {
            //this looks like a job for Regular Expressions!
            string lookForThis = @"[^\s]+";
            string[] inputContents = null;
            inputContents = Regex.Split(userInput.Text, lookForThis, RegexOptions.IgnoreCase);

            //adjust word count as needed and display word count and time
            wordTally = inputContents.Length - 1;
            wordCountText.Text = "Word Count:" + wordTally + "\nTime: " + timerTicks;
        }

        //method to add sample sentences to the array
        //Really just using this to keep the rest of the program un-cluttered
        public void PopulateSampleSentences()
        {
            //sampleSentences.Add("The quick brown fox jumps over the lazy dog");
            ////Samuel L. Jackson in Pulp Fiction
            //sampleSentences.Add("Well, the way they make shows is, they make one show. That show's called a pilot. Then they show that show to the people who make shows, and on the strength of that one show they decide if they're going to make more shows. Some pilots get picked and become television programs. Some don't, become nothing. She starred in one of the ones that became nothing.");
            ////Excerpt from Alice in Wonderland by Lewis Carroll
            //sampleSentences.Add("'Yes, that's it,' said the Hatter with a sigh: 'it's always tea-time, and we've no time to wash the things between whiles.'");
            ////Excerpt from A Princess of Mars by Edgar Rice Burroughs
            //sampleSentences.Add("This latter alternative is always permissible, therefore I could have used my short-sword, my dagger, my hatchet, or my fists had I wished, and been entirely within my rights, but I could not use firearms or a spear while he held only his long-sword.");
            ////Exceprt from Around the World in 80 Days by Jules Verne
            //sampleSentences.Add("Phileas Fogg had not concealed from Sir Francis his design of going round the world, nor the circumstances under which he set out; and the general only saw in the wager a useless eccentricity and a lack of sound common sense.");
            ////The following pangrams were found on clagnut.com
            //sampleSentences.Add("Jack quietly moved up and seized the big ball of wax");
            //sampleSentences.Add("Crazy Frederick bought many very exquisite opal jewels");
            //sampleSentences.Add("A quivering Texas zombie fought republic linked jewelry");
            //sampleSentences.Add("Grumpy wizards make toxic brew for the evil queen and jack");
            sampleSentences.Add("Just keep examining every low bid quoted for zinc etchings");
            sampleSentences.Add("Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?");
        }

    }
}
