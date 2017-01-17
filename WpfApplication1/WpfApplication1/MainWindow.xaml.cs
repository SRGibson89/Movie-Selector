using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int Film = 0;
         string selection = "";
        private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }

        

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
             switch (selection)
            {
                case "1":
                    lblFilm.Content = ("You have chosen Grease Live! 2016")  ;
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Grease.jpg"));
                    break;
                case "2":
                     lblFilm.Content = ("You have chosen Rocky Horror Picture Show")  ;
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Rocky.jpg"));
                    break;
                case "3":
                    lblFilm.Content = ("You have chosenSeven Pounds");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Seven.jpg"));
                    break;
                case "4":
                    lblFilm.Content = ("You have chosen Mean Girls");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Mean.jpg"));
                    break;
                case "5":
                    lblFilm.Content = ("You have chosen Rock Of Ages");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Rock.jpg"));
                    break;
                case "6":
                    lblFilm.Content = ("You have chosen The Proposal ");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Proposal.jpg"));
                    break;
                case "7":
                    lblFilm.Content = ("You have chosen 21");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\21.jpg"));
                    break;
                case "8":
                    lblFilm.Content = ("You have chosen Chicago");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Chicago.jpg"));
                    break;
                case "9":
                    lblFilm.Content = ("You have chosen Dallas Buyers Club");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Dallas.jpg"));
                    break;
                case "10":
                    lblFilm.Content = ("You have chosen Girl Next Door");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\Posters\Girlnextdoor.jpg"));
                    break;
                default:
                    lblFilm.Content = ("You NOT have chosen a film");
                    imgShow.Source = new BitmapImage(new Uri(@"E:\Documents\Movie Program\Movie 1\default.jpg"));
                    break;
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
                
        }

        

        private void txtFilm_TextChanged(object sender, TextChangedEventArgs e)
        {
            selection = txtFilm.Text;

        }
        

       

    }
}
