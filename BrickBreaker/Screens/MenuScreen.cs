using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        List<string> messageList = new List<string>();

        public static List<HighScore> highScores = new List<HighScore>();
        

        public MenuScreen()
        {
            InitializeComponent();

            playButton.Font = Form1.myFont;
            hardButton.Font = Form1.myFont;
            exitButton.Font = Form1.myFont;
            subtitleLabel.Font = Form1.myFont;
        }
        public void Cam()
        {
            string name, score;
            XmlReader reader = XmlReader.Create("HighScoreXML.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    name = reader.ReadString();

                    reader.ReadToNextSibling("Score");

                    score = reader.ReadString();

                    int newScore = Convert.ToInt32(score);

                   HighScore h= new HighScore(name, newScore);

                   highScores.Add(h);
                }
            }


        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        public void messageSet()
        {
            messageList.Add("Now in Colour!");
            messageList.Add("watch out for AI");
            messageList.Add(" Java > Bedrock");
            messageList.Add("If your reading this its too late");
            messageList.Add("Bradyens an opp");
            messageList.Add("Creeper gonna creep");

            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            subtitleLabel.Text = $"{messageList[random]}\n";
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            messageSet();

        }

        private void highscore_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            HighScoreScreen hs = new HighScoreScreen ();
            f.Controls.Add((hs));
          
        }
    }
}
