using System;
using Cap08.Arreglos;//             8.4
using Cap08.Excepciones;//          8.5
using Cap08.CardShuffling;//        8.6
using Cap08.PassElems;//            8.7
using Cap08.GradeBook;//            8.8
using Cap08.MdArrays;//             8.9
using Cap08.GBRectangularArray;//   8.10

namespace Cap08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8.10
            GBRectangularArray.GradeBookTest.Principal();
            #endregion

            #region 8.9
            // MdArrays.InitArray.Principal();
            #endregion

            #region 8.8
            // GradeBookTest.Principal();
            #endregion

            #region 8.7 Passing Arrays
            // PassArray.Principal();
            #endregion

            #region 8.6 Card Shuffling 
            // DeckOfCardTest.Principal(); 
            #endregion

            #region 8.5 Exceptions
            // StudentPoll.First();
            // StudentPoll.Second();
            #endregion

            #region 8.4 Arrays - Vars
            // RollDie.Principal();
            // BarChart.Principal();
            // ForEachTest.Principal();
            // SumArray.Principal();
            // InitArray.Third();
            // InitArray.Second();
            // InitArray.First();
            #endregion
        }
    }
}
