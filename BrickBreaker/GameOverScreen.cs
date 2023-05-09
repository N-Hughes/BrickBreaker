using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {// Make background the last game screen background with a red filter?
            InitializeComponent();

            
          
            subtitleLabel.Font = Form1.myFont;
            scoreLabel.Font = Form1.myFont;
            scoreValue.Font = Form1.myFont;
            //Form1.size = 72;
        
            //  Form1.FontChange(size);

            titleLabel.Font = Form1.myFont;

            // Lets use "total score" to add to the xml highscores, we will need a high score screen
            scoreValue.Text = ($"{Form1.totalScore}");
        }
    }
}
