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
using System.IO;



namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window {
        private int[,] _gameBoard = new int[3, 3];
        private int _yourTurn;//zero by default 
        int _playerOneScore = 0;
        int _playerTwoScore = 0;
        bool _resetScore = false;
        // 0 is blue
        // 1 is red
        public MainWindow() {
            InitializeComponent();            
            Reset();
        }
        private void Reset() {
            _yourTurn = 1;
            rectangle_blue.BorderThickness = new Thickness(5);
            for(int row = 0;row < 3;row++) {
                for(int col = 0;col < 3;col++) {
                    _gameBoard[row,col] = -1;
                }
            }
            button1.Background = Brushes.White;
            button2.Background = Brushes.White;
            button3.Background = Brushes.White;
            button4.Background = Brushes.White;
            button5.Background = Brushes.White;
            button6.Background = Brushes.White;
            button7.Background = Brushes.White;
            button8.Background = Brushes.White;
            button9.Background = Brushes.White;

            if(_resetScore) {
                player_1_score.Content = "0";
                player_2_score.Content = "0";
                _resetScore = false;
            }
        }
        private void Check() {     
            //check by rows
            if((_gameBoard[0,0]== _gameBoard[0,1] && _gameBoard[0,1] == _gameBoard[0,2])
                &&(_gameBoard[0,0] != -1 )) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins", "Game");
                Reset();
            }
            if((_gameBoard[1,0] == _gameBoard[1,1] && _gameBoard[1,1] == _gameBoard[1,2])
                && (_gameBoard[1,0] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            if((_gameBoard[2,0] == _gameBoard[2,1] && _gameBoard[2,1] == _gameBoard[2,2])
                && (_gameBoard[2,0] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            //check by culumns
            if((_gameBoard[0,0] == _gameBoard[1,0] && _gameBoard[1,0] == _gameBoard[2,0])
                && (_gameBoard[0,0] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            if((_gameBoard[0,1] == _gameBoard[1,1] && _gameBoard[1,1] == _gameBoard[2,1])
                && (_gameBoard[0,1] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            if((_gameBoard[0,2] == _gameBoard[1,2] && _gameBoard[1,2] == _gameBoard[2,2])
                && (_gameBoard[0,2] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            // check diagnol 
            if((_gameBoard[0,0] == _gameBoard[1,1] && _gameBoard[1,1] == _gameBoard[2,2])
                && (_gameBoard[0,0] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            if((_gameBoard[2,0] == _gameBoard[1,1] && _gameBoard[1,1] == _gameBoard[0,2])
                && (_gameBoard[2,0] != -1)) {
                if(_yourTurn == 1) { _playerOneScore += 1; player_1_score.Content = "" + _playerOneScore; }
                if(_yourTurn == 2) { _playerTwoScore += 1; player_2_score.Content = "" + _playerTwoScore; }
                MessageBox.Show("Player " + _yourTurn + " wins","Game");
                Reset();
            }
            //check if there are no winners
            bool winnerExist = false;
            for(int row = 0;row < 3;row++) {
                for(int col = 0;col < 3;col++) {
                    if(_gameBoard[row,col] == -1) {
                        winnerExist = true;
                    }
                }
            }
            if(!winnerExist) {
                MessageBox.Show("No winner","Game");                
                Reset();
            }
            
        }
        private void Update( ref int _yourTurn) {
            if(_yourTurn == 1) {
                Check();
                _yourTurn = 2;
                rectangle_red.BorderThickness = new Thickness(5);
                rectangle_blue.BorderThickness = new Thickness(0);
                //Console.WriteLine("Supposed to be 1");
            }
            else if(_yourTurn == 2) {
                Check();
                _yourTurn = 1;
                rectangle_blue.BorderThickness = new Thickness(5);
                rectangle_red.BorderThickness = new Thickness(0);
            }
        }

        private void Button_Click_1(object sender,RoutedEventArgs e) {
            if(_gameBoard[0,0] == -1) {
                _gameBoard[0,0] = _yourTurn;
                if(_yourTurn == 1) { button1.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button1.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_2(object sender,RoutedEventArgs e) {
            if(_gameBoard[0,1] == -1) {
                _gameBoard[0,1] = _yourTurn;
                if(_yourTurn == 1) { button2.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button2.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_3(object sender,RoutedEventArgs e) {
            if(_gameBoard[0,2] == -1) {
                _gameBoard[0,2] = _yourTurn;
                if(_yourTurn == 1) { button3.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button3.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_4(object sender,RoutedEventArgs e) {
            if(_gameBoard[1,0] == -1) {
                _gameBoard[1,0] = _yourTurn;
                if(_yourTurn == 1) { button4.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button4.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_5(object sender,RoutedEventArgs e) {
            if(_gameBoard[1,1] == -1) {
                _gameBoard[1,1] = _yourTurn;
                if(_yourTurn == 1) { button5.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button5.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_6(object sender,RoutedEventArgs e) {
            if(_gameBoard[1,2] == -1) {
                _gameBoard[1,2] = _yourTurn;
                if(_yourTurn == 1) { button6.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button6.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_7(object sender,RoutedEventArgs e) {
            if(_gameBoard[2,0] == -1) {
                _gameBoard[2,0] = _yourTurn;
                if(_yourTurn == 1) { button7.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button7.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_8(object sender,RoutedEventArgs e) {
            if(_gameBoard[2,1] == -1) {
                _gameBoard[2,1] = _yourTurn;
                if(_yourTurn == 1) { button8.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button8.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void Button_Click_9(object sender,RoutedEventArgs e) {
            if(_gameBoard[2,2] == -1) {
                _gameBoard[2,2] = _yourTurn;
                if(_yourTurn == 1) { button9.Background = Brushes.LightBlue; }
                else if(_yourTurn == 2) { button9.Background = Brushes.LightCoral; }
                Update(ref _yourTurn);
            }
        }

        private void restartGame(object sender,RoutedEventArgs e) {
            _resetScore = true;
            Reset();
        }

        private void Exit_menuItem(object sender,RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void save_menuItem(object sender,RoutedEventArgs e) {

            //String myDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //StreamWriter file = new StreamWriter(myDocumentPath+"/gameTicTacToeSaveData.txt");
            //String fileName = DateTime.Now.ToString("gameTicTacToeSaveData");
            //String filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //String fileFullName = filePath + fileName + ".txt";

            //file.Write(""+player_1_score+"\n" + ""+player_2_score+"\n");
            //Directory.CreateDirectory(filePath);
            //File.WriteAllText(fileFullName,"THAnk you");
            //file.Close();
            MessageBox.Show("Not implemented yet, check for updates","Info");

        }

        private void load_menuItem(object sender,RoutedEventArgs e) {
            MessageBox.Show("Not implemented yet, check for updates","Info");
        }
    }
}