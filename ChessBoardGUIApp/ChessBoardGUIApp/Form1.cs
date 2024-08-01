using ChessBoardConsoleApp;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        public bool pieceSelected = false;
        public static Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            PopulateGrid();
        }

        /// <summary>
        /// this function will fill the panel1 control with buttons
        /// </summary>
        public void PopulateGrid()
        {

            int buttonSize = panel1.Width / myBoard.Size; //makes sure the buttons all fit inside the panel perfectly
            panel1.Height = panel1.Width; //makes sure the panel is perfectly square

            // goes through every row and column creates a button for every spot
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();

                    //makes each button a square and the size of the buttonSize property
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].Click += Grid_Button_Click; //adds the same click event to each button
                    panel1.Controls.Add(btnGrid[r, c]); // places the buttons on the panel
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); // position it in x, y

                    //just for testing
                    // btnGrid[r, c].Text = r.ToString() + "|" + c.ToString();
                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            if (pieceSelected == false)
            {
                MessageBox.Show("Please select a piece before selecting an area on the board");
                return;
            }
            // get the row and column number of the button just clicked
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            // run a helper function to label all legal moves for this piece
            Cell currentCell = myBoard.TheGrid[r, c];


            string selectedPiece = PieceSelect();

            myBoard.MarkNextLegalMoves(currentCell, selectedPiece);
            UpdateButtonLabels();

            // resets the background color of all the buttons to the original color
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
            }

            // sets the background color of the clicked button to something different
            (sender as Button).BackColor = Color.BurlyWood;
        }

        private void UpdateButtonLabels()
        {
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    string selectedPiece = PieceSelect();
                    btnGrid[r, c].Text = "";
                    if (myBoard.TheGrid[r, c].CurrentlyOccupied) btnGrid[r, c].Text = $"{selectedPiece}";
                    if (myBoard.TheGrid[r, c].LegalNextMove) btnGrid[r, c].Text = "Legal";
                }
            }
        }

        private string PieceSelect()
        {
            string selectedPiece = comboBox1.SelectedItem.ToString();
            return selectedPiece;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pieceSelected = true;
        }
    }
}
