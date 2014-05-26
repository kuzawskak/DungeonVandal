using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonVandal;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Storage;
using XMLManager.XMLObjects;


namespace Game.Panels
{
    /// <summary>
    /// Panel najlepszych wyników dla wybranego poziomu
    /// </summary>
    public partial class BestScoresPanel : UserControl
    {
        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public BestScoresPanel()
        {
            InitializeComponent();
            //brak najlepszych wyników dla danego poziomu
            for (int wiersz = 1; wiersz <= 5; wiersz++)
            {
                for (int kolumna = 0; kolumna <= 2; kolumna++)
                {
                    Label l = new Label();
                    l.Text = "";
                    l.Anchor = AnchorStyles.None;
                    l.Size = new Size(200, 50);
                    ScoresTableLayoutPanel.Controls.Add(l, kolumna, wiersz);
                }
            }
        }

        /// <summary>
        /// Aktualizacja danych wyświetlanych na panelu najlepszych wyników
        /// </summary>
        /// <param name="level_number"></param>
        public void UpdateForLevel(int level_number)
        {
            this.BestScoresLabel.Text = "Najlepsze wyniki dla poziomu " + level_number.ToString();
            IAsyncResult result = StorageDevice.BeginShowSelector(PlayerIndex.One, null, null);
            //załadowanie pliku z wynikami dla odpowiedniego poziomu
            HighScores.HighScoreData saved_data = HighScores.LoadHighScores(result, level_number);
           
            
                for (int wiersz = 1; wiersz <= 5; wiersz++)
                {
                    for (int kolumna = 0; kolumna <= 2; kolumna++)
                    {
                        Label l = (Label)ScoresTableLayoutPanel.GetControlFromPosition(kolumna, wiersz);
                        l.Text = "";
                       
                    }
                }

            
            if (saved_data.Count != 0)
            {

                for (int wiersz = 1; wiersz <= saved_data.Count; wiersz++)
                {
                    for (int kolumna = 0; kolumna < 3; kolumna++)
                    {
                             Label label = (Label)ScoresTableLayoutPanel.GetControlFromPosition(kolumna, wiersz);
                  

                        if (kolumna == 0)
                        {

                            label.Text = saved_data.PlayerName[wiersz - 1];

                        }
                        else if (kolumna == 1)
                        {
                            label.Text = saved_data.Time[wiersz - 1];
                        }
                        else if (kolumna == 2)
                        {
                            label.Text = saved_data.Score[wiersz - 1].ToString();
                        }                   
                        
                    }
                }
            }
        }


        /// <summary>
        /// Obsługa przycisku wyjścia z panelu z najlepszymi wynikami
        /// </summary>
        /// <param name="sender">przycisk wywołujący zdarzenie kliknięcia</param>
        /// <param name="e">parametry zdarzenia kliknięcia</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           
            ((MenuForm)Parent).choose_level_panel.Visible = true;

        }
    }
}
