using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace EasyMath
{
    public partial class Sudoku : ContentPage
    {
        int[,] tab = new int[10, 10];
        int[,] line = new int[10, 10];
        int[,] col = new int[10, 10];
        int[,] square = new int[10, 10];

        public Sudoku()
        {
            InitializeComponent();

        }

        public bool safe(int i, int l, int c, int s) {
            if ((line[l, i] == 0) && (col[c, i] == 0) && (square[s, i] == 0)) return true;
            else return false;
        }

        public int findsquare(int l, int c) {
            if (l <= 3)
            {
                if (c <= 3) return 1;
                else if (c <= 6) return 2;
                else return 3;
            }
            else if (l <= 6)
            {
                if (c <= 3) return 4;
                else if (c <= 6) return 5;
                else return 6;
            }
            else
            {
                if (c <= 3) return 7;
                else if (c <= 6) return 8;
                else return 9;
            }
        }

        public bool solve(int n, int l, int c) {
            if (n == 81) return true;
            if (l == 10 && c == 1 && n != 81)
            {
                return false;
            }
            if (tab[l, c] == 0)
            {
                int s = findsquare(l, c);
                for (int i = 1; i <= 9; i++)
                {
                    if (safe(i, l, c, s))
                    {
                        tab[l, c] = i;
                        line[l, i] = 1;
                        col[c, i] = 1;
                        square[s, i] = 1;
                        int temp = n + 1;
                        if (c < 9)
                        {
                            if (solve(temp, l, c + 1)) return true;
                        }
                        else
                        {
                            if (solve(temp, l + 1, 1)) return true;
                        }
                        tab[l, c] = 0;
                        line[l, i] = 0;
                        col[c, i] = 0;
                        square[s, i] = 0;
                    }
                }
                return false;
            }
            if (c < 9)
            {
                if (solve(n, l, c + 1)) return true;
            }

            else if (solve(n, l + 1, 1)) return true;

            return false;
        }


        public void SolveSudoku(Object sender, EventArgs e) {

            if (c11.Text == "") c11.Text = "0";
            if (c12.Text == "") c12.Text = "0";
            if (c13.Text == "") c13.Text = "0";
            if (c14.Text == "") c14.Text = "0";
            if (c15.Text == "") c15.Text = "0";
            if (c16.Text == "") c16.Text = "0";
            if (c17.Text == "") c17.Text = "0";
            if (c18.Text == "") c18.Text = "0";
            if (c19.Text == "") c19.Text = "0";

            if (c21.Text == "") c21.Text = "0";
            if (c22.Text == "") c22.Text = "0";
            if (c23.Text == "") c23.Text = "0";
            if (c24.Text == "") c24.Text = "0";
            if (c25.Text == "") c25.Text = "0";
            if (c26.Text == "") c26.Text = "0";
            if (c27.Text == "") c27.Text = "0";
            if (c28.Text == "") c28.Text = "0";
            if (c29.Text == "") c29.Text = "0";

            if (c31.Text == "") c31.Text = "0";
            if (c32.Text == "") c32.Text = "0";
            if (c33.Text == "") c33.Text = "0";
            if (c34.Text == "") c34.Text = "0";
            if (c35.Text == "") c35.Text = "0";
            if (c36.Text == "") c36.Text = "0";
            if (c37.Text == "") c37.Text = "0";
            if (c38.Text == "") c38.Text = "0";
            if (c39.Text == "") c39.Text = "0";

            if (c41.Text == "") c41.Text = "0";
            if (c42.Text == "") c42.Text = "0";
            if (c43.Text == "") c43.Text = "0";
            if (c44.Text == "") c44.Text = "0";
            if (c45.Text == "") c45.Text = "0";
            if (c46.Text == "") c46.Text = "0";
            if (c47.Text == "") c47.Text = "0";
            if (c48.Text == "") c48.Text = "0";
            if (c49.Text == "") c49.Text = "0";

            if (c51.Text == "") c51.Text = "0";
            if (c52.Text == "") c52.Text = "0";
            if (c53.Text == "") c53.Text = "0";
            if (c54.Text == "") c54.Text = "0";
            if (c55.Text == "") c55.Text = "0";
            if (c56.Text == "") c56.Text = "0";
            if (c57.Text == "") c57.Text = "0";
            if (c58.Text == "") c58.Text = "0";
            if (c59.Text == "") c59.Text = "0";

            if (c61.Text == "") c61.Text = "0";
            if (c62.Text == "") c62.Text = "0";
            if (c63.Text == "") c63.Text = "0";
            if (c64.Text == "") c64.Text = "0";
            if (c65.Text == "") c65.Text = "0";
            if (c66.Text == "") c66.Text = "0";
            if (c67.Text == "") c67.Text = "0";
            if (c68.Text == "") c68.Text = "0";
            if (c69.Text == "") c69.Text = "0";

            if (c71.Text == "") c71.Text = "0";
            if (c72.Text == "") c72.Text = "0";
            if (c73.Text == "") c73.Text = "0";
            if (c74.Text == "") c74.Text = "0";
            if (c75.Text == "") c75.Text = "0";
            if (c76.Text == "") c76.Text = "0";
            if (c77.Text == "") c77.Text = "0";
            if (c78.Text == "") c78.Text = "0";
            if (c79.Text == "") c79.Text = "0";

            if (c81.Text == "") c81.Text = "0";
            if (c82.Text == "") c82.Text = "0";
            if (c83.Text == "") c83.Text = "0";
            if (c84.Text == "") c84.Text = "0";
            if (c85.Text == "") c85.Text = "0";
            if (c86.Text == "") c86.Text = "0";
            if (c87.Text == "") c87.Text = "0";
            if (c88.Text == "") c88.Text = "0";
            if (c89.Text == "") c89.Text = "0";

            if (c91.Text == "") c91.Text = "0";
            if (c92.Text == "") c92.Text = "0";
            if (c93.Text == "") c93.Text = "0";
            if (c94.Text == "") c94.Text = "0";
            if (c95.Text == "") c95.Text = "0";
            if (c96.Text == "") c96.Text = "0";
            if (c97.Text == "") c97.Text = "0";
            if (c98.Text == "") c98.Text = "0";
            if (c99.Text == "") c99.Text = "0";

            tab[1, 1] = Convert.ToInt32(c11.Text);
            tab[1, 2] = Convert.ToInt32(c12.Text);
            tab[1, 3] = Convert.ToInt32(c13.Text);
            tab[1, 4] = Convert.ToInt32(c14.Text);
            tab[1, 5] = Convert.ToInt32(c15.Text);
            tab[1, 6] = Convert.ToInt32(c16.Text);
            tab[1, 7] = Convert.ToInt32(c17.Text);
            tab[1, 8] = Convert.ToInt32(c18.Text);
            tab[1, 9] = Convert.ToInt32(c19.Text);

            tab[2, 1] = Convert.ToInt32(c21.Text);
            tab[2, 2] = Convert.ToInt32(c22.Text);
            tab[2, 3] = Convert.ToInt32(c23.Text);
            tab[2, 4] = Convert.ToInt32(c24.Text);
            tab[2, 5] = Convert.ToInt32(c25.Text);
            tab[2, 6] = Convert.ToInt32(c26.Text);
            tab[2, 7] = Convert.ToInt32(c27.Text);
            tab[2, 8] = Convert.ToInt32(c28.Text);
            tab[2, 9] = Convert.ToInt32(c29.Text);

            tab[3, 1] = Convert.ToInt32(c31.Text);
            tab[3, 2] = Convert.ToInt32(c32.Text);
            tab[3, 3] = Convert.ToInt32(c33.Text);
            tab[3, 4] = Convert.ToInt32(c34.Text);
            tab[3, 5] = Convert.ToInt32(c35.Text);
            tab[3, 6] = Convert.ToInt32(c36.Text);
            tab[3, 7] = Convert.ToInt32(c37.Text);
            tab[3, 8] = Convert.ToInt32(c38.Text);
            tab[3, 9] = Convert.ToInt32(c39.Text);

            tab[4, 1] = Convert.ToInt32(c41.Text);
            tab[4, 2] = Convert.ToInt32(c42.Text);
            tab[4, 3] = Convert.ToInt32(c43.Text);
            tab[4, 4] = Convert.ToInt32(c44.Text);
            tab[4, 5] = Convert.ToInt32(c45.Text);
            tab[4, 6] = Convert.ToInt32(c46.Text);
            tab[4, 7] = Convert.ToInt32(c47.Text);
            tab[4, 8] = Convert.ToInt32(c48.Text);
            tab[4, 9] = Convert.ToInt32(c49.Text);

            tab[5, 1] = Convert.ToInt32(c51.Text);
            tab[5, 2] = Convert.ToInt32(c52.Text);
            tab[5, 3] = Convert.ToInt32(c53.Text);
            tab[5, 4] = Convert.ToInt32(c54.Text);
            tab[5, 5] = Convert.ToInt32(c55.Text);
            tab[5, 6] = Convert.ToInt32(c56.Text);
            tab[5, 7] = Convert.ToInt32(c57.Text);
            tab[5, 8] = Convert.ToInt32(c58.Text);
            tab[5, 9] = Convert.ToInt32(c59.Text);

            tab[6, 1] = Convert.ToInt32(c61.Text);
            tab[6, 2] = Convert.ToInt32(c62.Text);
            tab[6, 3] = Convert.ToInt32(c63.Text);
            tab[6, 4] = Convert.ToInt32(c64.Text);
            tab[6, 5] = Convert.ToInt32(c65.Text);
            tab[6, 6] = Convert.ToInt32(c66.Text);
            tab[6, 7] = Convert.ToInt32(c67.Text);
            tab[6, 8] = Convert.ToInt32(c68.Text);
            tab[6, 9] = Convert.ToInt32(c69.Text);

            tab[7, 1] = Convert.ToInt32(c71.Text);
            tab[7, 2] = Convert.ToInt32(c72.Text);
            tab[7, 3] = Convert.ToInt32(c73.Text);
            tab[7, 4] = Convert.ToInt32(c74.Text);
            tab[7, 5] = Convert.ToInt32(c75.Text);
            tab[7, 6] = Convert.ToInt32(c76.Text);
            tab[7, 7] = Convert.ToInt32(c77.Text);
            tab[7, 8] = Convert.ToInt32(c78.Text);
            tab[7, 9] = Convert.ToInt32(c79.Text);

            tab[8, 1] = Convert.ToInt32(c81.Text);
            tab[8, 2] = Convert.ToInt32(c82.Text);
            tab[8, 3] = Convert.ToInt32(c83.Text);
            tab[8, 4] = Convert.ToInt32(c84.Text);
            tab[8, 5] = Convert.ToInt32(c85.Text);
            tab[8, 6] = Convert.ToInt32(c86.Text);
            tab[8, 7] = Convert.ToInt32(c87.Text);
            tab[8, 8] = Convert.ToInt32(c88.Text);
            tab[8, 9] = Convert.ToInt32(c89.Text);

            tab[9, 1] = Convert.ToInt32(c91.Text);
            tab[9, 2] = Convert.ToInt32(c92.Text);
            tab[9, 3] = Convert.ToInt32(c93.Text);
            tab[9, 4] = Convert.ToInt32(c94.Text);
            tab[9, 5] = Convert.ToInt32(c95.Text);
            tab[9, 6] = Convert.ToInt32(c96.Text);
            tab[9, 7] = Convert.ToInt32(c97.Text);
            tab[9, 8] = Convert.ToInt32(c98.Text);
            tab[9, 9] = Convert.ToInt32(c99.Text);

            int com = 0;

            for (int i = 1; i <= 9; i++) {
                for (int j = 1; j <= 9; j++) {
                    if (tab[i, j] != 0) {
                        int a = tab[i, j];
                        line[i, a]++;
                        col[j, a]++;
                        square[findsquare(i, j), a]++;
                        com++;
                    }
                }
            }

            bool possible = true;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int a = tab[i, j];
                    if (a != 0)
                    {
                        if(line[i,a] > 1 || col[j,a] > 1 || square[findsquare(i,j),a] > 1) {
                            possible = false;
                            break;
                        }
                    }

                }
            }




            if (possible)
            {
                solve(com, 1, 1);

                c11.Text = "" + tab[1, 1];
                c12.Text = "" + tab[1, 2];
                c13.Text = "" + tab[1, 3];
                c14.Text = "" + tab[1, 4];
                c15.Text = "" + tab[1, 5];
                c16.Text = "" + tab[1, 6];
                c17.Text = "" + tab[1, 7];
                c18.Text = "" + tab[1, 8];
                c19.Text = "" + tab[1, 9];

                c21.Text = "" + tab[2, 1];
                c22.Text = "" + tab[2, 2];
                c23.Text = "" + tab[2, 3];
                c24.Text = "" + tab[2, 4];
                c25.Text = "" + tab[2, 5];
                c26.Text = "" + tab[2, 6];
                c27.Text = "" + tab[2, 7];
                c28.Text = "" + tab[2, 8];
                c29.Text = "" + tab[2, 9];


                c31.Text = "" + tab[3, 1];
                c32.Text = "" + tab[3, 2];
                c33.Text = "" + tab[3, 3];
                c34.Text = "" + tab[3, 4];
                c35.Text = "" + tab[3, 5];
                c36.Text = "" + tab[3, 6];
                c37.Text = "" + tab[3, 7];
                c38.Text = "" + tab[3, 8];
                c39.Text = "" + tab[3, 9];

                c41.Text = "" + tab[4, 1];
                c42.Text = "" + tab[4, 2];
                c43.Text = "" + tab[4, 3];
                c44.Text = "" + tab[4, 4];
                c45.Text = "" + tab[4, 5];
                c46.Text = "" + tab[4, 6];
                c47.Text = "" + tab[4, 7];
                c48.Text = "" + tab[4, 8];
                c49.Text = "" + tab[4, 9];

                c51.Text = "" + tab[5, 1];
                c52.Text = "" + tab[5, 2];
                c53.Text = "" + tab[5, 3];
                c54.Text = "" + tab[5, 4];
                c55.Text = "" + tab[5, 5];
                c56.Text = "" + tab[5, 6];
                c57.Text = "" + tab[5, 7];
                c58.Text = "" + tab[5, 8];
                c59.Text = "" + tab[5, 9];

                c61.Text = "" + tab[6, 1];
                c62.Text = "" + tab[6, 2];
                c63.Text = "" + tab[6, 3];
                c64.Text = "" + tab[6, 4];
                c65.Text = "" + tab[6, 5];
                c66.Text = "" + tab[6, 6];
                c67.Text = "" + tab[6, 7];
                c68.Text = "" + tab[6, 8];
                c69.Text = "" + tab[6, 9];

                c71.Text = "" + tab[7, 1];
                c72.Text = "" + tab[7, 2];
                c73.Text = "" + tab[7, 3];
                c74.Text = "" + tab[7, 4];
                c75.Text = "" + tab[7, 5];
                c76.Text = "" + tab[7, 6];
                c77.Text = "" + tab[7, 7];
                c78.Text = "" + tab[7, 8];
                c79.Text = "" + tab[7, 9];

                c81.Text = "" + tab[8, 1];
                c82.Text = "" + tab[8, 2];
                c83.Text = "" + tab[8, 3];
                c84.Text = "" + tab[8, 4];
                c85.Text = "" + tab[8, 5];
                c86.Text = "" + tab[8, 6];
                c87.Text = "" + tab[8, 7];
                c88.Text = "" + tab[8, 8];
                c89.Text = "" + tab[8, 9];

                c91.Text = "" + tab[9, 1];
                c92.Text = "" + tab[9, 2];
                c93.Text = "" + tab[9, 3];
                c94.Text = "" + tab[9, 4];
                c95.Text = "" + tab[9, 5];
                c96.Text = "" + tab[9, 6];
                c97.Text = "" + tab[9, 7];
                c98.Text = "" + tab[9, 8];
                c99.Text = "" + tab[9, 9];
            }

            else {
                DisplayAlert("Jogo Impossível", "Não há solução possível, verifique a colocação dos números", "OK");
            }



        }


        public void Limpatudo(Object sender, EventArgs e) {
            c11.Text = "";
            c12.Text = "";
            c13.Text = "";
            c14.Text = "";
            c15.Text = "";
            c16.Text = "";
            c17.Text = "";
            c18.Text = "";
            c19.Text = "";

            c21.Text = "";
            c22.Text = "";
            c23.Text = "";
            c24.Text = "";
            c25.Text = "";
            c26.Text = "";
            c27.Text = "";
            c28.Text = "";
            c29.Text = "";

            c31.Text = "";
            c32.Text = "";
            c33.Text = "";
            c34.Text = "";
            c35.Text = "";
            c36.Text = "";
            c37.Text = "";
            c38.Text = "";
            c39.Text = "";

            c41.Text = "";
            c42.Text = "";
            c43.Text = "";
            c44.Text = "";
            c45.Text = "";
            c46.Text = "";
            c47.Text = "";
            c48.Text = "";
            c49.Text = "";

            c51.Text = "";
            c52.Text = "";
            c53.Text = "";
            c54.Text = "";
            c55.Text = "";
            c56.Text = "";
            c57.Text = "";
            c58.Text = "";
            c59.Text = "";

            c61.Text = "";
            c62.Text = "";
            c63.Text = "";
            c64.Text = "";
            c65.Text = "";
            c66.Text = "";
            c67.Text = "";
            c68.Text = "";
            c69.Text = "";

            c71.Text = "";
            c72.Text = "";
            c73.Text = "";
            c74.Text = "";
            c75.Text = "";
            c76.Text = "";
            c77.Text = "";
            c78.Text = "";
            c79.Text = "";

            c81.Text = "";
            c82.Text = "";
            c83.Text = "";
            c84.Text = "";
            c85.Text = "";
            c86.Text = "";
            c87.Text = "";
            c88.Text = "";
            c89.Text = "";

            c91.Text = "";
            c92.Text = "";
            c93.Text = "";
            c94.Text = "";
            c95.Text = "";
            c96.Text = "";
            c97.Text = "";
            c98.Text = "";
            c99.Text = "";

            for (int i = 1; i <= 9; i++) {
                for (int j = 1; j <= 9; j++) {
                    tab[i, j] = 0;
                    line[i, j] = 0;
                    col[i, j] = 0;
                    square[i, j] = 0;
                }
            }



        }

    }
}
