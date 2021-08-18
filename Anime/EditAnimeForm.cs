using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class EditAnimeForm : Form
    {
        public EditAnimeForm(int index) {
            InitializeComponent();
            this.index = index;
            Anime anime = AnimeManager.animes[index];
            AnimeName.Text = anime.name;
            AnimeURL.Text = anime.URL;
        }

        int index;

        private void button1_Click(object sender, EventArgs e)
        {
            AnimeManager.editAnime(index, AnimeName.Text, AnimeURL.Text);
            this.Close();
        }
    }
}
