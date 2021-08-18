using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
            AnimeManager.initialize();
        }

        private void Form1_Load(object sender, EventArgs e) {
            AnimeList.MouseDoubleClick += new MouseEventHandler(AnimeList_MouseDoubleClick);

            flushAnime();

            string[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length == 2) {
                openAnime();
            }
        }

        public void openAnime() {
            foreach (Anime currentAnime in AnimeManager.animes) {
                System.Diagnostics.Process.Start(currentAnime.URL);
            }
            Application.Exit();
        }

        public void flushAnime() {
            AnimeList.Items.Clear();
            foreach (Anime currentAnime in AnimeManager.animes) {
                AnimeList.Items.Add(currentAnime.name);
            }
        }

        public void removeSelectedAnime() {
            if (AnimeList.SelectedIndex == -1) return;
            AnimeManager.removeAnime(AnimeList.SelectedIndex);
            flushAnime();
        }
                
        public void addAnime() {
            string name = AnimeName.Text;
            string URL = AnimeURL.Text;
            AnimeName.Text = "";
            AnimeURL.Text = "";

            AnimeManager.addAnime(name, URL);
            flushAnime();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            addAnime();
        }

        private void AnimeURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) addAnime();
        }

        private void AnimeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) addAnime();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            removeSelectedAnime();
        }

        private void AnimeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) removeSelectedAnime();
        }
        private void AnimeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.AnimeList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches) {
                showEditAnimeForm(index);
            }
        }

        public void showEditAnimeForm(int index) {
            Anime anime = AnimeManager.animes[index];
            EditAnimeForm form = new EditAnimeForm(index);
            form.Text = "Edit - " + anime.name;
            form.ShowDialog();
            flushAnime();
        }

    }
}
