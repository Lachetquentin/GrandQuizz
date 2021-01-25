using GrandQuizz.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrandQuizz
{
    public partial class FrmMain : Form
    {
        // Variables globales de Grand Quizz

        private string answer;
        private int i;

        private int qNum;

        private List<int> questionNumbers = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
            30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56,
            57, 58, 59, 60
        };

        private int score;

        private int time = 60;
        private readonly Timer timer = new Timer { Interval = 1000 };


        public FrmMain()
        {
            InitializeComponent();

            StartGame();
            NextQuestion();
            gameTimer();
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            if (qNum < 0) qNum = 0;

            var strLower = tBReponse.Text.ToLower();
            var strTrim = strLower.Trim();

            if (answer == strTrim)
            {
                qNum++;
                score++;
                tBReponse.Text = "";
                NextQuestion();
            }

            lbpoints.Text = "Score : " + score + " points";
        }


        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                timer.Stop();
                EndGame();
            }

            switch (i)
            {
                case 1:
                    pictureBox1.Image = Resources.doctorwho;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "doctor who";
                    break;

                case 2:
                    pictureBox1.Image = Resources.arrow;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "arrow";
                    break;

                case 3:
                    pictureBox1.Image = Resources.powerrangers;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "power rangers";
                    break;

                case 4:
                    pictureBox1.Image = Resources._911;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "9-1-1";
                    break;

                case 5:
                    pictureBox1.Image = Resources.Alertecobra;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "alerte cobra";
                    break;

                case 6:
                    pictureBox1.Image = Resources.FastandFurious;

                    lbDevine.Text = "De quelle film ça vient ?";
                     
                    answer = "fast and furious";
                    break;

                case 7:
                    pictureBox1.Image = Resources.LegendsOfTomorrow;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "legends of tomorrow";
                    break;

                case 8:
                    pictureBox1.Image = Resources.alias;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "alias";
                    break;

                case 9:
                    pictureBox1.Image = Resources.supergirl;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "supergirl";
                    break;

                case 10:
                    pictureBox1.Image = Resources.theflash;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the flash";
                    break;

                case 11:
                    pictureBox1.Image = Resources.Blindspot;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "blindspot";
                    break;

                case 12:
                    pictureBox1.Image = Resources.Bull;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "bull";
                    break;

                case 13:
                    pictureBox1.Image = Resources.Castle;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "castle";
                    break;

                case 14:
                    pictureBox1.Image = Resources.CriminalMinds;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "esprit criminels";
                    break;

                case 15:
                    pictureBox1.Image = Resources.NCIS;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "ncis";
                    break;

                case 16:
                    pictureBox1.Image = Resources.scorpion;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "scorpion";
                    break;

                case 17:
                    pictureBox1.Image = Resources.Supernatural;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "supernatural";
                    break;

                case 18:
                    pictureBox1.Image = Resources.SwampThing;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "swamp thing";
                    break;

                case 19:
                    pictureBox1.Image = Resources.TheBoys;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the boys";
                    break;

                case 20:
                    pictureBox1.Image = Resources.Lucifer;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "lucifer";
                    break;

                case 21:
                    pictureBox1.Image = Resources.batwoman;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "batwoman";
                    break;

                case 22:
                    pictureBox1.Image = Resources.blacklightning;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "black lightning";
                    break;

                case 23:
                    pictureBox1.Image = Resources.blacklist;

                    lbDevine.Text = "De quelle série ça vient ?";

                    answer = "blacklist";
                    break;

                case 24:
                    pictureBox1.Image = Resources.charmed;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "charmed";
                    break;

                case 25:
                    pictureBox1.Image = Resources.chicagomed;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "chicago med";
                    break;

                case 26:
                    pictureBox1.Image = Resources.chicagopd;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "chicago p.d";
                    break;

                case 27:
                    pictureBox1.Image = Resources.Insaisissables;

                    lbDevine.Text = "De quelle film ça vient ?";
                     
                    answer = "insaisissable";
                    break;

                case 28:
                    pictureBox1.Image = Resources.colony;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "colony";
                    break;

                case 29:
                    pictureBox1.Image = Resources.covertaffairs;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "covert affairs";
                    break;

                case 30:
                    pictureBox1.Image = Resources.cursed;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "cursed";
                    break;

                case 31:
                    pictureBox1.Image = Resources.starwars;

                    lbDevine.Text = "De quelle film ça vient ?";
                     
                    answer = "star wars";
                    break;

                case 32:
                    pictureBox1.Image = Resources.diagnosticmeurtre;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "diagnostic meurtre";
                    break;

                case 33:
                    pictureBox1.Image = Resources.doompatrol;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "doom patrol";
                    break;

                case 34:
                    pictureBox1.Image = Resources.dynastie;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "dynastie";
                    break;

                case 35:
                    pictureBox1.Image = Resources.emergence;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "emergence";
                    break;

                case 36:
                    pictureBox1.Image = Resources.fbi;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "fbi";
                    break;

                case 37:
                    pictureBox1.Image = Resources.gooddoctor;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "good doctor";
                    break;

                case 38:
                    pictureBox1.Image = Resources.highlander;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "highlander";
                    break;

                case 39:
                    pictureBox1.Image = Resources.hudsonetrex;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "hudson et rex";
                    break;

                case 40:
                    pictureBox1.Image = Resources.instinct;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "instinct";
                    break;

                case 41:
                    pictureBox1.Image = Resources.legacies;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "legacies";
                    break;

                case 42:
                    pictureBox1.Image = Resources.macgyver;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "macgyver";
                    break;

                case 43:
                    pictureBox1.Image = Resources.magnum;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "magnum";
                    break;

                case 44:
                    pictureBox1.Image = Resources.manifest;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "manifest";
                    break;

                case 45:
                    pictureBox1.Image = Resources.lacasadepapel;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "la casa de papel";
                    break;

                case 46:
                    pictureBox1.Image = Resources.prodigalson;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "prodigal son";
                    break;

                case 47:
                    pictureBox1.Image = Resources.swat;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "swat";
                    break;

                case 48:
                    pictureBox1.Image = Resources.sealteam;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "seal team";
                    break;

                case 49:
                    pictureBox1.Image = Resources.thewitcher;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the witcher";
                    break;

                case 50:
                    pictureBox1.Image = Resources.x_files;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the x-files";
                    break;

                case 51:
                    pictureBox1.Image = Resources.TheOrder;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the order";
                    break;

                case 52:
                    pictureBox1.Image = Resources.Daredevil;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "daredevil";
                    break;

                case 53:
                    pictureBox1.Image = Resources.punisher;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the punisher";
                    break;

                case 54:
                    pictureBox1.Image = Resources.LukeCage;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "luke cage";
                    break;

                case 55:
                    pictureBox1.Image = Resources.JessicaJones;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "jessica jones";
                    break;

                case 56:
                    pictureBox1.Image = Resources.IronFist;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "iron fist";
                    break;

                case 57:
                    pictureBox1.Image = Resources.Defenders;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "the defenders";
                    break;

                case 58:
                    pictureBox1.Image = Resources.suits;

                     
                     
                    answer = "suits";
                    break;

                case 59:
                    pictureBox1.Image = Resources.Bones;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "bones";
                    break;

                case 60:
                    pictureBox1.Image = Resources.csimiami;

                    lbDevine.Text = "De quelle série ça vient ?";
                     
                    answer = "les experts miami";
                    break;
            }
        }


        private void gameTimer()
        {


            timer.Start();
            timer.Tick += delegate
            {
                time--;

                if (time < 0)
                {
                    timer.Stop();
                    EndGame();
                }

                var ssTime = TimeSpan.FromSeconds(time);

                if (time < 10)
                {
                    lbTime.Text = "00:0" + time;
                }
                else
                {
                    lbTime.Text = "00:" + time;
                }

            };
        }

        private void btChanger_Click(object sender, EventArgs e)
        {
            qNum++;
            tBReponse.Text = "";
            NextQuestion();
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            // Affiche l'ordre du random en haut

            //questionOrder.Text = "";

            //for (int i = 0; i < questionNumbers.Count; i++)
            //{
            //  questionOrder.Text += " " + questionNumbers[i].ToString();
            //}
        }

        private void RestartGame()
        {
            time = 60;
            score = 0;
            qNum = 0;
            i = 0;

            lbpoints.Text = "Score : " + score + " points";
             

            StartGame();
            NextQuestion();
            timer.Start();
        }

        private void EndGame()
        {
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Rejouer";
            MessageBoxManager.No = "Quitter";
            MessageBoxManager.Register();

            var selectedOption = MessageBox.Show(
                "Partie terminé !" + Environment.NewLine +
                "Vous avez " + score + " points !" + Environment.NewLine +
                "Voulez-vous rejouer ou quitter ?", "Grand Quizz", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (selectedOption == DialogResult.Yes) RestartGame();

            if (selectedOption == DialogResult.No) Application.Exit();
        }




        private void BtCredits_Click(object sender, EventArgs e) => MessageBox.Show("© 2020 \n Codé par Quentin LACHET.", "Crédits Grand Quizz");

        /* private void FrmMain_Load(object sender, EventArgs e)
        {
            
            MessageBoxManager.Yes = "1 minutes";
            MessageBoxManager.No = "5 minutes";
            MessageBoxManager.Cancel = "10 minutes";
            MessageBoxManager.Register();
            


            var selectedOption = MessageBox.Show(
               "Bienvenue sur Slam Sauce !" + Environment.NewLine +
               "Vous voulez jouer une partie de quelle durée ?", "Slam Sauce", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (selectedOption == DialogResult.Yes)
            {
                time = 60;
            }

            if (selectedOption == DialogResult.No)
            {
                time = 300;
            }

            if (selectedOption == DialogResult.Cancel)
            {
                time = 600;
            }

        } */
    }
}