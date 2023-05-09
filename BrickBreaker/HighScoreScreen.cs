using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class HighScoreScreen : UserControl

    {
        public static List<HighScore> highScores = new List<HighScore>();
        public HighScoreScreen()
        {
            InitializeComponent();
            highscore();
        }
        public void highscore()
        {
            highScores.Clear();

            string name, score;
            XmlReader reader = XmlReader.Create("HighScoreXML.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    //reader.ReadToNextSibling("Name");

                    name = reader.ReadString();

                    reader.ReadToNextSibling("Score");

                    score = reader.ReadString();

                    int newScore = Convert.ToInt32(score);

                    HighScore h = new HighScore(name, newScore);

                    highScores.Add(h);
                }
            }
            reader.Close();

            highScoreLabel.Text = "";

            foreach (HighScore h in highScores)
            {
                highScoreLabel.Text += $" score:{h.score}\n";
            }
        }

      

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);

        }
    }
    
}
